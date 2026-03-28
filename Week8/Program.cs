using Week8;

// Value type demo
Point p1 = new Point{X = 1, Y = 2};
Point p2 = p1; // stack copy
p2.X = 10;

Console.WriteLine("Struct demo: ");
p1.Print(); // x = 1, y = 2
p2.Print(); // x = 10, y = 2
Console.WriteLine("копіюється struct, оригінал не змінюється");

// Reference type demo
PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;   // посилання heap
r2.X = 10;

Console.WriteLine("Class demo:");
r1.Print();  // X=10, Y=2
r2.Print();  // X=10, Y=2
Console.WriteLine("клас передає посилання, зміни впливають на обидва");

// Boxing demo
Console.WriteLine("Boxing demo:");
BoxingTester.Test();
