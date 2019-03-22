using System;
using System.Text.RegularExpressions;
using OpenClosed;

class Program
{
    static void Main(string[] args)
    {
        var starshipLogic = new StarshipLogic();
        Regex regex = new Regex("[^a-zA-Z0-9]");

        Console.WriteLine("Please enter starship registry code:");

        string input = regex.Replace(Console.ReadLine().ToLower(),"");

        string output = starshipLogic.GetStarshipName(input);

        Console.WriteLine(output);

        Console.ReadKey(); // used as a convenience to avoid the console immediately closing before you see a result
    }
}