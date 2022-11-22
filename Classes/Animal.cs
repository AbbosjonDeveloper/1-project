namespace KESCHA.Classes
{
  // class
  class Animal 
  {
    public int Age { get; set; } // property
    public string Name { get; set; }
    public int AgeDifference { get; set; }

    public Animal(string name, int age) //constructor
    {
      Name = name;
      Age = age;
    }
    public Animal(
      string name, 
      int userAge, 
      int animalAge)
    {
      Name = name;
       CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
    }

    public void PrintAgeDifference()
    {
      Console.WriteLine($"Age difference between you and {Name} is : {AgeDifference}");
    }

    public void CompareAges(int userAge)
    {
      string message =
        userAge >= Age 
        ? "You are older or equal to Kescha"
        : "You are younger than Kescha";

      Console.WriteLine(message);
    }

    public void TellAboutFriend(string userName, int userAge)
    {
      Console.WriteLine("Let me tell you about my friends.");
      string[] friendsName = new string[3];
      friendsName[0] = userName;
      friendsName[1] = "Valya";
      friendsName[2] = "Kasee";

      int[] friendsAge = { userAge, 3, 4 };
      // for loop
      for (int i = 0 ; i < friendsName.Length; i++ )
      {
        System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} years old.");
      }
    }
    public void CalculateAgeDifferenceWithNoReturn(int userAge)
    {
      AgeDifference = userAge - Age;
    }

    public int CalculateAgeDifference(int userAge, int animalAge)
    {
      return userAge - animalAge;
    }

    public void Greet(string userName)
    {
      if (userName == "")
      {
        userName = "Unknown Person";
      }
      System.Console.WriteLine($"Hello {userName}");
    }
    private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
    {
      AgeDifference = userAge - animalAge;
    }
  }
}