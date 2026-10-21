int numero = int.Parse(Console.ReadLine() ?? string.Empty);

if (numero > 0)
{
    Console.WriteLine("Positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Cero");
}
