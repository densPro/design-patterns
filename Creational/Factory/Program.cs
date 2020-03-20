using System;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("########## Transportation company ###########");
      Logistic logistic = new RoadLogistic();
      Transport transport = logistic.CreateTransport();
      transport.Deliver();

      Console.WriteLine("Change Logistic");
      logistic = new SeaLogistic();
      transport = logistic.CreateTransport();
      transport.Deliver();
    }
  }
}
