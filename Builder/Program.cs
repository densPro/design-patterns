using Builder.ComboBuilder;
using Builder.Food;
using System;

namespace Builder
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" ################# Fast Food Restaurant ############################# ");
      Console.WriteLine("Cashie makes a Burger combo ");
      IComboBuilder comboBuilder = new BurgerComboBuilder();
      Cashier cashier = new Cashier(comboBuilder);
      Combo combo = cashier.MakeCombo();
      Console.WriteLine(combo.ToString());

      Console.WriteLine("Cashie makes a chiken combo ");
      cashier.ComboBuilder = new FriedChickenComboBuilder();
      combo = cashier.MakeCombo();
      Console.WriteLine(combo.ToString());
    }
  }
}
