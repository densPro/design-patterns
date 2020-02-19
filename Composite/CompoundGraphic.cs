using System;
using System.Collections.Generic;

namespace Composite
{
  public class CompoundGraphic : IGraphic
  {
    private IList<IGraphic> children;

    public CompoundGraphic()
    {
        this.children = new List<IGraphic>();
    }
    public void Draw()
    {
      foreach (var child in children)
      {
        child.Draw();
      }
    }

    public void Move(double x, double y)
    {
      foreach (var child in children)
      {
          child.Move(x, y);
      }
    }

    public void Add(IGraphic child)
    {
      children.Add(child);
      Console.WriteLine("Add a child to the array of children.");
    }

    public void Remove(IGraphic child)
    {
      children.Remove(child);
      Console.WriteLine("Remove a child from the array of children.");
    }
  }
}