namespace Desklite.Primitives;

public readonly struct DLMargin
{
    public DLMargin(int width)
    {
        Left = width;
        Top = width;
        Right = width;
        Bottom = width;
    }

    public DLMargin(int leftright, int topbottom)
    {
        Left = leftright;
        Top = topbottom;
        Right = leftright;
        Bottom = topbottom;
    }

    public DLMargin(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    public int Left { get; init; } = 0;
    public int Top { get; init; } = 0;
    public int Right { get; init; } = 0;
    public int Bottom { get; init; } = 0;

    public static readonly DLMargin Zero = new();
}