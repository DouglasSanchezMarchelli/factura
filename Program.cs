//Programa que ingrese el precio de  10 productos, al final del total agregar 13% de IVA//
String nombreProducto;
int cantidadxProducto, cantidaDeProductos = 2;
double precio, total, totalAcumulado = 0;

for (int i = 1; i <= cantidaDeProductos; i++)
{
    Console.WriteLine("Nombre del Producto :" + i + ":");
    nombreProducto = Console.ReadLine();
    Console.WriteLine("Cantidad Producto " + i + ":");
    cantidadxProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Precio Producto " + i + ":");
    precio = double.Parse(Console.ReadLine());
    total = (cantidadxProducto * precio) * 1.13;
    totalAcumulado = totalAcumulado + total;
    Console.Clear();
}

Console.WriteLine("El total a pagar es : " + totalAcumulado);

