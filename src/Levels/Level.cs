using Godot;

public partial class Level : Node2D
{
    [Export]
    private Sprite2D highlightCursor;

    private TileMapLayer tileMap;

    public override void _Ready()
    {
        tileMap = GetNode<TileMapLayer>("TileMap");
        highlightCursor = GetNode<Sprite2D>("HighlightCursor");
        highlightCursor.Visible = false;
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
