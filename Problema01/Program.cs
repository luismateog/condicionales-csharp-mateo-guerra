using System;

Console.Write("Por favor, ingrese su edad: ");

if (int.TryParse(Console.ReadLine(), out int edad))
{
    string mensaje = edad >= 16 ? "Puede votar" : "Aún no puede votar";
    Console.WriteLine(mensaje);
}
else
{
    Console.WriteLine("Error: Debe ingresar un número entero válido.");
}
