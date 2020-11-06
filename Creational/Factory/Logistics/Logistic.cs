using Factory.Transports;

namespace Factory.Logistics
{
  public interface Logistic
  {
    Transport CreateTransport();
  }
}
