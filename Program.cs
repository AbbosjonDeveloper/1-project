using KESCHA.Classes;

namespace KESCHA
{
  class Program
  {
    static void Main()
    {
      Animal kescha = new Animal(name : "Kescha",  age:3);
  
      System.Console.WriteLine("Enter your name : ");
      string userName = Console.ReadLine();
      kescha.Greet(userName);
      System.Console.Write("Enter your age : ");
      int userAge = Convert.ToInt32(Console.ReadLine());
      
      kescha.CalculateAgeDifferenceWithNoReturn(userAge: userAge);
      kescha.PrintAgeDifference();
      kescha.CompareAges(userAge: userAge);
      kescha.TellAboutFriend(userName , userAge: userAge);
    }
  }
}




