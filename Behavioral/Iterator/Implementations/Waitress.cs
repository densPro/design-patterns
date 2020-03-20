using Iterator.Implementations.DinerMenus;
using Iterator.Implementations.PancakeHouseMenus;
using Iterator.Interfaces;
using System;

namespace Iterator.Implementations
{
  public class Waitress
  {
    private PancakeHouseMenu _pancakeHouseMenu;
    private DinerMenu _dinerMenu;
    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
      _pancakeHouseMenu = pancakeHouseMenu;
      _dinerMenu = dinerMenu;
    }

    public void PrintMenu()
    {
      var pancakeIterator = _pancakeHouseMenu.CreateIterator();
      var dinerIterator = _dinerMenu.CreateIterator();

      Console.WriteLine("MENU\n----\nBREAKFAST");
      PrintMenu(pancakeIterator);
      Console.WriteLine("\nLUNCH");
      PrintMenu(dinerIterator);
    }

    private void PrintMenu(IMenuItemIterator menuIterator)
    {
      while (menuIterator.HasNext())
      {
        MenuItem menuItem = menuIterator.Next();
        Console.WriteLine($"- {menuItem.Price}, {menuItem.Name}, {menuItem.Description}");
      }
    }
  }
}