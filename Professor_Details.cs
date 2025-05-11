 public abstract class Professor{
    public string Name;
    public int ID;
    public Professor(string name, int id)
    {
        Name = name;
        ID = id;
    }
    public abstract double CalculateSalary();

    public void Show()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
    }
}

 public class Senior_prof : Professor
{
    public double BaseSalary;
    public Senior_prof(string name, int id, double baseSalary)
        : base(name, id)
    {
        BaseSalary = baseSalary;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + 10500; // Bonus
    }
}

public class Assistent_Prof : Professor
{
    public double BaseSalary;

    public Assistent_Prof(string name, int id, double baseSalary)
        : base(name, id)
    {
        BaseSalary = baseSalary;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + 7000; // Project allowance
    }
}

public class Lab_attender : Professor
{
    public double BaseSalary;
    public Lab_attender(string name, int id, double baseSalary)
    :base(name,id)
    {
        BaseSalary=baseSalary;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + 3000;
    }
}
public class Details_Program
{
    static void Main(string[] args)
    {
        List<Professor> teacher = new List<Professor>();

        Console.Write("Enter the number of Teacher/professor's :\n");
        int c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            Console.WriteLine($"\nEnter details for Faculty #{i + 1}:");
            Console.Write("Enter type (1.Senior_prof/2.Assistnet_pro/3.Lab_attender/4.exit): ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Enter base salary: ");
                    double mSalary = double.Parse(Console.ReadLine());
                    teacher.Add(new Senior_prof(name, id, mSalary));
                    break;
                case 2:
                    Console.Write("Enter base salary: ");
                    double dSalary = double.Parse(Console.ReadLine());
                    teacher.Add(new Assistent_Prof(name, id, dSalary));
                    break;
                case 3:
                    Console.Write("Enter Base salary: ");
                    double lsalary = double.Parse(Console.ReadLine());
                    teacher.Add(new Lab_attender(name, id, lsalary));
                    break;
                default:
                    Console.WriteLine("Invalid type. Skipping this entry.");
                    break;
            }
        }

        Console.WriteLine("\nEmployee Details and Salaries:");
        foreach (var tea in teacher)
        {
            tea.Show();
            Console.WriteLine($"Calculated Salary: {tea.CalculateSalary()}");
            Console.WriteLine("-----------------------------");
        }
        Console.WriteLine("********THANK YOU********");
        Console.WriteLine("((Try Again:)-:)-");
        
    }
}