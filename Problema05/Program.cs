Console.Write("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine() ?? string.Empty);

int mayor = numero1 > numero2 ? numero1 : numero2;
Console.WriteLine($"El mayor es {mayor}");
