namespace Prototype
{
  public class Rectangle : Shape
  {
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }
    public Rectangle(Rectangle source) : base(source)
    {
      Width = source.Width;
      Height = source.Height;
    }

    public override Shape Clone()
    {
      return new Rectangle(this);
    }
    
    public override string ToString()
    {
      return $" -Start Position: \n   X: {X} \n   Y: {Y} \n  -Width: {Width} \n  -Height {Height}";
    }
  }
}