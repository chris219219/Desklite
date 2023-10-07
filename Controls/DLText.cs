namespace Desklite.Controls;

public class DLText : DLControl
{
    private string _text = string.Empty;

    public DLText()
    {
        
    }

    public string Text { get { return _text; } set { _text = value; } }
}