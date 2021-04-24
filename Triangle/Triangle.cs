using System;
using Triangle.Models;

namespace TriangleTracker 
{
  public class TriangleProgram
  {
    public static void Main()
    {
      Console.WriteLine("Let's figure out if we have a triangle! Enter the length of one side (please use a numeral):");
      string stringAnswerOne = Console.ReadLine();
      int answerOne = int.Parse(stringAnswerOne);

    }
  }
}