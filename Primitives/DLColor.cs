using System.Globalization;

namespace Desklite.Primitives;

public readonly struct DLColor
{
    public DLColor(byte r, byte g, byte b, byte a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public byte R { get; init; } = 0;
    public byte G { get; init; } = 0;
    public byte B { get; init; } = 0;
    public byte A { get; init; } = 0;

    public static DLColor FromHex(string hex)
    {
        if (hex is null)
            throw new ArgumentNullException(nameof(hex));
        
        if (hex.Length == 7)
            hex += "FF";

        if (hex.Length != 9 || hex[0] != '#')
            throw new ArgumentException(hex + " is not a hex color code.");

        return new(
            byte.Parse(hex.Substring(1, 2), NumberStyles.HexNumber),
            byte.Parse(hex.Substring(3, 2), NumberStyles.HexNumber),
            byte.Parse(hex.Substring(5, 2), NumberStyles.HexNumber),
            byte.Parse(hex.Substring(7, 2), NumberStyles.HexNumber));
    }

    public static string ToHex(DLColor color)
    {
        return
            "#"
            + color.R.ToString("X")
            + color.G.ToString("X")
            + color.B.ToString("X")
            + color.A.ToString("X");
    }

    public static readonly DLColor Transparent = new(255, 255, 255, 0);
    public static readonly DLColor White = new(255, 255, 255, 255);
    public static readonly DLColor Red = new(255, 0, 0, 255);
    public static readonly DLColor Green = new(0, 255, 0, 255);
    public static readonly DLColor Blue = new(0, 0, 255, 255);
    public static readonly DLColor Black = new(0, 0, 0, 255);
}