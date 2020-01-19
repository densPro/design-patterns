namespace Abstract_Factory
{
  public interface IGUIFactory
  {
    IButton CreateButton();
    ICheckbox CreateCheckbox();
  }
}