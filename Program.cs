// See https://aka.ms/new-console-template for more information
using EmployeeApp;

Console.WriteLine("Welcome to your new job!");

// variables for storing user inputs
var input = "";
string name = "";
DateTime bday = DateTime.Now;
decimal salary = 0.0m;

// gather necessary inputs to create Employee object
Console.WriteLine("What is your name?");
input = Console.ReadLine();
name = input;

Console.WriteLine("What is your birthday? (Month-Day-Year)");
input = Console.ReadLine();
bday = DateTime.Parse(input);


Console.WriteLine("What is your salary?");
input = Console.ReadLine();
salary = decimal.Parse(input);

// create Employee instance and print out greeting
Employee employee = new Employee(name, bday, salary);
employee.PrintGreeting();
employee.PrintDaysUntilBday();
