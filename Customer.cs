using System;

namespace AntiqueShop

{
    public class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }
        public string FullName
        {
            // Computed property - Compute a value when accessed
            // get allows you access
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // Fields - Another way to store state inside a class
        // Almost always private
        // You can tell it's a field because it doesn't have a get or a set.
        // Naming convention is to begin fields with an '_'
        // A field because of the absence of a get or a set
        private decimal _minPrice;
        private decimal _maxPrice;

        // Constructor - 
        // A special method in a class that executes when the class
        // is instantiated / Basically runs when a 'new' object is created.
        // How to spot a constructor? It has the same name as the class. - Line 4
        // Does not have a return type.
        // Only have a constructor if you need to do some work when an object is created.
        public Customer(string firstName, string lastName,
            decimal minPrice, decimal maxPrice)
        {
            // Save them away in properties
            // Difference in cases - Parameters are lowercase / camelcase
            // Properties and methods are uppercase 
            // only properties can be set inside the constructor
            FirstName = firstName;
            LastName = lastName;
            _minPrice = minPrice;
            _maxPrice = maxPrice;
        }

        // Method
        // A function defined in a class
        // Is some kind of "action" (aka "operation")
        // Provided behavior for an object
        // Naming convention = uppercase Pascalcase;
        // Remember parameters are lowercase / camelCase
        public void ExamineItem(AntiqueItem item)
        {
            if (item.Price >= _minPrice && item.Price < _maxPrice)
            {
                // CTRL + . to access System or click the light bulb on left side if there
                Console.WriteLine($"Would add {item.Name} to purchase list");
            }
            else if (item.Price >= _maxPrice)
            {
                Console.WriteLine($"Would add {item.Name} to wish list");
            }
        }
    }
}