System.Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter Kescha's age : ");
int keschasAge = Convert.ToInt32(Console.ReadLine());
int comparisonAge = age - keschasAge;
System.Console.WriteLine($"Age difference between you and Kescha is : {comparisonAge}");

if (age < keschasAge)
{
  System.Console.WriteLine("You are younger than  Kescha!");
}
else if(age < keschasAge) 
{
  System.Console.WriteLine("You are older than  Kescha!");
}
else 
{
  System.Console.WriteLine("You are equal!");
}






