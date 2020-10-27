namespace Adapter
{
  public class RoundPeg : IRound
  {
    public RoundPeg(double radius)
    {
      Radius = radius;
    }
    public double Radius { get; }
  }
}