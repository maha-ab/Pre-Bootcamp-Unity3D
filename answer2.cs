using System;
					
public class Program
{
	public static void Main()
	{
		int firstNumber=5;
		int secondNumber=10;
		int swap;
		
		swap=firstNumber;
		firstNumber=secondNumber;
		secondNumber=swap;
		
		Console.WriteLine("FirstNumber is:"+firstNumber);
		Console.WriteLine("SecondNumber is:"+secondNumber);
	}
}