using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// open csv file and show each line in the output window
using (var reader = new StreamReader(@"C:\src\reactors\GitHubCoPilotCSharp\Demo02\book2.csv"))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        Console.WriteLine(line);
    }
}
