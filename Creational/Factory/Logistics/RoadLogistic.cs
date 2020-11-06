using Factory.Transports;

namespace Factory.Logistics
{
  public class RoadLogistic : Logistic
  {
    public Transport CreateTransport()
    {
      return new Truck();
    }
  }
}
