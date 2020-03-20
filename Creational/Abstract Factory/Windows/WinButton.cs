using System;

namespace Abstract_Factory.Windows
{
  public class WinButton : IButton
  {
    public void Paint() => Console.WriteLine("Render a button in Windows style");
  }
}