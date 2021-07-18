using System;
using System.Collections.Generic;  
using System.Security.Cryptography;
using System.Text;


class MyClass
{
	
    static Random random = new Random();

	public string randomnum() 
	{
		int num;
		string ranNum;
		num=random.Next(100,1000);
		ranNum=num.ToString();
		return ranNum;
	}
	public string isEven(string num)
	{
		int idNum;
		idNum=Convert.ToInt32(num);
		if(idNum%2==0)
			return "even";
		else 
			return "odd";
		
	}
	public string RandomString(int length)
{
    const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    StringBuilder password = new StringBuilder();
    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
    {
        byte[] uintBuffer = new byte[sizeof(uint)];

        while (length-- > 0)
        {
            rng.GetBytes(uintBuffer);
            uint num = BitConverter.ToUInt32(uintBuffer, 0);
            password.Append(valid[(int)(num % (uint)valid.Length)]);
        }
    }

    return password.ToString();
}

}

	public class Program
{
	public static void Main()
	{
	   MyClass myClass= new MyClass();
		
		
	string idOne;
    string idTwo;
	string passwordOne;
    string passwordTwo;
		
	idOne=myClass.randomnum();
	passwordOne=myClass.RandomString(10);
    
		Dictionary<string, string> My_dict1 =  new Dictionary<string, string>(); 
		 My_dict1.Add("ID"+idOne,idOne);
		 My_dict1.Add("Username"+idOne,"Michael");
		 My_dict1.Add("Password"+idOne,passwordOne);
		 My_dict1.Add("Category"+idOne, myClass.isEven(idOne));
		
   idTwo=myClass.randomnum();
	passwordTwo=myClass.RandomString(10);
		
         Dictionary<string, string> My_dict2 =  new Dictionary<string, string>(); 
		 My_dict2.Add("ID"+idTwo,idTwo);
		 My_dict2.Add("Username"+idTwo,"Mohammed");
		 My_dict2.Add("Password"+idTwo,passwordTwo);
		 My_dict2.Add("Category"+idTwo, myClass.isEven(idTwo));
		
        Console.WriteLine("Preparing new record to be stored in our Dictionary!\nThe randomly generated number for that record is: " + idOne);
        Console.WriteLine("Successfully stored the record with ID: "+ idOne );
		Console.WriteLine("Preparing new record to be stored in our Dictionary!\nThe randomly generated number for that record is: " + idTwo);
        Console.WriteLine("Successfully stored the record with ID: "+ idTwo );

foreach(KeyValuePair<string, string> entry in My_dict1)
        {
           Console.WriteLine(entry.Key + " : " + entry.Value);
        }
foreach(KeyValuePair<string, string> entry in My_dict2)
        {
           Console.WriteLine(entry.Key + " : " + entry.Value);
        }
	
	}
}
