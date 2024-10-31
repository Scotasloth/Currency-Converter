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


    try
    {
        decimal exchangeRate = await GetExchangeRate(homeCurr, newCurr);
        decimal newVal = amount * exchangeRate;

        console.WriteLine("{amount} {homeCurr} is worth {newVal} {newCurr}");
    }
    catch (Exeption e)
    {
        console.WriteLine("Error " + e.Message)
    }
}

public static async Task<decimal> GetExchangeRate(string src, string targ)
{
    using(var client = new HttpClient())
    {
        string apiKey = "";
        string url =  "";

        var reply = await client.GetStringAsync(url);
        var currData = JObject.Parse(response);

        if (data ["rates"][targ] == null)
            throw new Exception("Invalid currency");

        return (decimal)data["rates"][targ];
    } 
}