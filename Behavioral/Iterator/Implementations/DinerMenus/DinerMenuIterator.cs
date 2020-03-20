using Iterator.Interfaces;

namespace Iterator.Implementations.DinerMenus
{
  public class DinerMenuIterator : IMenuItemIterator
  {
    private int _position = 0;
    private MenuItem[] _menuItems;

    public DinerMenuIterator(MenuItem[] menuItems) => _menuItems = menuItems;
    public bool HasNext()
    {
      return !(_position >= _menuItems.Length || _menuItems[_position] == null);
    }

    public MenuItem Next()
    {
      MenuItem menuItem = _menuItems[_position];
      _position = _position + 1;
      return menuItem;
    }
  }
}