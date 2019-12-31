class Expresso : Beverage
{
  public Expresso() {
    description = "Expresso"; 
  }
  public override double GetCost()
  {
    return 1.99;
  }
}