using System;

namespace Factory.Transports
{
  public class Truck : Transport
  {
    public void Deliver()
    {
      Console.WriteLine("Truck: Deliver by earth");
    }
  }
}
