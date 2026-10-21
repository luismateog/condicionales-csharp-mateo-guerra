using System;
Console.WriteLine("Cual es tu edad(numeros enteros): ");
byte edad = byte.Parse(Console.ReadLine());

string mensagge = (edad >= 16) ? "Puede votar" : "Aun no puede votar";

Console.WriteLine(mensagge);


