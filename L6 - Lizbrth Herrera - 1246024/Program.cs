class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Ejercicio 1"); 
    Console.WriteLine(); 

    int numeroMes; 
    string entradaMes; 
    string mesCadena;

    Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el nombre del mes correspondiente");
    entradaMes = Console.ReadLine();

    if(int.TryParse(entradaMes, out numeroMes))
    {
        Console.WriteLine($"Se convirtió '{entradaMes}' a '{numeroMes}'");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("“Error: El número a ingresar debe estar contenido entre 1 y 12");
        Console.WriteLine(); 
    }

    Console.WriteLine(numeroMes);

    switch(numeroMes)
    {
        case 1:
            mesCadena = "Enero";
            break;
        
        case 2: 
            mesCadena = "Febrero";
            break;

        case 3: 
            mesCadena = "Marzo"; 
            break;
        
        case 4: 
            mesCadena = "Abril"; 
            break;
        
        case 5: 
            mesCadena = "Mayo"; 
            break;
        
        case 6: 
            mesCadena = "Junio"; 
            break;
        
        case 7: 
            mesCadena = "Julio"; 
            break;
        
        case 8: 
            mesCadena = "Agosto"; 
            break;
        
        case 9: 
            mesCadena = "Septiembre"; 
            break;
        
        case 10: 
            mesCadena = "Octubre"; 
            break;
        
        case 11: 
            mesCadena = "Noviembre"; 
            break;
        
        case 12: 
            mesCadena = "Diciembre"; 
            break;
        
        default: 
            Console.WriteLine("Error: Debe ingresar un número del 1 al 12"); 
            mesCadena = " "; 
            break;
    }

    Console.WriteLine($"Mes = '{mesCadena}'");
    Console.WriteLine(); 
    Console.WriteLine();

    Console.WriteLine("Ejercicio 2");
    Console.WriteLine(); 
    int a,b,c; 
    Console.WriteLine("Ingrese tres números mayor a 0"); 
    int.TryParse(Console.ReadLine(), out a);
    int.TryParse(Console.ReadLine(), out b);
    int.TryParse(Console.ReadLine(), out c);
    Console.WriteLine();

    if(a <= 0)
    {
        Console.WriteLine("El primer número debe ser mayor a 0");
        Console.WriteLine("Ingrese otro número");
        int.TryParse(Console.ReadLine(), out a);
        Console.WriteLine();
    }
    if(b <= 0)
    {
        Console.WriteLine("El segundo número debe ser mayor a 0"); 
        Console.WriteLine("Ingrese otro número");
        int.TryParse(Console.ReadLine(), out b);
        Console.WriteLine();
    }
    if(c <= 0)
    {
        Console.WriteLine("El tercer número debe ser mayor a 0"); 
        Console.WriteLine("Ingrese otro número");
        int.TryParse(Console.ReadLine(), out c);
        Console.WriteLine();
    }

    if(a > b)
    {
        if(a > c)
        {
            Console.WriteLine($"El número mayor es: '{a}'");
        }
        else if(a == c)
        {
            Console.WriteLine($"'{a}' y '{c}' son iguales, por lo tanto son los mayores");
        }
        else
        {
            Console.WriteLine($"El número mayor es: '{c}'");
        }
    }
    else if(a == b)
    {
        if(a > c)
        {
            Console.WriteLine($"'{a}' y '{b}' son iguales, por lo tanto son los mayores");
        }
        else if(a == c)
        {
            Console.WriteLine($"Todos los números son iguales");
        }
        else
        {
            Console.WriteLine($"El número mayor es: '{c}'");
        }
    }
    else
    {
        if(b > c)
        {
            Console.WriteLine($"El número mayor es: '{b}'");
        }
        else if(b == c)
        {
            Console.WriteLine($"'{b}' y '{c} son iguales, por lo tanto son los mayores");
        }
        else
        {
            Console.WriteLine($"El número mayor es: '{c}'");
        }
    }
    }
}
