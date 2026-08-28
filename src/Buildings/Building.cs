using Godot;
using ScrapTown.Godot.Core;

namespace ScrapTown.Godot.Buildings;

public partial class Building : Node2D, ISelectable
{
    private Sprite2D sprite;

    public override void _Ready()
    {
        sprite = GetNode<Sprite2D>("Sprite");
    }

    public override void _Process(double delta) { }

    public void Select()
    {
        GD.Print($"[Building] {Name}: Selected");
    }

    public void Deselect()
    {
        GD.Print($"[Building] {Name}: Deselected");
    }

    public void ChangeColor(Color c)
    {
        sprite.Modulate = c;
    }
}
