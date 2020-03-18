using System;

namespace Prototype
{
  class Program
  {
    static void Main(string[] args)
    {
      Circle circle = new Circle();
      circle.X = 10;
      circle.Y = 10;
      circle.Radius = 20;

      Console.WriteLine("Circle instance");
      Console.WriteLine(circle);

      Console.WriteLine("Cloning circle");

      Circle clonedCircle = (Circle)circle.Clone();
      Console.WriteLine("Cloned circle");
      Console.WriteLine(clonedCircle);

      Rectangle rectangle = new Rectangle();
      rectangle.Width = 10;
      rectangle.Height = 20;
      Console.WriteLine("Rectangle instance");
      Console.WriteLine(rectangle);

      Console.WriteLine("Cloning rectangle");

      Rectangle clonedRectangle = (Rectangle) rectangle.Clone();
      Console.WriteLine("Cloned rectangle");
      Console.WriteLine(clonedRectangle);

    }
  }
}
