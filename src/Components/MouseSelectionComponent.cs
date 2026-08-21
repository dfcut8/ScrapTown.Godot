using Godot;

namespace ScrapTown.Godot;

public partial class MouseSelectionComponent : Area2D
{
    public ISelectable Parent;

    public override void _Ready()
    {
        Parent = GetParent<ISelectable>();
    }
}
