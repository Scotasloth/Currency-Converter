using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{

    static async Task main(string[] args)
    {

        Console.WriteLine("How much to convert?");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("What is your currency?");
        string homeCurr = Console.ReadLine().ToUpper();

        Console.WriteLine("What do you want to convert to?");
        string newCurr = Console.ReadLine().ToUpper()
    }
}