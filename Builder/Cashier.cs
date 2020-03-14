using Builder.ComboBuilder;
using Builder.Food;

namespace Builder
{
  public class Cashier
  {
    public IComboBuilder ComboBuilder { private get; set; }
    public Combo Combo { get; private set; }

    public Cashier(IComboBuilder comboBuilder)
    {
        ComboBuilder = comboBuilder;
    }
    public Combo MakeCombo()
    {
      Combo = ComboBuilder.WithCoke()
                          .WithFrenchFries()
                          .WithMainFriedFood()
                          .WithToy()
                          .Build();
      return Combo;
    }
  }
}