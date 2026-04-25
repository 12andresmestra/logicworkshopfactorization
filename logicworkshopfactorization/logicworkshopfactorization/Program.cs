using System;
using LogicWorkshop;

try
{
    Console.Write("Ingrese el número a descomponer: ");
    int number = int.Parse(Console.ReadLine()!);

    var factorization = new Factorization(number);
    Console.WriteLine(factorization.GetResult());

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}