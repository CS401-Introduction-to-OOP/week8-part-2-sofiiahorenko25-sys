namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name): base(name) {}

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"File {Name} is open");
    }

    public override void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
            Console.WriteLine($"File {Name} is close");
        }
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"File {Name} is dispose");
    }
}