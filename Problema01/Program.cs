int edad = int.Parse(Console.ReadLine() ?? string.Empty);
string mensaje = edad >= 16 ? "Puede votar" : "Aún no puede votar";
Console.WriteLine(mensaje);
