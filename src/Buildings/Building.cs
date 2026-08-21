using Godot;
using ScrapTown.Godot.Core;

namespace ScrapTown.Godot.Buildings;

public partial class Building : Node2D, ISelectable
{
    public override void _Ready() { }

    public override void _Process(double delta) { }

    public void Select()
    {
        GD.Print($"[Building] {Name}: Selected");
    }

    public void Deselect()
    {
        GD.Print($"[Building] {Name}: Deselected");
    }
}
