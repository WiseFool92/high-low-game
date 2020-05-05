using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideOne;
  public int SideTwo;
  public int SideThree;
  public string triangleName;
  public string triangleType(int s1, int s2, int s3)
  {
    if (s1 + s2 < s3 || s2 + s3 < s1 || s1 + s3 < s2)
    {
      triangleName = "Not a triangle";
    }
    else if (s1 == s2 && s1 == s3)
    {
      triangleName = "equilateral";
    }
    else if (s1 == s2 || s1 == s3 || s2 == s3)
    {
      triangleName = "isosoleces";
    }
    else
    {
      triangleName = "scalene";
    }

    return triangleName;
  }
}
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Side one");
    int sideOne = int.Parse(Console.ReadLine());

    Console.WriteLine("Side Two");
    int sideTwo = int.Parse(Console.ReadLine());

    Console.WriteLine("Side Three");
    int sideThree = int.Parse(Console.ReadLine());

    Triangle equal = new Triangle();
    string triangleName = equal.triangleType(sideOne, sideTwo, sideThree);
    Console.WriteLine(triangleName);
  }
}

