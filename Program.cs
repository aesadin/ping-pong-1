using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Input a positive integer number:");
    int number = int.Parse(Console.ReadLine());
    if(number < 1) 
    {
      Console.WriteLine("Your input is incorrect");
      Main();
    }
    Console.WriteLine("Output: ");
    for(int i = 1; i <= number; i++)
    {
      if (i % 3 == 0 && i % 5 == 0) 
      {
        Console.WriteLine("ping-pong");
      } 
      else if (i % 3 == 0) 
      {
        Console.WriteLine("ping");
      } 
      else if (i % 5 == 0) 
      {
        Console.WriteLine("pong");
      } 
      else 
      {
        Console.WriteLine(i);
      }
    }
  }
}