using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    protected string model;

    public Vehicle(string model)
    {
        this.model = model;
    }

    public abstract void DisplayInfo();
}

public class Car : Vehicle
{
    public Car(string model) : base(model) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Model: {model}");
        Console.WriteLine("Type: Car -4 WHEEL VEHICLE.");
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string model) : base(model) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Model: {model}");
        Console.WriteLine("Type: Motorcycle 2 Wheel VECHICLE .");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Console.Write("Enter the number of vehicles: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nEnter details for vehicle #{i + 1}:");
            Console.Write("Enter type (Car / Motorcycle): ");
            string type = Console.ReadLine();

            Console.Write("Enter model name: ");
            string modelName = Console.ReadLine();

            switch (type.ToLower())
            {
                case "car":
                    vehicles.Add(new Car(modelName));
                    break;
                case "motorcycle":
                    vehicles.Add(new Motorcycle(modelName));
                    break;
                default:
                    Console.WriteLine("Invalid type. Skipping this entry.");
                    break;
            }
        }

        Console.WriteLine("\nVehicle Details:\n");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine("----------------------------");
        }
    }
}
