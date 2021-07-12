using System;
using System.Collections.Generic;

// Our new data container which defines what is an employee in our program, a class with the name Employee
// This class will act as a container or holder to all our employee relevant information, 
// it will contain various data structures and variables inside of it.

public class Employee
	{
		string name; // variable to hold name
		Dictionary<string, string> phoneNumbers; // dictionary to hold all phone numbers
		Dictionary<string, string> addresses; // dictionary to hold all addresses
		string SSN; // variable to hold SSN
		
		public Employee()
		{
			this.phoneNumbers = new Dictionary<string, string>(); // initialize our employee phone numbers dictionary (set it up with no values)
			this.addresses = new Dictionary<string, string>(); // initialize our employee addresses dictionary (set it up with no values)
		}
		
		// Method which takes two parameters, the description we want to set for the phone number, and a phone number
		// Example would be AddPhone("1st Phone Number", "+1 54615647")
		public void AddPhoneNumber(string description, string phoneNumber)
		{
			this.phoneNumbers.Add(description, phoneNumber);
		}
		
		// Method which takes two parameters, the description we want to set for the address, and an address
		// Example would be AddAddress("Address 1", "US, Seattle")
		public void AddAddress(string description, string address)
		{
			this.addresses.Add(description, address);
		}
		
		// Method which takes one parameter representing our employee name.
		public void SetName(string name)
		{
			this.name = name;
		}
	
	    public string getName()
		{
			return name;
		}
		
		// Method which takes one parameter representing our employee SSN.
		public void SetSSN(string SSN)
		{
			this.SSN = SSN;
		}
	
		public void PrintAllAddresses()
		{
			// This is called a loop of type foreach, you can ignore it for now
			// However its a way in C# to iterate (go through item by item) of the data stored in a dictionary
			foreach(KeyValuePair<string, string> entry in this.addresses)
			{
    			// Print out to the key and value of each stored item in our addresses dictionary
				Console.WriteLine(entry.Key + ": " + entry.Value);
			}
		}
	public void PrintAllPhoneNumbers()
		{
			
			foreach(KeyValuePair<string, string> entry in this.phoneNumbers)
			{
    			// Print out to the key and value of each stored item in our addresses dictionary
				Console.WriteLine(entry.Key + entry.Value);
			}
		}
	}
	

public class Program
{
	public void Main()
	{
		Dictionary<string, Employee> allEmployees= new Dictionary<string, Employee>(); 
		
		Console.WriteLine("We are going to create our first employee type of variable, since its a variable of type class its type is an object");
		
		Employee employee1 = new Employee(); // This line defines a new employee in our program!
		employee1.SetName("Micheal"); // Set the employee name to Micheal
		employee1.SetSSN("23132132152"); // Set the employee SSN
		employee1.AddAddress("Address 1", "Seattle, US"); // Add the 1st address to our employee
		employee1.AddAddress("Address 2", "London, UK"); // Add the second address to our employee
		employee1.AddPhoneNumber("Phone 1:", "+156475646"); // Add 1st phone number to our employee
		employee1.AddPhoneNumber("Phone 2:", "+5 56465415"); // Add 2nd phone number to our employee
		
		
		Console.WriteLine("Below is all the addresses stored in our employee  "+ employee1.getName());
		
		employee1.PrintAllAddresses();
		employee1.PrintAllPhoneNumbers();// Calling method PrintAllAddresses() which prints all addressed of an employee
		Console.WriteLine("\n"); // Line break
		
		Console.WriteLine("Creating new Employee object in our program!");
		Employee employee2 = new Employee(); // This line defines a new employee in our program!
		employee2.SetName("Jessica"); // Set the employee name to Jessica
		employee2.SetSSN("73132132152"); // Set the employee SSN
		employee2.AddAddress("Address 1", "California, US"); // Add the 1st address to our employee
		employee2.AddAddress("Address 2", "Paris, France"); // Add the second address to our employee
		employee2.AddPhoneNumber("Phone 1:", "+186475646"); // Add 1st phone number to our employee
		employee2.AddPhoneNumber("Phone 2:", "+5 86465415"); // Add 2nd phone number to our employee
		
				
		Console.WriteLine("Below is all the addresses stored in our employee  "+ employee2.getName());
		employee2.PrintAllAddresses();
		employee2.PrintAllPhoneNumbers();
		
		allEmployees.Add("employee1",employee1);
		allEmployees.Add("employee2",employee2);
		
		Console.WriteLine("\n");
		// I print the name to make sure that i store the value correctly
		foreach(KeyValuePair<string, Employee> entry in allEmployees) 
			{
    			// Print out to the name of each employee dictionary
				Console.WriteLine(entry.Key + ": " + entry.Value.getName());
			}
		
	}
}