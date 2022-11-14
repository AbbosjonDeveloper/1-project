System.Console.Write("Enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter Kescha's age : ");
int keschasAge = Convert.ToInt32(Console.ReadLine());
int comparisonAge = age - keschasAge;
System.Console.WriteLine($"Age difference between you and Kescha is : {comparisonAge}");

System.Console.WriteLine($"You are older than  Kescha : {age > keschasAge}");
System.Console.WriteLine($"Kescha is  older than  you : {age < keschasAge}");
System.Console.WriteLine($"You are older or equal to Kescha : {age >= keschasAge}");
System.Console.WriteLine($"Kescha is  older or equal to you : {age <= keschasAge}");
System.Console.WriteLine($"You and Kescha are equal : {age == keschasAge}");
System.Console.WriteLine($"You and Kescha are not equal : {age != keschasAge}");





