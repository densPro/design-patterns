using System;

namespace Abstract_Factory.MacOS
{
  public class MacButton : IButton
  {
    public void Paint() => Console.WriteLine("Render a button in MacOs style");
  }
}