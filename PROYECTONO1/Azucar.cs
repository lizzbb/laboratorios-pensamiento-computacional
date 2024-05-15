using System.ComponentModel;
using System.Numerics;

namespace PROYECTONO1;

public class Azucar
{
    public int cantidadCucharadas;
    public double PorCucharada, totalAzucar;
    public string cambioAZUCAR = "";
    public double MENUazucar()
    {
        Console.WriteLine("Por favor, elija una opción:");
        Console.WriteLine("1. Azúcar blanca \n2. Azúcar Morena  \n3. Suplemeto ");
        cambioAZUCAR = Console.ReadLine() + "";

        switch (cambioAZUCAR) // Menú de modificación de azúcar
        {
            case "1":
                Console.WriteLine("¿Cuántas cucharadas desea agregar?");
                cantidadCucharadas = int.Parse(Console.ReadLine() + "");
                PorCucharada = 0.60; // azúcar blanca
            break;

            case "2":
                Console.WriteLine("¿Cuántas cucharadas desea agregar?");
                cantidadCucharadas = int.Parse(Console.ReadLine() + "");
                PorCucharada = 0.40; // azúcar morena
            break;

            case "3":
                Console.WriteLine("¿Cuántas cucharadas desea agregar?");
                cantidadCucharadas = int.Parse(Console.ReadLine() + "");
                PorCucharada = 0.90; // suplemento
                break;

            default:
                Console.WriteLine("Opción no válida.");
            break;
        }
        Console.WriteLine();
        
        totalAzucar = PorCucharada * cantidadCucharadas; // calculo

        if(cantidadCucharadas > 3)
        {
            Console.WriteLine("Solo puede agregar como máximo 3 cucharaditas de azucar");
            MENUazucar();
        }
        return totalAzucar;
    }
}

