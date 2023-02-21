using System;
using Shapez.Models;


namespace ShapezMan
{
  public class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(14,25,32);
      Console.WriteLine($"your triangle is {testTriangle.CheckType()}.");
      Console.WriteLine(testTriangle.AddSides());
    }
  }
}
