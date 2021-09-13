using System;

public class Program
{
	public static void Main(string[]args)
	{
		for (int i = 1; i <= 100; i++) 
		{
			if (i % 7 == 0)
			{
				if (i % 15 == 0)
				{
					Console.WriteLine(" FizzBuzzBang ");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("FizzBang");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("BuzzBang");
				}
				else 
				{
					Console.WriteLine("Bang");
				}
			}
			
			else if (i % 11 == 0)
			{
				Console.WriteLine("Bong");
			}
			else if (i % 15 == 0)
			{
				Console.WriteLine("FizzBuzz");	
			}
			else if (i % 3 == 0)
			{
				Console.WriteLine("Fizz");
			}
			else if (i % 5 == 0)
			{
				Console.WriteLine("Buzz");
			}
		 
			else 
			{
				Console.WriteLine(i);
			}
		}
	}
}