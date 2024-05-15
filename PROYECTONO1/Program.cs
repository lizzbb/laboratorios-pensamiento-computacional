using System.Security.Cryptography.X509Certificates;
using PROYECTONO1;
class Program
{
    public static void Main(string[] args)
    {
        Cliente objCliente = new Cliente(); 
        Licuado objLicuado = new Licuado();
        Leche objLeche = new Leche();
        Azucar objAzucar = new Azucar();

        string nombre, op1, NIT, metodoPago, cambio, TIN, metodo;
        double PrecioTotal = 20;
        double precioInicial = 20;
        double agrandado, PrecioAzucar, precioLeche;
        Console.WriteLine("Bienvenido, un gusto atenderle, por favor ingrese su nombre completo: ");
        nombre = Console.ReadLine() + "";
        Console.WriteLine();
        Console.WriteLine("Su pedido actual es: Licuado de fresas con leche \nElija una opción: \n1. Confirmar pedido \n2. Modificar pedido \n3. Cancelar pedido");
        op1 = Console.ReadLine() + "";
        Console.WriteLine(); 

        switch(op1) // Menu principal
        {
            case "1": // Información cliente, pedido inicial
                Console.WriteLine("Elija tipo de consumidor");
                Console.WriteLine("1. Consumidor Final \n2. NIT");
                NIT = Console.ReadLine() + "";
                TIN = objLicuado.ConfirmacionNIT(NIT);
                Console.WriteLine("Elija método de pago");
                Console.WriteLine("1. Tarjeta \n2. Efectivo");
                metodoPago = Console.ReadLine() + "";
                metodo = objLicuado.ConfirmacionPAGO(metodoPago);
                PrecioTotal = precioInicial;
                objCliente.MostrarFactura(nombre, TIN, metodo, PrecioTotal);
            break;

            case "2": // Menu de modificaciones
            do{
                Console.WriteLine("Por favor, elija una opción:");
                Console.WriteLine("1. Cambiar azúcar \n2. Cambiar leche \n3. Agrandar tamaño del licuado \n4. Confirmar pedido");    
                cambio = Console.ReadLine() + "";
                    switch (cambio)
                    {
                        case "1":
                            PrecioAzucar = objAzucar.MENUazucar();
                            PrecioTotal += PrecioAzucar;
                        break;

                        case "2":
                            precioLeche = objLeche.MENUleche();
                            PrecioTotal += precioLeche;
                        break;

                        case "3":
                            agrandado = PrecioTotal * 0.07;
                            Console.WriteLine(agrandado); //se espera 1.869
                            PrecioTotal += agrandado;
                        break;

                        case "4":
                            op1 = cambio;
                        break;

                        default:
                            Console.WriteLine("Opción no válida.");
                        break;
                    }
            }while(cambio != "4"); // ejecutar menú hasta finalizar pedido
            break;

            case "3": // Cancelar pedido
                Console.WriteLine("Pedido cancelado"); 
            break;

            default:
                Console.WriteLine("Opción no válida.");
            break;
        }
        if(op1 == "4") // Información cliente, pedido modificado
        {
            Console.WriteLine();
            Console.WriteLine("Elija tipo de consumidor:");
            Console.WriteLine("1. Consumidor Final \n2. NIT");
            NIT = Console.ReadLine() + "";
            TIN = objLicuado.ConfirmacionNIT(NIT);
            Console.WriteLine();
            Console.WriteLine("Elija método de pago:");
            Console.WriteLine("1. Tarjeta \n2. Efectivo");
            metodoPago = Console.ReadLine() + "";
            metodo = objLicuado.ConfirmacionPAGO(metodoPago);
            objCliente.MostrarFactura(nombre, TIN, metodo, PrecioTotal);
        }
    }
}
