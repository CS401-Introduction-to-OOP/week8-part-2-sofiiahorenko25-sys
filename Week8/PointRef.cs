namespace Week8;

public class PointRef
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"PointRef: {X}, {Y}");
    }
}