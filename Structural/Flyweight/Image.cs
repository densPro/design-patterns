using System;

namespace Flyweight
{
  public class Image : IDisplayable
  {
    protected string _fileName;

    public Image(string fileName)
    {
      _fileName = fileName;
    }
    public void Display(int x, int y, int width, int height)
    {
      Console.WriteLine($"<img src=\"pic_trulli.jpg\" alt=\"Italian Trulli\" style=\" left:{x}px top:{y}px width:{width}px height:{height}px \">");
    }
  }
}