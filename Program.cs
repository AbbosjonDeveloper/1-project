// do while
string password = "";
do 
{
  System.Console.WriteLine("Hi Enter password: " );
  password = Console.ReadLine();
}while(password != "aaa");

System.Console.WriteLine("Enter your name : ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);
System.Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter Kescha's age : ");
int keschasAge = Convert.ToInt32(Console.ReadLine());
int ageComparison = age - keschasAge;
System.Console.WriteLine($"Age difference between you and Kescha is : {ageComparison}");

// ternary operators
string message =
  age >= keschasAge 
    ? "You are older or equal to Kescha"
    : "You are younger than Kescha";

System.Console.WriteLine(message);

// Arrays
System.Console.WriteLine("Let me tell you about my friends.");
string[] friendsName = new string[3];
friendsName[0] = name;
friendsName[1] = "Valya";
friendsName[2] = "Kasee";

int[] friendsAge = { age, 3, 4 };

// foreach
 foreach(string friendName in friendsName) 
 {
   System.Console.WriteLine(friendName);
 }

// for loop
for (int i = 0 ; i < friendsName.Length; i++ )
{
  System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old.");
}


