int opcion = int.Parse(Console.ReadLine() ?? string.Empty);

string mensaje = opcion switch
{
    1 => "Ha seleccionado: Consultar saldo",
    2 => "Ha seleccionado: Retirar",
    3 => "Ha seleccionado: Depositar",
    4 => "Ha seleccionado: Salir",
    _ => "Opción no válida"
};

Console.WriteLine(mensaje);