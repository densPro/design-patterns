using System;

namespace Adapter
{
  class Program
  {
    static void Main(string[] args)
    {
      var hole = new RoundHole(5);
      IRound roundPeg = new RoundPeg(5);
      System.Console.WriteLine($"Round hole radius is : {hole.Radius}");
      System.Console.WriteLine($"Round peg radius is : {roundPeg.Radius}");

      bool response = hole.Fits(roundPeg);
      System.Console.WriteLine($"Fits? : {response}");

      ISquare small_sqpeg = new SquarePeg(5);
      ISquare large_sqpeg = new SquarePeg(10);
      System.Console.WriteLine($"Small square peg with is : {small_sqpeg.Width}");
      System.Console.WriteLine($"Large square peg with is : {large_sqpeg.Width}");

      // hole.Fits(small_sqpeg); this won't compile (incompatible types)
      var small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);
      var large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
      System.Console.WriteLine($"Small square peg adapter radious is: {small_sqpeg_adapter.Radius}");
      System.Console.WriteLine($"Large square peg adapter radious is: {large_sqpeg_adapter.Radius}");

      response = hole.Fits(small_sqpeg_adapter);
      System.Console.WriteLine($"Fits? : {response}");

      response = hole.Fits(large_sqpeg_adapter);
      System.Console.WriteLine($"Fits? : {response}");
    }
  }
}
