using System;


    public abstract class Animal
    {
        public string Name ;

        
        public Animal(string name)
        {
            Name = name;
        }

        
        public abstract void MakeSound();

        
        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {Name}.");
        }
    }

    
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof Woof!");
        }
    }

    
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows: Meow Meow!");
        }
    }

    
    public class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} moos: Moo Moo!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Animal dog = new Dog("Sanju");
            Animal cat = new Cat("Billi");
            Animal cow = new Cow("OX");

            
            dog.DisplayInfo();
            dog.MakeSound();
            Console.WriteLine();

            cat.DisplayInfo();
            cat.MakeSound();
            Console.WriteLine();

            cow.DisplayInfo();
            cow.MakeSound();
            Console.WriteLine();
        }
    }

