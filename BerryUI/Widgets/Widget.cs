using BerryUI.Render;

namespace BerryUI;

/// The base class of all UI widgets.
public abstract class Widget {
    public USize MinimumSize;
    public URect ContentRect;

    public readonly WidgetCollection Children = new();

    public bool NeedsLayout = true;
    public bool NeedsDraw = true;

    public Widget? Parent { get; private set; }

    public virtual void ResolveLayout() {
        foreach (var child in Children) {
            if (child.NeedsLayout) {
                child.NeedsLayout = false;
                child.ResolveLayout();

                // If a child wants another layout resolution, then we'll need one as well
                NeedsLayout |= child.NeedsLayout;
            }
        }
    }

    public virtual void Draw(CommandBuffer buf) {
        foreach (var child in Children) {
            if (child.NeedsDraw) {
                child.NeedsDraw = false;
                child.Draw(buf);

                // If a child wants another draw, then we'll need one as well
                NeedsDraw |= child.NeedsDraw;
            }
        }
    }

    public void RequestLayout() {
        for (var widget = this; widget is not null; widget = widget.Parent) {
            widget.NeedsLayout = true;
        }
    }
    public void RequestDraw() {
        for (var widget = this; widget is not null; widget = widget.Parent) {
            widget.NeedsDraw = true;
        }
    }
    public void RequestLayoutAndDraw() {
        for (var widget = this; widget is not null; widget = widget.Parent) {
            widget.NeedsLayout = true;
            widget.NeedsDraw = true;
        }
    }

    public void InvalidateLayout() {
        RequestLayout();
        InvalidateContentLayout();
    }
    public void InvalidateContentLayout() {
        foreach (var child in Children) {
            child.NeedsLayout = true;
            child.InvalidateContentLayout();
        }
    }

    public void InvalidateDraw() {
        RequestDraw();
        InvalidateContentDraw();
    }
    public void InvalidateContentDraw() {
        foreach (var child in Children) {
            child.NeedsDraw = true;
            child.InvalidateContentDraw();
        }
    }

    public void InvalidateLayoutAndDraw() {
        RequestLayoutAndDraw();
        InvalidateContentLayoutAndDraw();
    }

    public void InvalidateContentLayoutAndDraw() {
        foreach (var child in Children) {
            child.NeedsLayout = true;
            child.NeedsDraw = true;
            child.InvalidateContentLayoutAndDraw();
        }
    }
}
