namespace PROYECTONO1;
public class Cliente
{

    public void MostrarFactura (string nombre, string NIT, string metodoPago, double PrecioTotal)
    {
        Console.WriteLine();
        Console.WriteLine("Factura");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("NIT: " + NIT);
        Console.WriteLine("Método de pago: " + metodoPago);
        Console.WriteLine("Precio del pedido: " + PrecioTotal);
    }
}
