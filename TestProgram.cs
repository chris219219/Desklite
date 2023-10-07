namespace Desklite;

class TestProgram
{
    static void Main()
    {
        using DLWindow window = new(800, 600, "Test");
        window.Run();
    }
}