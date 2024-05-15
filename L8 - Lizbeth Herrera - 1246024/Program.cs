class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string entrada;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Menú");
            Console.WriteLine("1) Sumatoria");
            Console.WriteLine("2) Factorial");
            Console.WriteLine("3) Tablas de multiplicar");
            Console.WriteLine("4) Salir");
            Console.WriteLine();
            Console.WriteLine("Ingrese un número 1-4");

            entrada = Console.ReadLine();

            try
            {
                opcion = int.Parse(entrada);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese un número positivo");
                    string entradaNumero = Console.ReadLine();
                    int n = 0;

                    try
                    {
                        n = int.Parse(entradaNumero);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error");
                    }

                    int i = 1;
                    int sumatoria = 0;
                    
                    while(i <= n)
                    {
                        sumatoria += 1;
                        i++;
                    }

                    Console.WriteLine($"Sumatoria: {sumatoria}");
                    break;

                case 2:
                Console.WriteLine("Ingrese un número positivo");
                    string entradaNumeroF = Console.ReadLine();
                    int nF = 0;

                    try
                    {
                        nF = int.Parse(entradaNumeroF);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error, ingrese un número");
                    }

                    int j = 1;
                    int factorial = 1;
                    
                    while(j <= nF)
                    {
                        factorial *= j;
                        j++;
                    }

                    Console.WriteLine($"Factorial: {factorial}");
                    break;

                case 3:
            string titulo = "\t";

                Console.WriteLine();
                Console.WriteLine("Tablas de multiplicar");
                for (int ititulo = 0; ititulo < 11; ititulo++)
                {
                    titulo += ititulo + "\t";
                }
                Console.WriteLine(titulo);

                string fila = "";
                for (int ifila = 0; ifila < 11; ifila++)
                {
                    fila = ifila + "\t";
                    for (int imultiplo = 0; imultiplo < 11; imultiplo++)
                    {
                        fila += imultiplo*ifila + "\t";
                    }
                    
                    Console.WriteLine(fila);
                }
                    break;

                default:
                    Console.WriteLine("Error, ingrese un número del 1 al 4");
                    break;
            }
            Console.ReadKey();
        }
        while (opcion != 4);
    }
}
