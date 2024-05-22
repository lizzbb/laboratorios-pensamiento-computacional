using System.Security.Cryptography.X509Certificates;
using PROYECTO2;

class Program
{
    static void Main(string[] args)
    {
        Tablero tablero = new Tablero(); //Creación del objeto de tablero para utilizar sus metodos y funciones

        Console.WriteLine("Buenos días, se evaluarán los movimientos de una pieza de Reina en un tablero de ajedrez");
        
        //Pedir los datos de la reina a evaluar sus movimientos
        Console.WriteLine("Ingrese el color de la pieza de la reina: ");
        string colorReina = Console.ReadLine();
        Console.WriteLine("Ingrese la posicion en notacion de juego de la pieza de la reina:");
        string posicionReina = Console.ReadLine();

        //Creación del objeto de la reina
        Reina reina = new Reina(colorReina, posicionReina);
        tablero.AgregarReina(reina);

        string opcion;
        string tipoPieza = "";
        string colorPieza = "";
        string posicionPieza = "";
        Pieza pieza = null;

        do //Menú de opciones
        {
            Console.WriteLine("Escoja una opción: \n1. Ingresar una pieza \n2. Imprimir tablero \n3. Lista de movimientos \n4. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el tipo de pieza:");
                    tipoPieza = Console.ReadLine();
                    Console.WriteLine("Ingrese el color de la pieza: ");
                    colorPieza = Console.ReadLine();
                    Console.WriteLine("Ingrese la posicion en notacion de juego de la pieza: ");
                    posicionPieza = Console.ReadLine();
                    pieza = new Pieza(tipoPieza, colorPieza, posicionPieza);
                    
                    tablero.AgregarPieza(pieza);
                    break;

                case "2":
                    tablero.ImprimirTablero();
                    break;
                
                case "3":
                    tablero.ImprimirListaMovimientos(tablero.ListaMovimientos(reina));
                    Console.WriteLine();
                    break;

                case "4":
                    break;
            }
        }
        while (opcion != "4");
    }
}

