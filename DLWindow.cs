namespace Desklite;

public class DLWindow : DLWindowBase
{
    public DLWindow(int width, int height, string title) : base(width, height, title)
    {

    }

    public DLControl? BaseControl { get; set; }
}