using System.Timers;

namespace L11___Lizbeth_Herrera___1246024;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones(); 
        string opcion1 = Console.ReadLine();

        Console.WriteLine("Ejercicio No. 1");
        Console.WriteLine();
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("a. Calcular el área de un triángulo");
        Console.WriteLine("b. Calcular el área de un cuadrado");
        Console.WriteLine("c. Calcular el área de un rectángulo");
        Console.WriteLine("d. Calcular el área de un círculo");
        Console.WriteLine();

        switch(opcion1)
        {
            case "a":

                Console.WriteLine("Ingrese el valor de la base: ");
                double bT = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la altura: ");
                double alturaT = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("El área del triángulo es: " + operaciones.ObtenerAreaTriangulo(bT, alturaT));
                break;
            
            case "b":

                Console.WriteLine("Ingrese el valor del lado: ");
                double lado = int.Parse(Console.ReadLine());
                

                Console.WriteLine();
                Console.WriteLine("El área del cuadrado es: " + operaciones.ObtenerAreaCuadrado(lado));
                break;

            case "c":

                Console.WriteLine("Ingrese el valor de la base: ");
                double bR = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la altura: ");
                double alturaR = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("El área del rectángulo es: " + operaciones.ObtenerAreaRectangulo(bR, alturaR));
                break;
            
            case "d":

                Console.WriteLine("Ingrese el valor del radio: ");
                double radio = int.Parse(Console.ReadLine());
                
                Console.WriteLine();
                Console.WriteLine("El área del círculo es: " + operaciones.ObtenerAreaCirculo(radio));
                break;
            
            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.ReadKey(); 

        string opcion2; 
        Personaje personaje = new Personaje(0,0);
        do
        {
            
            Console.WriteLine("Ejercicio No. 2");
            Console.WriteLine(); 
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("a. Sube");
            Console.WriteLine("b. Baja");
            Console.WriteLine("c. Izquierda");
            Console.WriteLine("d. Derecha");
            Console.WriteLine("e. Salir");
            Console.WriteLine(); 

            opcion2 = Console.ReadLine();
            Console.WriteLine(); 

            switch (opcion2)
            {
                case "a":
                    personaje.MoverHaciaArriba(LeerCantidad("Arriba"));
                    break;
                case "b":
                    personaje.MoverHaciaAbajo(LeerCantidad("Abajo"));
                    break;
                case "c":
                    personaje.MoverHaciaIzquierda(LeerCantidad("Izquierda"));
                    break;
                case "d":
                    personaje.MoverHaciaDerecha(LeerCantidad("Derecha"));
                    break;
                case "e":
                    Console.WriteLine("Las coordenadas finales del objeto son: (" + personaje.GetX() + ", " + personaje.GetY()+ ")");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion2 != "e");

    }

    static int LeerCantidad(string direccion)
    {
        Console.WriteLine("Ingrese la cantidad a moverse: ");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }
}    
