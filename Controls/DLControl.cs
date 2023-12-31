﻿namespace Desklite.Controls;

public abstract class DLControl
{
    public int Width { get; set; } = 0;
    public int Height { get; set; } = 0;
    public DLMargin Margin { get; set; } = DLMargin.Zero;
    public DLHorizontalAlignment HAlignment { get; set; } = DLHorizontalAlignment.Fill;
    public DLVerticalAlignment VAlignment { get; set; } = DLVerticalAlignment.Fill;
    public List<DLControl> Children { get; set; } = new();
    public DLColor BackgroundColor { get; set; } = DLColor.Transparent;
}