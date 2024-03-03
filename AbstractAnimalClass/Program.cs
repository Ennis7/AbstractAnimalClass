namespace AbstractAnimalClass;
abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}
class Program
{
    class Dog : Animal
    {
        public string Color { get; set; }
        public string Breed { get; set; }

        public Dog()
        {
            Name = string.Empty;
            Color = string.Empty;
            Breed = string.Empty;
        }
        public  Dog(string name, string color, string breed)
        {
            Name = name;
            Color = color;
            Breed = breed;
        }
        
        public override string Name { get; set; }

        //override abstract property
        public override string Describe()
        {
            return "\nMy name is " + Name + "\nMy breed is " + Breed + "\nI am the color " + Color;
        }
    }
    static void Main(string[] args)
    {
        //Object default constructor
        Dog gizmo = new Dog();
        gizmo.Name = "Gizmo.";
        gizmo.Breed = "Shiz Tzu.";
        gizmo.Color = "grey.";
        Console.Write(gizmo.whatAmI());
        Console.WriteLine(gizmo.Describe());
        Console.WriteLine();
        Console.ReadKey();

        //Object parameterized constructor
        Dog mo = new Dog("Mo.", "black.", "German Shepard.");
        Console.Write(mo.whatAmI());
        Console.WriteLine(mo.Describe());
        Console.ReadKey();
    }
}

