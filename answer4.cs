using System;
					
public class Program
{
	static int Multiply(double num1,double num2,double num3,double num4)
    {  
		int multiplyRes;
		int intNum1,intNum2,intNum3,intNum4;
		
		intNum1=Convert.ToInt32(num1);
		intNum2=Convert.ToInt32(num2);
		intNum3=Convert.ToInt32(num3);
		intNum4=Convert.ToInt32(num4);
		
	
		multiplyRes=intNum1*intNum2*intNum3*intNum4;
		
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
