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

  public bool GamePlay(string highLowCorrect, int rand)
  {
    bool didIWin = false;
    if (highLowCorrect == "lower")
    {
      this.Upper = rand;
    }
    else if (highLowCorrect == "higher")
    {
      this.Lower = rand;
    }
    else
    {
      didIWin = true;
    }
      return didIWin;

  }

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
    LoopIt(game);
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

    public static void LoopIt(Game game)
    {
      bool won = false;
      while (won == false) 
      {
        int rand = game.Limits();
        Console.WriteLine("Is your number higher or lower than " + rand + "? (higher/Lower/Correct)");
        string response = Console.ReadLine();
        won = game.GamePlay(response, rand);
      }
      Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
      string answer = Console.ReadLine();
      if (answer == "yes")
      {
        Main();
      }
      else
      {
        
      }
    }
}