using System;
using System.Collections;
using System.Collections.Generic;

namespace BerryUI;

public class WidgetCollection : IEnumerable<Widget> {

    private readonly List<Widget> list = [];

    public int Count => list.Count;

    public void Add(Widget item) {
        list.Add(item);
        //UI.AllWidgets.Add(item);
    }
    public void AddRange(ReadOnlySpan<Widget> items) {
        list.AddRange(items);
        //UI.AllWidgets.AddRange(items);
    }

    IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
    IEnumerator<Widget> IEnumerable<Widget>.GetEnumerator() => list.GetEnumerator();

    // private void OnChildrenChanged(object? sender, NotifyCollectionChangedEventArgs e) {
    //     switch (e.Action) {
    //         case NotifyCollectionChangedAction.Add: {
    //             if (e.NewItems is { } widgets) {
    //                 foreach (Widget widget in widgets) {
    //                     widget.Parent = this;
    //                     widget.InvalidateContentLayout();
    //                     widget.InvalidateContentDraw();
    //                 }
    //                 UI.AddWidgets(widgets);
    //             }
    //             break;
    //         }
    //         case NotifyCollectionChangedAction.Remove: {
    //             if (e.OldItems is { } widgets) {
    //                 foreach (Widget widget in widgets) {
    //                     widget.Parent = null;
    //                 }
    //             }
    //             break;
    //         }
    //
    //         default:
    //             throw new NotImplementedException($"{e.Action} collection changed event");
    //     }
    //
    //     RequestLayout();
    //     RequestDraw();
    // }
}
