class Soy : CondimentDecorator
{
  Beverage beverage;
  public Soy(Beverage beverage)
  {
      this.beverage = beverage;
  }
  public override double GetCost()
  {
    return .15 + beverage.GetCost();
  }

  public override string GetDescription()
  {
    return beverage.GetDescription() + ". Soy";
  }
}