namespace Desklite;

public class DLWindow : GameWindow
{
    public DLWindow(int width, int height, string title) : base(
        GameWindowSettings.Default,
        new NativeWindowSettings()
        {
            IsEventDriven = true,
            WindowState = WindowState.Normal,
            Title = title,
            Size = new(width, height)
        })
    {

    }

    private DLShader? _shader;

    private float[] _vertices =
    {
        -0.5f, -0.5f, 0.0f,
        0.5f, -0.5f, 0.0f,
        0.0f, 0.5f, 0.0f
    };

    private int _vertexBufferObject;
    private int _vertexArrayObject;

    protected override void OnLoad()
    {
        base.OnLoad();

        GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);

        _shader = new("shader.vert", "shader.frag");

        _vertexBufferObject = GL.GenBuffer();
        _vertexArrayObject = GL.GenVertexArray();
        GL.BindVertexArray(_vertexArrayObject);

        GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
        GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);

        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
        GL.EnableVertexAttribArray(0);
    }

    protected override void OnUnload()
    {
        base.OnUnload();

        _shader?.Dispose();
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        _shader?.Use();
        GL.BindVertexArray(_vertexArrayObject);
        GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

        SwapBuffers();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);

        GL.Viewport(0, 0, e.Width, e.Height);
    }
}