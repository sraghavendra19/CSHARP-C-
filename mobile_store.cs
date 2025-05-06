using System;
using System.Collections.Generic;

class Mobile
{
    public int ID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
}

class MobileStore
{
    static List<Mobile> mobiles = new List<Mobile>
    {
        new Mobile { ID = 1, Brand = "Apple", Model = "iPhone 13", Price = 999 },
        new Mobile { ID = 2, Brand = "Samsung", Model = "Galaxy S21", Price = 799 },
        new Mobile { ID = 3, Brand = "OnePlus", Model = "9 Pro", Price = 699 }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Mobile Store Management ---");
            Console.WriteLine("1. View Mobiles\n2. Search Mobile\n3. Purchase Mobile\n4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": ViewMobiles(); break;
                case "2": SearchMobile(); break;
                case "3": PurchaseMobile(); break;
                case "4": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void ViewMobiles()
    {
        if (mobiles.Count == 0)
        {
            Console.WriteLine("No mobiles available.");
            return;
        }

        Console.WriteLine("\nAvailable Mobiles:");
        DisplayMobiles(mobiles);
    }

    static void SearchMobile()
    {
        Console.Write("\nEnter brand or model to search: ");
        string keyword = Console.ReadLine()?.ToLower();

        var results = mobiles.FindAll(m =>
            m.Brand.ToLower().Contains(keyword) ||
            m.Model.ToLower().Contains(keyword));

        if (results.Count == 0)
            Console.WriteLine("No matching mobiles found.");
        else
        {
            Console.WriteLine("Search Results:");
            DisplayMobiles(results);
        }
    }

    static void PurchaseMobile()
    {
        Console.Write("\nEnter Mobile ID to purchase: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var mobile = mobiles.Find(m => m.ID == id);
            if (mobile != null)
            {
                Console.WriteLine($"Purchased {mobile.Brand} {mobile.Model} for ${mobile.Price}");
                mobiles.Remove(mobile);
            }
            else
                Console.WriteLine("Mobile not found.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void DisplayMobiles(List<Mobile> list)
    {
        foreach (var m in list)
        {
            Console.WriteLine($"ID: {m.ID}, Brand: {m.Brand}, Model: {m.Model}, Price: ${m.Price}");
        }
    }
}
