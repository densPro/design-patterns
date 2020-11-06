using System;
using Factory.Transports;

namespace Factory.Logistics
{
  public class ShortPathLogistic : Logistic
  {
    public Transport CreateTransport()
    {
      Random rnd = new Random();
      int shortPathLogistic = rnd.Next(2);
      switch (shortPathLogistic)
      {
        case 0:
          return new Ship();
        case 1:
        default:
          return new Truck();
      }
    }
  }
}