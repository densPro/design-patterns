namespace Prototype
{
  public abstract class Shape
  {
    private string _color;
    public int X { get; set; }
    public int Y { get; set; }
    public Shape()
    {
      _color = "Default color - white";
    }
    public Shape(Shape source)
    {
      X = source.X;
      Y = source.Y;
      _color = source._color;
    }

    public abstract Shape Clone();
  }
}