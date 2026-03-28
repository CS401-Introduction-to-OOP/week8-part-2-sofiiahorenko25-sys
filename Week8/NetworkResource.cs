namespace Week8;

public class NetworkResource : Resource, IDisposable
{
   public NetworkResource(string name) : base(name) {}

   public override void Open()
   {
      IsOpen = true;
      Console.WriteLine($"Network {Name} connected");
   }

   public override void Close()
   {
      if (IsOpen)
      {
         IsOpen = false;
         Console.WriteLine($"Network {Name} Disconnected");
      }
   }

   public void Dispose()
   {
      Close();
      Console.WriteLine($"Network {Name} is dispose");
   }
}