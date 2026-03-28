using Week8;

var container = new DataContainer<DataItem>();
for (int i = 0; i < 10000; i++)
{
    var item = new DataItem()
    {
        Id = $"item-{i}",
        Payload = new byte[1024]
    };
    container.Add(item);
}
Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");
GC.Collect();
GC.WaitForPendingFinalizers();
Console.WriteLine("GC.Collect() was called.");
Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");