using Godot;
using ScrapTown.Godot.Core;

namespace ScrapTown.Godot.Components;

public partial class MouseSelectionComponent : Area2D
{
    public ISelectable Parent;

    public override void _Ready()
    {
        Parent = GetParent<ISelectable>();
        MouseEntered += OnMouseEntered;
        MouseExited += OnMouseExited;
    }

    private void OnMouseExited()
    {
        Parent.ChangeColor(Colors.White);
    }

    private void OnMouseEntered()
    {
        GD.Print("D: OnMouseEntered");
        Parent.ChangeColor(Colors.Red);
    }
}
