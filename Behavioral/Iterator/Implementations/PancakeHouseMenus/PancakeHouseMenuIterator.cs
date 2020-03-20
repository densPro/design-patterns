using System.Collections.Generic;
using Iterator.Implementations;
using Iterator.Interfaces;

namespace Iterator.Implementations.PancakeHouseMenus
{
  public class PancakeHouseMenuIterator : IMenuItemIterator
  {
    private int _position = 0;
    private List<MenuItem> _menuItems;
    public PancakeHouseMenuIterator(List<MenuItem> menuItems) => _menuItems = menuItems;

    public bool HasNext()
    {
      return _position < _menuItems.Count;
    }

    public MenuItem Next()
    {
      return _menuItems[_position++];
    }
  }
}