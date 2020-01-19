using System;

namespace Abstract_Factory.MacOS
{
  public class MacCheckbox : ICheckbox
  {
    public void Paint() => Console.WriteLine("Render a checkbox in macOs style");
  }
}