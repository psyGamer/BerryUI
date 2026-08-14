using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace BerryUI;

public class WidgetCollection(Widget widget) : IEnumerable<Widget> {

    private readonly Widget widget = widget;
    private readonly List<Widget> list = [];

    public int Count => list.Count;
    public Widget this[int index] => list[index];

    public void Add(Widget item) {
        Debug.Assert(item.Parent == null, "Widgets may only have one parent at a time");

        var prevItem = list.Count > 0 ? list[^1] : widget;
        list.Add(item);

        item.Parent = widget;
        item.Depth = prevItem.nextDepth;
        item.RecalculateDepth();
    }
    public void AddRange(ReadOnlySpan<Widget> items) {
        var prevItem = list.Count > 0 ? list[^1] : widget;
        list.AddRange(items);

        foreach (var item in items) {
            Debug.Assert(item.Parent == null, "Widgets may only have one parent at a time");

            item.Parent = widget;
            item.Depth = prevItem.nextDepth;
            item.RecalculateDepth();

            prevItem = item;
        }
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
