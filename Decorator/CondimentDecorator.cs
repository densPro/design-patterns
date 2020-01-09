abstract class CondimentDecorator: Beverage {

public CondimentDecorator(Beverage beverage)
{
    this.Beverage = beverage;
}
  protected Beverage Beverage { get; }

  public abstract string Description { get; }

  public abstract double Cost { get;}
}