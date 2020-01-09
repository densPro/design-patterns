class HouseBlend : Beverage
{
  public HouseBlend() {
    Description = "HouseBlend"; 
    Cost = .89;
  }

  public string Description { get; private set;}
  public double Cost { get; private set; }
}