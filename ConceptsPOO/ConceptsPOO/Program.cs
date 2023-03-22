// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
try
{
	Date date1 = new Date(2023,12, 45);
    Console.WriteLine(date1);
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}

