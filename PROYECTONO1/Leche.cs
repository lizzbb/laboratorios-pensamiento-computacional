using System.Numerics;

namespace PROYECTONO1;

public class Leche
{
    public double efecto;
    string cambioLECHE = "";
    public double MENUleche()
    {
        Console.WriteLine();
        Console.WriteLine("Por favor, elija una opción:");
        Console.WriteLine("1. Sin leche (agua) \n2. Deslactosada \n3. Entera \n4. Soya ");
        cambioLECHE = Console.ReadLine() + "";
        switch (cambioLECHE) // Menu de modificación de tipo de leche
        {
            case "1":
                efecto = -3; // Agua, sin leche
            break;

            case "2":
                efecto = 0; // deslactosada
            break;

            case "3":
                efecto = 0; // entera
            break;

            case "4":
                efecto = 2; // de soya
            break;

            default:
                Console.WriteLine("Opción no válida.");
            break;
        }
        return efecto; // retorna al programa el cambio de leche
    }
}

