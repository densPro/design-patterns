namespace Adapter
{
  public class RoundHole: IRound
  {
    public RoundHole(double radius) => Radius = radius;
    public double Radius { get; }
    public bool Fits(IRound roundPeg) => Radius >= roundPeg.Radius;
  }
}