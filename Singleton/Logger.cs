using System;
namespace Singleton {
  public class Logger {
    private static Logger instance;
    private Logger () { }

    public static Logger GetInstance () 
    {
      if (instance == null)
      {
        instance = new Logger();
        return instance;
      }
      return instance;
    }

    public void Print(string message)
    {
      // Show messages are encapsulated on a class. It will make easy to change 
      // the way how messages are shown.
      Console.WriteLine(message);
    }
  }
}