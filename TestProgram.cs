namespace Desklite;

class TestProgram
{
    static void Main()
    {
        using DLWindowBase window = new(800, 600, "Test");
        window.Run();
    }
}