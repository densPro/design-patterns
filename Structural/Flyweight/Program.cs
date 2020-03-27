using System;

namespace Flyweight
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("########## Gazillion #########");

      Console.WriteLine("Instanciate an image factory");
      var factory = new ImageFactory();

      Console.WriteLine("Display image");
      var image = factory.GetImage("image.png");
      image.Display(0, 0, 400, 250);

      Console.WriteLine("\n Display another image");
      image = factory.GetImage("image.png");
      image.Display(60, 420, 200, 90);

      Console.WriteLine("\n Display another image");
      image = factory.GetImage("image.png");
      image.Display(0, 0, 400, 250);
    }
  }
}
