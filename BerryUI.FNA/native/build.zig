const std = @import("std");

pub fn build(b: *std.Build) !void {
    const optimize = b.standardOptimizeOption(.{});

    {
        const target = b.standardTargetOptions(.{});

        const zlib = buildZLib(b, target, optimize);
        const libpng = buildLibpng(b, target, optimize, zlib);
        const freetype = buildFreetype(b, target, optimize, zlib, libpng);
        const kb = buildKb(b, target, optimize);

        b.installArtifact(freetype);
        b.installArtifact(kb);
    }

    const all_step = b.step("all", "Compile native libraries for all targets");

    const targets = [_]std.Build.ResolvedTarget{
        b.resolveTargetQuery(try std.Target.Query.parse(.{ .arch_os_abi = "x86_64-linux-gnu" })),
        b.resolveTargetQuery(try std.Target.Query.parse(.{ .arch_os_abi = "x86_64-macos" })),
        b.resolveTargetQuery(try std.Target.Query.parse(.{ .arch_os_abi = "aarch64-macos" })),
        b.resolveTargetQuery(try std.Target.Query.parse(.{ .arch_os_abi = "x86-windows-gnu" })),
        b.resolveTargetQuery(try std.Target.Query.parse(.{ .arch_os_abi = "x86_64-windows-gnu" })),
    };
    for (targets) |target| {
        const zlib = buildZLib(b, target, optimize);
        const libpng = buildLibpng(b, target, optimize, zlib);
        const freetype = buildFreetype(b, target, optimize, zlib, libpng);

        const usf = installRuntime(b, target, freetype.getEmittedBin(), "freetype");
        all_step.dependOn(&usf.step);
    }
}

/// Copies a file into the appropriate 'runtimes' directory
fn installRuntime(b: *std.Build, target: std.Build.ResolvedTarget, lib_path: std.Build.LazyPath, lib_name: []const u8) *std.Build.Step.UpdateSourceFiles {
    const usf = b.addUpdateSourceFiles();

    const runtimes_dir = b.pathJoin(&.{ "..", "runtimes" });
    if (target.result.os.tag == .linux) {
        const lib_file = b.fmt("lib{s}.so", .{lib_name});
        if (target.result.cpu.arch == .x86_64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "linux-x64", "native", lib_file }));
        } else if (target.result.cpu.arch == .aarch64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "linux-arm64", "native", lib_file }));
        } else {
            @panic("Unsupported architecture");
        }
    } else if (target.result.os.tag == .macos) {
        const lib_file = b.fmt("lib{s}.dylib", .{lib_name});
        if (target.result.cpu.arch == .x86_64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "osx-x64", "native", lib_file }));
        } else if (target.result.cpu.arch == .aarch64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "osx-arm64", "native", lib_file }));
        } else {
            @panic("Unsupported architecture");
        }
    } else if (target.result.os.tag == .windows) {
        const lib_file = b.fmt("{s}.dll", .{lib_name});
        if (target.result.cpu.arch == .x86) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "win-x86", "native", lib_file }));
        } else if (target.result.cpu.arch == .x86_64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "win-x64", "native", lib_file }));
        } else if (target.result.cpu.arch == .aarch64) {
            usf.addCopyFileToSource(lib_path, b.pathJoin(&.{ runtimes_dir, "win-arm64", "native", lib_file }));
        } else {
            @panic("Unsupported architecture");
        }
    } else {
        @panic("Unsupported OS");
    }

    return usf;
}

fn buildZLib(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
) *std.Build.Step.Compile {
    const zlib_dep = b.dependency("zlib", .{});
    const zlib_mod = b.createModule(.{
        .target = target,
        .optimize = optimize,
        .link_libc = true,
        .strip = optimize != .Debug,
    });

    zlib_mod.addCMacro("HAVE_SYS_TYPES_H", "1");
    zlib_mod.addCMacro("HAVE_STDINT_H", "1");
    zlib_mod.addCMacro("HAVE_STDDEF_H", "1");
    zlib_mod.addCMacro("Z_HAVE_UNISTD_H", "1");

    zlib_mod.addCSourceFiles(.{
        .root = zlib_dep.path(""),
        .files = &.{
            "adler32.c",
            "crc32.c",
            "deflate.c",
            "infback.c",
            "inffast.c",
            "inflate.c",
            "inftrees.c",
            "trees.c",
            "zutil.c",
            "compress.c",
            "uncompr.c",
            "gzclose.c",
            "gzlib.c",
            "gzread.c",
            "gzwrite.c",
        },
    });

    const zlib = b.addLibrary(.{
        .name = "zlib",
        .linkage = .static,
        .root_module = zlib_mod,
    });
    zlib.installHeadersDirectory(zlib_dep.path(""), "", .{
        .include_extensions = &.{".h"},
    });

    return zlib;
}
fn buildLibpng(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
    zlib: *std.Build.Step.Compile,
) *std.Build.Step.Compile {
    const libpng_dep = b.dependency("libpng", .{});
    const libpng_mod = b.createModule(.{
        .target = target,
        .optimize = optimize,
        .link_libc = true,
        .strip = optimize != .Debug,
    });

    const wf = b.addWriteFiles();
    _ = wf.addCopyFile(libpng_dep.path("scripts/pnglibconf.h.prebuilt"), "pnglibconf.h");
    libpng_mod.addIncludePath(wf.getDirectory());

    libpng_mod.linkLibrary(zlib);

    libpng_mod.addCMacro("PNG_ARM_NEON_OPT", "0");
    libpng_mod.addCMacro("PNG_POWERPC_VSX_OPT", "0");
    libpng_mod.addCMacro("PNG_INTEL_SSE_OPT", "0");
    libpng_mod.addCMacro("PNG_MIPS_MSA_OPT", "0");

    libpng_mod.addCSourceFiles(.{
        .root = libpng_dep.path(""),
        .files = &.{
            "png.c",
            "pngerror.c",
            "pngget.c",
            "pngmem.c",
            "pngpread.c",
            "pngread.c",
            "pngrio.c",
            "pngrtran.c",
            "pngrutil.c",
            "pngset.c",
            "pngtrans.c",
            "pngwio.c",
            "pngwrite.c",
            "pngwtran.c",
            "pngwutil.c",
        },
    });

    const libpng = b.addLibrary(.{
        .name = "libpng",
        .linkage = .static,
        .root_module = libpng_mod,
    });
    libpng.installHeader(libpng_dep.path("scripts/pnglibconf.h.prebuilt"), "pnglibconf.h");
    libpng.installHeadersDirectory(libpng_dep.path(""), "", .{
        .include_extensions = &.{".h"},
    });

    return libpng;
}
fn buildFreetype(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
    zlib: *std.Build.Step.Compile,
    libpng: *std.Build.Step.Compile,
) *std.Build.Step.Compile {
    const freetype_dep = b.dependency("freetype", .{});
    const freetype_mod = b.createModule(.{
        .target = target,
        .optimize = optimize,
        .link_libc = true,
        .strip = optimize != .Debug,
    });

    freetype_mod.addIncludePath(freetype_dep.path("include"));
    freetype_mod.addCMacro("FT2_BUILD_LIBRARY", "1");

    freetype_mod.linkLibrary(zlib);
    freetype_mod.addCMacro("FT_CONFIG_OPTION_USE_ZLIB", "1");
    freetype_mod.linkLibrary(libpng);
    freetype_mod.addCMacro("FT_CONFIG_OPTION_USE_PNG", "1");

    freetype_mod.addCMacro("HAVE_UNISTD_H", "1");
    freetype_mod.addCMacro("HAVE_FCNTL_H", "1");
    freetype_mod.addCSourceFiles(.{
        .root = freetype_dep.path(""),
        .files = &.{
            "src/autofit/autofit.c",
            "src/base/ftbase.c",
            "src/base/ftsystem.c",
            "src/base/ftdebug.c",
            "src/base/ftbbox.c",
            "src/base/ftbdf.c",
            "src/base/ftbitmap.c",
            "src/base/ftcid.c",
            "src/base/ftfstype.c",
            "src/base/ftgasp.c",
            "src/base/ftglyph.c",
            "src/base/ftgxval.c",
            "src/base/ftinit.c",
            "src/base/ftmm.c",
            "src/base/ftotval.c",
            "src/base/ftpatent.c",
            "src/base/ftpfr.c",
            "src/base/ftstroke.c",
            "src/base/ftsynth.c",
            "src/base/fttype1.c",
            "src/base/ftwinfnt.c",
            "src/bdf/bdf.c",
            "src/bzip2/ftbzip2.c",
            "src/cache/ftcache.c",
            "src/cff/cff.c",
            "src/cid/type1cid.c",
            "src/gzip/ftgzip.c",
            "src/lzw/ftlzw.c",
            "src/pcf/pcf.c",
            "src/pfr/pfr.c",
            "src/psaux/psaux.c",
            "src/pshinter/pshinter.c",
            "src/psnames/psnames.c",
            "src/raster/raster.c",
            "src/sdf/sdf.c",
            "src/sfnt/sfnt.c",
            "src/smooth/smooth.c",
            "src/svg/svg.c",
            "src/truetype/truetype.c",
            "src/type1/type1.c",
            "src/type42/type42.c",
            "src/winfonts/winfnt.c",
        },
    });
    freetype_mod.addIncludePath(freetype_dep.path("src/sfnt"));

    const freetype = b.addLibrary(.{
        .name = "freetype",
        .linkage = .dynamic,
        .root_module = freetype_mod,
    });
    return freetype;
}

fn buildKb(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
) *std.Build.Step.Compile {
    const kb_dep = b.dependency("kb", .{});
    const kb_mod = b.createModule(.{
        .target = target,
        .optimize = optimize,
        .link_libc = true,
        .strip = optimize != .Debug,
    });
    
    const impl_path = b.addWriteFiles()
        .add("kb_text_shape.c", 
            \\#define KB_TEXT_SHAPE_IMPLEMENTATION
            \\#include "kb_text_shape.h"
        );
    
    kb_mod.addIncludePath(kb_dep.path(""));
    kb_mod.addCSourceFile(.{
        .flags = &.{"-fno-sanitize=alignment"},
        .file = impl_path,
        .language = .c,
    });

    const kb = b.addLibrary(.{
        .name = "kb",
        .linkage = .dynamic,
        .root_module = kb_mod,
    });
    return kb;
}
