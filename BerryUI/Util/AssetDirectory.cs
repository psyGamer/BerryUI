using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace BerryUI.Util;

/// Dynamically reloadable container for an arbitrary asset.
public sealed class Asset<T>(Func<T> loader) : AssetDirectory.IResettable {
    private T value = default!;
    private bool hasValue, needsDispose;

    /// Fetches the associated value if needed.
    public T Value {
        get {
            if (hasValue) {
                return value;
            }
            if (needsDispose) {
                ((IDisposable)value!).Dispose();
            }

            value = loader();
            hasValue = true;
            return value;
        }
    }

    /// Clears the cached value, causing it to be loaded again.
    public void Reset() {
        if (hasValue && typeof(T).IsAssignableTo(typeof(IDisposable))) {
            needsDispose = true;
        }

        hasValue = false;
    }
    /// Disposes the cache value, if present
    public void Dispose() {
        if (hasValue && value is IDisposable disposable) {
            disposable.Dispose();
        }
    }
}

/// Generic asset directory which provides a way to retrieve
/// application assets from any required source.
public interface AssetDirectory : IDisposable {
    interface ILoadable<out T> {
        static abstract T Load(Stream data);
    }
    interface IResettable : IDisposable {
        void Reset();
    }

    Asset<T> Get<T>(string path) where T : ILoadable<T>;
    Asset<T> Load<T>(string path, Func<Stream, T> loader);

    /// File system backed asset directory implementation, with asset reloading support
    sealed class FileSystem : AssetDirectory {
        private readonly string rootPath;

        private readonly Dictionary<string, IResettable> assetMap = new();
        private readonly FileSystemWatcher? watcher;

        public FileSystem(string rootPath, bool hotReload) {
            this.rootPath = rootPath;

            if (hotReload) {
                watcher = new FileSystemWatcher(rootPath);
                watcher.Created += OnContentChanged;
                watcher.Deleted += OnContentChanged;
                watcher.Renamed += OnContentChanged;
                watcher.Changed += OnContentChanged;
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;
            }
        }

        private void OnContentChanged(object _, FileSystemEventArgs args) {
            string assetPath = Path.GetRelativePath(rootPath, args.FullPath).Replace('\\', '/');
            if (!assetMap.TryGetValue(assetPath, out var asset)) {
                return;
            }

            asset.Reset();
        }

        public Asset<T> Get<T>(string path) where T : ILoadable<T> {
            ref var asset = ref CollectionsMarshal.GetValueRefOrAddDefault(assetMap, path, out bool exists);
            if (exists) {
                return (Asset<T>)asset!;
            }

            asset = new Asset<T>(T () => {
                string fullPath = Path.Combine(rootPath, path);
                using var fs = File.OpenRead(fullPath);
                return T.Load(fs);
            });
            return (Asset<T>)asset;
        }
        public Asset<T> Load<T>(string path, Func<Stream, T> loader) {
            ref var asset = ref CollectionsMarshal.GetValueRefOrAddDefault(assetMap, path, out bool exists);
            if (exists) {
                return (Asset<T>)asset!;
            }

            asset = new Asset<T>(T () => {
                string fullPath = Path.Combine(rootPath, path);
                using var fs = File.OpenRead(fullPath);
                return loader(fs);
            });
            return (Asset<T>)asset;
        }

        public void Dispose() {
            foreach (var asset in assetMap.Values) {
                asset.Reset();
            }
        }
    }


}
