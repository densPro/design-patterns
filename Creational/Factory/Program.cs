using System;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("########## Transportation company ###########");
      DeliverBy(new RoadLogistic());

      Console.WriteLine("Change Logistic");
      DeliverBy(new SeaLogistic());
    }

    static void DeliverBy(Logistic logistic)
    {
      var transport = logistic.CreateTransport();
      transport.Deliver();
    }
  }
}
