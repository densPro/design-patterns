namespace Adapter
{
  public class SquarePegAdapter : IRound
  {
    private ISquare squarePeg;
    public SquarePegAdapter(ISquare squarePeg)
    {
      this.squarePeg = squarePeg;
    }

    public double Radius => squarePeg.Width * System.Math.Sqrt(2)/2;
  }
}