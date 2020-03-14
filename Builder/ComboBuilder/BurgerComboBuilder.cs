using Builder.Food;
using Builder.Food.FriedFoodModule;

namespace Builder.ComboBuilder
{
  public class BurgerComboBuilder : IComboBuilder
  {
    private Combo combo;

    public BurgerComboBuilder()
    {
        combo = new Combo();
    }
    public IComboBuilder WithCoke()
    {
      combo.Coke = new Coke();
      return this;
    }

    public IComboBuilder WithFrenchFries()
    {
      combo.FrenchFriesPack = new FrenchFriesPack();
      return this;
    }

    public IComboBuilder WithMainFriedFood()
    {
      combo.MainFriedFood = new Hamburger();
      return this;
    }

    public IComboBuilder WithToy()
    {
      combo.Toy = new Car();
      return this;
    }

    public Combo Build()
    {
      return combo;
    }
  }
}