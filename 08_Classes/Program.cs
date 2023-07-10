using Classes;

// type name = new typeConstructor
Donut tasty = new Donut("Cream Filled");

// tasty.donutType = "Jelly Filled";

Console.WriteLine(tasty.donutType);

namespace Classes
{
    class Donut
    {
        // Field
        public string donutType;

        // Constructor
        // public Donut() {}
        public Donut(string type)
        {
            // Assinging the constructor parameter to the field
            // Whatever is passed into the constructor it passes its value to the field
            donutType = type;
        }
    }

}