using Iterator.Implementations;

namespace Iterator.Interfaces
{
  public interface IMenuItemIterator
  {
    bool HasNext();
    MenuItem Next();
  }
}