using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';

        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'd')
        {
            Console.WriteLine();
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Multiplicación de matriz por escalar");
            Console.WriteLine(" b) Buscar número en la matriz");
            Console.WriteLine(" c) Vector de pares");
            Console.WriteLine(" d) Salir");
            Console.WriteLine();
            Console.WriteLine("Ingrese opción: ");
            opcion = Console.ReadLine()[0];
            Console.WriteLine();

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un escalar");
                    int escalar = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    operacionesMatrices.MultiplicaciónMatrizEscalar(escalar);
                    operacionesMatrices.ImprimirMatriz();
                    break;
                
                case 'b': 
                    Console.WriteLine("Ingrese el número a buscar en la matriz");
                    int buscar = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    operacionesMatrices.BuscarValor(buscar);
                    operacionesMatrices.ImprimirValores();
                    break;

                case 'c':
                    Console.WriteLine("Vector de números pares: ");
                    operacionesMatrices.VectorDePares();
                    operacionesMatrices.ImprimirVector();
                    break;

                case 'd':
                    break;
                
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}