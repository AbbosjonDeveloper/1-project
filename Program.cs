System.Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter Kescha's age : ");
int keschasAge = Convert.ToInt32(Console.ReadLine());
int ageComparison = age - keschasAge;
System.Console.WriteLine($"Age difference between you and Kescha is : {ageComparison}");

string message =
  age >= keschasAge 
    ? "You are older or equal to Kescha"
    : "You are younger than Kescha";

System.Console.WriteLine(message);






