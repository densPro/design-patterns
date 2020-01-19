namespace Abstract_Factory.MacOS
{
  public class MacFactory : IGUIFactory
  {
    public IButton CreateButton()
    {
      return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
      return new MacCheckbox();
    }
  }
}