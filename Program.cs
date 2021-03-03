using System;
using System.Collections.Generic;

// namespace matches the projects name
namespace AntiqueShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Antique Shoppe");

            // Instanciate - Instance of something
            // Make that object and put it in a variable.
            AntiqueItem chair = new AntiqueItem()
            {
                // Object initialization syntax
                // m after number to specify it's a decimal type
                Name = "An old chair",
                Price = 45.50m,
            };

            AntiqueItem vase = new AntiqueItem()
            {
                Name = "A priceless vase",
                Price = 1.00m
            };

            AntiqueItem painting = new AntiqueItem();
            painting.Name = "Washington on a Cow";
            painting.Price = 100.99m;

            // Need to pass values to a contructor
            Customer alice = new Customer("Alice", "Jones", 10m, 100m);
            Console.WriteLine(alice.FullName);

            // An error on _minPrice because that field is private
            // decimal x = alice._minPrice;

            // Methods and passing in the argument
            alice.ExamineItem(chair);
            alice.ExamineItem(vase);
            alice.ExamineItem(painting);

        }
    }
}



// Language of C# gives you ability to have custom types

// "new" keyword for List and DateTime
// List is actually a class
// If you dig into List in the source code, you will see it's a class.
// Parenthesis afterwards is a clue that we're making a new object out of that class.
// New List object is created and is assigned to the variable strs

// List<string> strs = new List<string>();
// int num = 42;
// DateTime dt = new DateTime();
// bool flag = true;

// Objects only exist when we're running the program

// How do I know when to make a class?
// Where do you want to draw the line on where your boundaries are for app?
// Think about the entities of your app. Similar thought process to ERDS
// Where you thought of tables and keys
// Look for the nouns in your app -Person Place Thing