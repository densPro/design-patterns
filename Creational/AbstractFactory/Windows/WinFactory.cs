
namespace Abstract_Factory.Windows
{
  public class WinFactory : IGUIFactory
  {
    public IButton CreateButton()
    {
      return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
      return new WinCheckbox();
    }
  }
}