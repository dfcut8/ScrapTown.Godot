using Godot;

public partial class Building : Area2D
{
    private Sprite2D sprite;

    public override void _Ready()
    {
        //area = GetNode<Area2D>("%Area2D");
        //sprite = GetNode<Sprite2D>("%Sprite2D");
        MouseEntered += OnMouseEntered;
        MouseExited += OnMouseExited;
        //area.InputEvent += OnInputEvent;
    }

    public override void _Process(double delta) { }

    private void OnInputEvent(Node viewport, InputEvent @event, long shapeIdx)
    {
        if (@event is InputEventMouseButton mouseEvent)
        {
            if (mouseEvent.ButtonIndex == MouseButton.Left && mouseEvent.Pressed)
            {
                GD.Print($"Tent ({Name}): Left Mouse Clicked!!!");
            }
        }
    }

    private void OnMouseExited()
    {
        GD.Print("Tent: MouseExited!!!");
        sprite.SetInstanceShaderParameter("effect_enabled", false);
    }

    private void OnMouseEntered()
    {
        GD.Print("Tent: MouseEntered!!!");
        sprite.SetInstanceShaderParameter("effect_enabled", true);
    }
}
