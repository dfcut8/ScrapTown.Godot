using Godot;

public partial class TentTier1 : Node2D
{
    private Area2D area;
    private Sprite2D sprite;

    public override void _Ready()
    {

        area = GetNode<Area2D>("%Area2D");
        sprite = GetNode<Sprite2D>("%Sprite2D");
        area.MouseEntered += OnMouseEntered;
        area.MouseExited += OnMouseExited;
    }

    private void OnMouseExited()
    {
        GD.Print("Tent: MouseExited!!!");
        sprite.Modulate = Colors.White;
    }

    private void OnMouseEntered()
    {
        GD.Print("Tent: MouseEntered!!!");
        sprite.Modulate = Colors.Red;
    }

    public override void _Process(double delta) { }
}
