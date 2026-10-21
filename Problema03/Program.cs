using System;
bool iniciar = true;
while(iniciar)
{
    
Console.WriteLine($"----------Menu-----------\n1 = consultar saldo.\n2 = Retirar.\n3 = Depositar.\n4 = Salir");
    byte opcion = byte.Parse(Console.ReadLine());
    switch(opcion)
    {
        case 1:
        Console.WriteLine("Has elegido consultar saldo\n");
        break;

        case 2:
        Console.WriteLine("Has elegido retirar saldo\n");
        break;

        case 3:
        Console.WriteLine("Has elegido depositar saldo\n");
        break;

        case 4:
        Console.WriteLine("Has elegido salir\n");
        break;
    }
}