abstract class Beverage {
   protected string description = "Unknown Beverage";

  public virtual string GetDescription() {
     return description;
   }

   public abstract double GetCost();
}