using Godot;

public partial class CursorManager : Node
{
    [Export]
    private AtlasTexture arrowTexture;

    public override void _Ready()
    {
        GD.Print("Setting cursor to custom texture");
        var image = arrowTexture.GetImage();
        image.Resize(64, 64, Image.Interpolation.Nearest);
        Input.SetCustomMouseCursor(image);
    }
}
