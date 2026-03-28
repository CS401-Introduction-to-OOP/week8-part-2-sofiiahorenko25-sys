namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; // value type stack
        object b = a; // boxing - value copy to heap
        int c = int(b); // unboxing - heap to stack
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}