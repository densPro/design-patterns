using System;
using System.Collections.Generic;

namespace Flyweight
{
  public class ImageFactory
  {
    private Dictionary<string, IDisplayable> flyweights = new Dictionary<string, IDisplayable>();

    public IDisplayable GetImage(string fileName)
    {
      IDisplayable flyweightImage = null;
      if (flyweights.TryGetValue(fileName, out flyweightImage))
      {
        Console.WriteLine($"Returning cached image {fileName}");
        return flyweightImage;
      }

      flyweightImage = new Image(fileName);
      flyweights.Add(fileName, flyweightImage);
      Console.WriteLine($"Returning new image {fileName}");
      return flyweightImage;
    }
  }
}