namespace Abstract_Factory.Windows
{
  public class WinCheckbox : ICheckbox
  {
    public void Paint() => System.Console.WriteLine("Render a checkbox in windows style.");
  }
}