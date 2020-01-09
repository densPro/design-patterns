class Whip : CondimentDecorator
{
  public Whip(Beverage beverage): base(beverage)
  {
    Description = beverage.Description + ". Whip";
    Cost = .10 + beverage.Cost;
  }

  public override string Description { get; }
  public override double Cost { get; }
}