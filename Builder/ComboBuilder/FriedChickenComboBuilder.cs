using Builder.Food;
using Builder.Food.FriedFoodModule;

namespace Builder.ComboBuilder
{
  public class FriedChickenComboBuilder : IComboBuilder
  {
    private Combo combo;

    public FriedChickenComboBuilder()
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
      combo.MainFriedFood = new Chicken();
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