
//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StringFinder.Logic.Services;
using StringFinder.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var provider = new ServiceCollection()
                        .AddSingleton<IFindingService, FindingService>()
                        .BuildServiceProvider();

        var finderService = provider.GetRequiredService<IFindingService>();


        Console.WriteLine("Enter a sequence of integers separated by single whitespace:");

        string strInput = Console.ReadLine();

        if (string.IsNullOrEmpty(strInput))
        {
            Console.WriteLine("No valid input provided.");
            return;
        }

            String strResult = finderService.SubsequenceFinder(strInput);

        if (string.IsNullOrEmpty(strResult))
        {
            Console.WriteLine("No valid input provided.");
        }
        else
        {
            Console.WriteLine(String.Empty);

            Console.WriteLine($"Longest increasing subsequence: {strResult}");
        }
    }
}