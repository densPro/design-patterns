namespace Prototype
{
  public class Circle : Shape
  {
    public int Radius { get; set; }
    public Circle() { }
    public Circle(Circle source) : base(source)
    {
      Radius = source.Radius;
    }
    public override Shape Clone()
    {
      return new Circle(this);
    }

    public override string ToString()
    {
      return $" -Start Position: \n   X: {X} \n   Y {Y} \n -Radius: {Radius}";
    }
  }
}