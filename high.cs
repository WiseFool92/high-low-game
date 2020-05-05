using System;
using System.Collections.Generic;


public class Game
{
  public int Upper;
  public int Lower;

  public Game(int lower, int upper)
  {
    Lower = lower;
    Upper = upper;
  }
  public int Limits()
  {
    Random random = new Random();
    int randNum = random.Next(Lower, Upper);
    
    return randNum;
  }

  public 

}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
    string yesOrNo = Console.ReadLine();

    if ((yesOrNo.ToLower() == "yes"))
    {
      Game game = new Game(1, 100);
      int rand = game.Limits();


    }
    else
    {
      Console.WriteLine("Sad computer is sad");
    }

    string highLow = Console.ReadLine();

    int randomNum = RandomNumber(1, 100);
  }
    public static int RandomNumber(int min, int max)
    {
      Random random = new Random();
      return random.Next(min,max);
    }
}