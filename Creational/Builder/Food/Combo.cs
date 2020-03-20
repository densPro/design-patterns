using System.Text;
using Builder.Food.FriedFoodModule;

namespace Builder.Food
{
  public class Combo
  {
    public Coke Coke { get; set; }
    public Toy Toy { get; set; }
    public FrenchFriesPack FrenchFriesPack { get; set; }
    public MainFriedFood MainFriedFood { get; set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder("Combo Contains: \n");
      stringBuilder.AppendFormat(" - Coke: {0} \n", Coke);
      stringBuilder.AppendFormat(" - French Fries: {0} \n", FrenchFriesPack);
      stringBuilder.AppendFormat(" - Main fried food: {0} \n", MainFriedFood);
      stringBuilder.AppendFormat(" - Toy: {0} \n", Toy);

      return stringBuilder.ToString();
    }
  }
}