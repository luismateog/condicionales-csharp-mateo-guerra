string jugada1 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
string jugada2 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

if (jugada1 == jugada2)
{
    Console.WriteLine("Empate");
}
else if ((jugada1 == "piedra" && jugada2 == "tijera")
    || (jugada1 == "tijera" && jugada2 == "papel")
    || (jugada1 == "papel" && jugada2 == "piedra"))
{
    Console.WriteLine("Gana el jugador 1");
}
else
{
    Console.WriteLine("Gana el jugador 2");
}
