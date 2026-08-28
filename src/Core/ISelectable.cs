using Godot;

namespace ScrapTown.Godot.Core;

public interface ISelectable
{
    public void Select();
    public void Deselect();

    public void ChangeColor(Color c);
}
