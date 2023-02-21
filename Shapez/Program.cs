using System;
using Shapez.Models;


namespace ShapezMan
{
  public class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(14,25,32);
      Console.WriteLine($"your triangle has these sides: {testTriangle.GetSide1()},{testTriangle.GetSide2()},{testTriangle.GetSide3()}.");
      Console.WriteLine($"your triangle is {testTriangle.CheckType()}.");
      Console.WriteLine("wait a sec. we're getting new numbers now");
      testTriangle.SetSide1(24);
      testTriangle.SetSide2(26);
      testTriangle.SetSide3(18);
      Console.WriteLine($"your triangle now has these sides: {testTriangle.GetSide1()},{testTriangle.GetSide2()},{testTriangle.GetSide3()}.");
      Console.WriteLine(testTriangle.CheckType());
    }
  }
}
