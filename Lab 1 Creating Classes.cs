//January-23-2024 Ammar Tayyab
using System;
using System.Collections.Generic;
class Person
{
    int personID;
    string firstName;
    string lastName;
    string favoriteColour;
    int age;
    bool isWorking;
    public Person(int id, string fName, string lName, string favColour, int personAge, bool working)
    {
        personID = id;
        firstName = fName;
        lastName = lName;
        favoriteColour = favColour;
        age = personAge;
        isWorking = working;
    }
    public void DisplayPersonInfo()
    {
        string Name = (firstName +" " + lastName);
        Console.WriteLine($"{personID}:{Name}'s favourite colour is {favoriteColour}");
    }
    public void ChangeFavoriteColour (string newfavColour)
    {
        favoriteColour = newfavColour;
    }
    public void ToString()
    {
        string idInfo = $"PersonID:{personID}";
        string fnameInfo = $"FirstName:{firstName}";
        string lnameInfo = $"LastName:{lastName}";
        string favcolorInfo = $"FavoriteColour:{favoriteColour}";
        string ageInfo = $"Age: {age}";
        string workingInfo = $"isWorking: {isWorking}";

        List<string> infoList = new List<string> { idInfo, fnameInfo, lnameInfo, favcolorInfo, ageInfo, workingInfo };

        Console.WriteLine(string.Join("\n", infoList));
    }
}

class Program
{ 
    static void Main()
    {
        Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
        person2.DisplayPersonInfo();;
        person3.ToString();
        person1.ChangeFavoriteColour("White");

    }
}