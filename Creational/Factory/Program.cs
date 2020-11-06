using System;
using Factory.Logistics;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("########## Transportation company ###########");

      Console.WriteLine("Deliver by Earth");
      DeliverBy(new RoadLogistic());

      Console.WriteLine("Deliver by Sea");
      DeliverBy(new SeaLogistic());

      Console.WriteLine("Efficient Delivery");
      DeliverBy(new ShortPathLogistic());
    }

    static void DeliverBy(Logistic logistic)
    {
      var transport = logistic.CreateTransport();
      transport.Deliver();
    }
  }
}
