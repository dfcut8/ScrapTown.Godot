using Godot;
using ScrapTown.Godot.Core;

namespace ScrapTown.Godot.Components;

public partial class MouseSelectionComponent : Area2D
{
    public ISelectable Parent;

    public override void _Ready()
    {
        Parent = GetParent<ISelectable>();
    }
}
