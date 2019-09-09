using System;

namespace intro_to_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var lower = min;
      var upper = max;
      var guess = 50;
      var guessing = true;
      Console.WriteLine("Pick a number between 1 and 100");

      while (guessing == true)
      {
        Console.WriteLine($"Is Your Number,{guess}");

        var input = Console.ReadLine();

        if (input == "yes")
        {
          guessing = false;
        }
        else
        {
          Console.WriteLine("Higher or Lower?");
          var high = Console.ReadLine();
          if (high == "higher")
          {
            min = guess;
            guess = (min + max) / 2;
          }
          else
          {
            max = guess;
            guess = (min + max) / 2;
          }
        }

        {


        }




      }
      Console.WriteLine($"Congrats! Your number is {guess}");
    }
  }
}


