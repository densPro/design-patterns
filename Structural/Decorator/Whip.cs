class Whip : CondimentDecorator
{
  Beverage beverage;
  public Whip(Beverage beverage)
  {
      this.beverage = beverage;
  }
  public override double GetCost()
  {
    return .10 + beverage.GetCost();
  }

  public override string GetDescription()
  {
    return beverage.GetDescription() + ". Whip";
  }
}