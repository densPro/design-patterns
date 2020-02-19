using System;
namespace Composite
{
  public class Circle : Dot
  {
    private double radius;
    public Circle(double x, double y, double radius) : base(x, y)
    {
      this.radius = radius;
    }

    public override void Draw()
    {
      Console.WriteLine($"Draw a circle at X: {x} and Y: {y} with radius R: {radius}");
    }
  }
}