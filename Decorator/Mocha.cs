class Mocha : CondimentDecorator
{
  Beverage beverage;
  public Mocha(Beverage beverage)
  {
      this.beverage = beverage;
  }
  public override double GetCost()
  {
    return .20 + beverage.GetCost();
  }

  public override string GetDescription()
  {
    return beverage.GetDescription() + ". Mocha";
  }
}