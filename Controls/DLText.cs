namespace Desklite.Controls;

public class DLText : DLContentControl
{
    private string _text = string.Empty;

    public DLText()
    {
        ContentColor = DLColor.Black;
    }

    public string Text { get { return _text; } set { _text = value; } }
}