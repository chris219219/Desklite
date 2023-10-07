using Desklite.Primitives;

namespace Desklite.Controls;

public abstract class DLControl
{
    private int _width = 0;
    private int _height = 0;
    private DLMargin _margin;
    private readonly List<DLControl> _children = new();
    private Color4 _backgroundColor = Color4.Transparent;

    public int Width { get { return _width; } set { _width = value; } }
    public int Height { get { return _height; } set { _height = value; } }
    public List<DLControl> Children { get { return _children; } }
}