using System;

namespace Factory.Transports
{
  public class Ship : Transport
  {
    public void Deliver()
    {
      Console.WriteLine("Ship: Deliver by the sea");
    }
  }
}
