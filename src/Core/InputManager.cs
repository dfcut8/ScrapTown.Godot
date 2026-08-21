using Godot;
using ScrapTown.Godot.Components;

namespace ScrapTown.Godot.Core;

public partial class InputManager : Node2D
{
    public override void _Ready() { }

    public override void _Process(double delta) { }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseEvent)
        {
            if (mouseEvent is InputEventMouseButton buttonEvent)
            {
                if (buttonEvent.Pressed && buttonEvent.ButtonIndex == MouseButton.Left)
                {
                    Vector2 worldPosition = GetGlobalMousePosition();
                    GD.Print($"world position: {worldPosition}");
                    var selectedObject = GetSelectedUnit(worldPosition);
                    selectedObject.Select();
                }
            }
        }
    }

    private ISelectable GetSelectedUnit(Vector2 position)
    {
        var spaceState = GetWorld2D().DirectSpaceState;
        if (spaceState is null)
        {
            GetTree().Quit(1);
        }

        var query = new PhysicsPointQueryParameters2D
        {
            Position = position,
            CollideWithAreas = true,
            CollideWithBodies = false,
        };

        var intersections = spaceState.IntersectPoint(query, 1);
        var component =
            intersections.Count > 0
                ? intersections[0]["collider"].AsGodotObject() as MouseSelectionComponent
                : null;

        if (component == null)
        {
            return null;
        }

        return component.Parent;
    }
}
