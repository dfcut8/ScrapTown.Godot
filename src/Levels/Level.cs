using Godot;
using ScrapTown.Godot.Buildings;

public partial class Level : Node2D
{
    [Export]
    private Sprite2D highlightCursor;

    [Export]
    private PackedScene campScene;

    private TileMapLayer tileMap;

    public override void _Ready()
    {
        tileMap = GetNode<TileMapLayer>("TileMap");
        highlightCursor = GetNode<Sprite2D>("HighlightCursor");
        highlightCursor.Visible = false;
        var cellGlobalCoords = ToGlobal(tileMap.MapToLocal(new Vector2I(9, 5)));
        tileMap.SetCell(new Vector2I(9, 5));
        var camp = campScene.Instantiate<Building>();
        camp.Position = cellGlobalCoords;
        AddChild(camp);
    }

    public override void _Process(double delta)
    {
        var mousePos = GetGlobalMousePosition();
        GD.Print($"Mouse Position: {mousePos}");

        var tilePos = tileMap.LocalToMap(mousePos);
        GD.Print($"Tile Position: {tilePos}");

        var cellGlobalCoords = ToGlobal(tileMap.MapToLocal(tilePos));
        GD.Print($"Cell coords in global: {cellGlobalCoords}");

        highlightCursor.Position = cellGlobalCoords;
        highlightCursor.Visible = true;
    }
}
