using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace PROYECTONO1;

public class Licuado
{
    string TIN = "", metodo = "";
    public string ConfirmacionNIT(string NIT) // Información tipo de consumidor
    {
        if(NIT == "1")
        {
            TIN = "CF";
        }
        else if(NIT == "2")
        {
            Console.WriteLine("Ingrese su NIT");
            TIN = Console.ReadLine() + "";
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
        return TIN;
    }
    public string ConfirmacionPAGO(string metodoPago) // Información tipo de pago
    {
        if(metodoPago == "1")
        {
            metodo = "Tarjeta";
        }
        else if(metodoPago == "2")
        {
            Console.WriteLine("Ingrese su NIT");
            metodo = "efectivo"; 
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
        return metodo;
    }
}

