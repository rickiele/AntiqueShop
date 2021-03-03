namespace AntiqueShop

{
    public class AntiqueItem
    {
        // Property defines part of a class that defines some 
        // container of state
        // access modifier = public or private - defaults to private
        // get allows value of property to be read
        // set allows value of property to be written to/ modifed
        public string Name { get; set; }

        // Always use decimal for money
        public decimal Price { get; set; }

    }
}