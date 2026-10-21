Console.Write("Ingrese la cantidad de artículos en el carrito: ");
int cantidad = int.Parse(Console.ReadLine() ?? string.Empty);
string mensaje = $"Tienes {cantidad} artículo{(cantidad == 1 ? string.Empty : "s")} en el carrito";
Console.WriteLine(mensaje);
