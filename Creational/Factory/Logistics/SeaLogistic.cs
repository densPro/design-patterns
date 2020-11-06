using Factory.Transports;

namespace Factory.Logistics
{
  public class SeaLogistic : Logistic
  {
    public Transport CreateTransport()
    {
        return new Ship();
    }
  }
}