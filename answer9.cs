using System;
					
public class Program
{
	public static void Main()
	{
		string numType;
		for(int i=10;i>=1;i--)
		{
			if(i%2==0)	
				numType="even";
			else 
				numType="odd";
		
		Console.WriteLine("Counting Down: "+i+" and the number is "+ numType);
		}
	}
}
