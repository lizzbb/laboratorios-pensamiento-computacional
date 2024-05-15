using System.Security.Cryptography;

class Program 
{
    static void Main(string[] args)
    {
        string nombre;
        double número1;
        double número2;
        
        
        
        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine();

        Console.WriteLine("Parte 2: Ejercicio 1, Operaciones aritméticas");
        Console.WriteLine("Ingrese el primer número");
        número1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        número2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        double suma = número1 + número2; 
        double resta = número1 - número2;
        double mult = número1 * número2;
        double div = número1 / número2;
        double mod = número1 % número2;

        Console.WriteLine(número1 + " + " + número2 + " = " + suma);
        Console.WriteLine(número1 + " - " + número2 + " = " + resta);
        Console.WriteLine(número1 + " * " + número2 + " = " + mult);
        Console.WriteLine(número1 + " / " + número2 + " = " + div);
        Console.WriteLine(número1 + " % " + número2 + " = " + mod);
        Console.WriteLine();

        Console.WriteLine("Parte 2: Ejercicio 2, Operaciones booleanas");
        bool mayor = número1 > número2; 
        bool menor = número1 < número2;
        bool igual = número1 == número2;  

        Console.WriteLine(número1 + " > " + número2 + ": " + mayor); 
        Console.WriteLine(número1 + " < " + número2 + ": " + menor);
        Console.WriteLine(número1 + " = " + número2 + ": " + igual);  
        Console.WriteLine();

        Console.WriteLine("Parte 2: Ejercicio 3, Jerarquía de operaciones");
        double a; 
        double b; 
        double c; 
        double dos = 2;
        double tres = 3; 

        Console.WriteLine("Ingrese el primer número");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        c = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        double i = a * b + c;
        double ii = a * (b + c);
        double iii = a / (b * c);
        double iv = (dos * a) + (tres * b) / c * c; 

        Console.WriteLine("Operaciones");
        Console.WriteLine("i. " + a + " * " + b + " + " + c + " = " + i);
        Console.WriteLine("ii. " + a + " * " + "(" + b + " + " + c + ")" + " = " + ii);
        Console.WriteLine("iii. " + a + " / " + "(" + b + " * " + c + ")" + " = " + iii);
        Console.WriteLine("iv. 3(" + a + ") " + "+ 2(" + b + ")" + " / " + c + "^2" + " = " + iv);
        Console.WriteLine();

        Console.WriteLine("Fórmula Cuadrática");
        double disc = (b*b) - 4*a*c;

        if(disc<0)
        {
            disc=-disc; 
            Console.WriteLine("No tiene soluciones reales"); 
        }
        else
        {
            Console.WriteLine("Soluciones reales: ");

             if (a!=0)
            {
                double x1 = - b + Math.Sqrt(disc) / 2 * a; 
                double x2 = - b - Math.Sqrt(disc) / 2 * a; 
                Console.WriteLine("x= " + "-" + b + " + √(" + b + "^2" + "-4(" + a + ")(" + c + ")) / 2(" + a + ") = " + x1 );
                Console.WriteLine("x= " + "-" + b + " - √(" + b + "^2" + "-4(" + a + ")(" + c + ")) / 2(" + a + ") = " + x2 );
            }
            else
            {
                Console.WriteLine();
            }
        }}}
