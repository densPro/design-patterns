class Expresso : Beverage
{
  public Expresso() {
    // Description = "Expresso";
    // Cost = 1.99;
  }

  public string Description => "Expreso";
  public double Cost { get; private set; }
}