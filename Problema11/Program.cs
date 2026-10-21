string entrada = Console.ReadLine() ?? string.Empty;
if (Enum.TryParse(entrada, ignoreCase: true, out EstadoSemaforo estado))
{
    string instruccion = estado switch
    {
        EstadoSemaforo.Rojo => "Deténgase",
        EstadoSemaforo.Amarillo => "Precaución, prepárese para detenerse",
        EstadoSemaforo.Verde => "Avance",
        _ => "Estado no reconocido"
    };

    Console.WriteLine(instruccion);
}
else
{
    Console.WriteLine("Estado no reconocido");
}

enum EstadoSemaforo
{
    Rojo,
    Amarillo,
    Verde
}
