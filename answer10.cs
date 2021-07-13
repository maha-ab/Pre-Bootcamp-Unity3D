using System;
					
public class Program
{
	
	public static void Main()
	{
		int[] x={1,9,6,7,5,9};
	 Array.Sort<int>(x, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
		foreach(int value in x)
        {
            Console.Write(value + " ");
        }
	}
