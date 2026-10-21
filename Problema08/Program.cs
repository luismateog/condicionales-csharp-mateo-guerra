Console.Write("Ingrese una letra: ");
string entrada = Console.ReadLine() ?? string.Empty;
char caracter = entrada.Length > 0 ? char.ToLowerInvariant(entrada[0]) : '\0';

if (!char.IsLetter(caracter))
{
    Console.WriteLine("No es una letra");
}
else if (caracter is 'a' or 'e' or 'i' or 'o' or 'u')
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}
