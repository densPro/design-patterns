namespace Adapter
{
  public class SquarePeg: ISquare
  {
    public SquarePeg(uint width)
    {
      Width = width;
    }

    public uint Width { get; }
  }
}