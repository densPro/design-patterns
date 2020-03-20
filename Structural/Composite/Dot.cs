using System;
namespace Composite
{
  public class Dot : IGraphic
  {
    protected double x;
    protected double y;
    public Dot(double x, double y)
    {
      this.x = x;
      this.y = y;
    }
    public virtual void Draw()
    {
      Console.WriteLine($"Draw a dot at X: {this.x} and Y: {this.y}");
    }

    public void Move(double x, double y)
    {
      this.x += x;
      this.y += y;
    }
  }
}