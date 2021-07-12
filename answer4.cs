using System;
					
public class Program
{
	static int Multiply(double num1,double num2,double num3,double num4)
    {  
		int multiplyRes;
	
		multiplyRes=(int)num1*(int)num2*(int)num3*(int)num4;
		
		return multiplyRes;
    }
	
	public void Main()
	{
		int multiplyRes;
		multiplyRes=Multiply(1.2, 1.5, 3.4, 7.2); 
		Console.WriteLine("Welcome to my Multiplication Program ");
		Console.WriteLine("The Multiplay Result is "+ multiplyRes);
	}
}