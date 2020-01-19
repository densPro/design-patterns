namespace Abstract_Factory
{
  public class Application
  {
    private IButton button;
    private ICheckbox checkbox;
    public Application(IGUIFactory guiFactory)
    {
      button = guiFactory.CreateButton();
      checkbox = guiFactory.CreateCheckbox();
    }

    public void Paint()
    {
      System.Console.WriteLine("Start painting from application");
      button.Paint();
      checkbox.Paint();
    }
  }
}