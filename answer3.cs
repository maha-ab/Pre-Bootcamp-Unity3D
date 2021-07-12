using System;
					
public class Program
{
	static int ConvertMyDataType(double num)
    {
      int convertNum;
		
		convertNum=(int) num;
		
		return convertNum;
    }
	
	public static void Main()
	{
		double num=10.4;
		int integerNum;
		integerNum=ConvertMyDataType(num);
		Console.WriteLine("the Integer Number is "+integerNum);
	}
}