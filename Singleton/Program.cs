using System;

namespace Singleton {
  class Program {
    /* 
    Actually Singleton pattern is considered by a bunch of people 
    as an antipattern. 

    This example is only for learning purposes.
    */
    static void Main (string[] args) {
      var logger = Logger.GetInstance();
      logger.Print ("########  Logger ########");
      logger.Print (" Printing messages from a single instance");
      logger.Print (" Trying to instancied more than 1 instance. It throws a compilation error");
      // Logger logger1 = new Logger ();
    }
  }
}