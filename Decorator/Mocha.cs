class Mocha : CondimentDecorator
{
  public Mocha(Beverage beverage): base(beverage)
  {
    Cost = .20 + beverage.Cost;
    Description = beverage.Description + ". Mocha";
  }

  public override string Description { get; }

  public override double Cost { get; }

}