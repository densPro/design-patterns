class Soy : CondimentDecorator
{
  public Soy(Beverage beverage): base(beverage)
  {
    Description = beverage.Description + ". Soy";
    Cost = .15 + beverage.Cost;
  }

  public override string Description { get; }

  public override double Cost { get; }
}
