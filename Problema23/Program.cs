Console.Write("Ingrese el nombre de usuario: ");
string usuario = Console.ReadLine() ?? string.Empty;
Console.Write("Ingrese la contraseña: ");
string contrasena = Console.ReadLine() ?? string.Empty;

if (usuario != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else if (contrasena != "Sena2026")
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Bienvenido");
}
