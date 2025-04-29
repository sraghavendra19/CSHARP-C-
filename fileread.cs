using System; 
using System.IO; 
  
class Program { 
    static void Main(string[] args) 
    { 
        
        string file = @"C:\Users\HP\Desktop\read.txt"; 
  
        Console.WriteLine("Reading File "); 
  
        if (File.Exists(file)) { 
            string str = File.ReadAllText(file); 
            Console.WriteLine(str); 
        } 
        Console.WriteLine(); 
    }
}