using Iterator.Implementations;
using Iterator.Implementations.DinerMenus;
using Iterator.Implementations.PancakeHouseMenus;

namespace Iterator
{
  class Program
  {
    static void Main(string[] args)
    {
      /* on C# is not needed an iterator implementation for collection. They already implements 
         this pattern. Program writen is only for learning purposes*/
      PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
      DinerMenu dinerMenu = new DinerMenu();
      Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
      waitress.PrintMenu();

    }
  }
}
