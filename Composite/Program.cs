using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("############ Draw a Graphic ##########");
          Console.WriteLine(">>>>>>>>>>>> IGraphic can draw a Circle");
          var circle = new Circle(5, 5, 5);
          IGraphic graphic = circle;
          graphic.Draw();

          Console.WriteLine(">>>>>>>>>>>> IGraphic can draw a lot of graphics ");
          Console.WriteLine("Create a compound graphic ");
          var compoundGraphic = new CompoundGraphic();
          compoundGraphic.Add(circle);
          compoundGraphic.Add(new Dot(3,3));
          Console.WriteLine("Start Drawing");
          graphic = compoundGraphic;
          graphic.Draw();
        }
    }
}
