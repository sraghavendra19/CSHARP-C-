using System;
class paliendrom
{
    public static void Main(string[] args)
    {
        Console.WriteLine("IS Paliendrom");
        int n;
        int temp;
        Console.WriteLine("Enter the number");
        n=Convert.ToInt32(Console.ReadLine());
        temp=n;
        int sum=0;
        while(n>0)
        {
            int digit = n%10;
            sum =sum*10 + digit;
            n=n/10;
        }
        if(temp==sum)
        {
            Console.WriteLine("YES, it is Paliendrom");

        }
        else
        {
            Console.WriteLine("NO,It is not a Paliendrom");
        }
    }
}