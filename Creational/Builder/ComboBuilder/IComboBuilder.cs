using Builder.Food;
using Builder.Food.FriedFoodModule;

namespace Builder.ComboBuilder
{
  public interface IComboBuilder
  {
    IComboBuilder WithCoke();
    IComboBuilder WithFrenchFries();
    IComboBuilder WithMainFriedFood();
    IComboBuilder WithToy();
    Combo Build();
  }
}