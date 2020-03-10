using System;
using Iterator.Interfaces;

namespace Iterator.Implementations.DinerMenus
{
  public class DinerMenu
  {
    public const int MAX_ITEMS = 6;
    private const string Full_Message = "Sorry, menu is full!Can’t add item to menu";
    private MenuItem[] _menuItems;
    public int NUMBER_OF_ITEMS = 0;

    public DinerMenu()
    {
      _menuItems = new MenuItem[MAX_ITEMS];
      AddItem("Vegetarian BLT",
      "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
      AddItem("BLT",
      "Bacon with lettuce & tomato on whole wheat", false, 2.99);
      AddItem("Soup of the day",
      "Soup of the day, with a side of potato salad", false, 3.29);
      AddItem("Hotdog",
      "A hot dog, with saurkraut, relish, onions, topped with cheese",
      false, 3.05);
      // a couple of other Diner Menu items added here

    }
    public void AddItem(string name, string description, bool vegetarian, double price)
    {
      MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
      if (NUMBER_OF_ITEMS >= MAX_ITEMS)
      {
        Console.WriteLine(Full_Message);
      }
      else
      {
        _menuItems[NUMBER_OF_ITEMS] = menuItem;
        NUMBER_OF_ITEMS = NUMBER_OF_ITEMS + 1;
      }
    }

    public IMenuItemIterator CreateIterator()
    {
      return new DinerMenuIterator(_menuItems);
    }
  }
}