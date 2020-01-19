using System;
using Abstract_Factory.MacOS;
using Abstract_Factory.Windows;

namespace Abstract_Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Introduce OS name:");
      string OS = Console.ReadLine();
      IGUIFactory guiFactory;
      switch (OS)
      {
        case "Windows":
        default:
          guiFactory = new WinFactory();
          break;
        case "Mac":
          guiFactory = new MacFactory();
          break;
      }
      Application app = new Application(guiFactory);
      app.Paint();
    }
  }
}
