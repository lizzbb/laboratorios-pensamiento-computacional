using Microsoft.VisualBasic;

class Program 
{
    static void Main(string[] args)
    {

        Console.WriteLine("Laboratorio No. 07 - Lizbeth Herrera - 1246024"); 
        Console.WriteLine();

        int NFibonacci; 
        bool conver = false;
        bool nPositivo = false;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conver = int.TryParse(Console.ReadLine(), out NFibonacci);
            Console.WriteLine(); 

            if(conver)
            {
                if(NFibonacci > 0)
                {
                    nPositivo = true;
                }
            }
        }
        while(!conver || !nPositivo);

        string resultado = ""; 
        int A = 0;
        int B = 1;
        int C = 0;
        int i = 2;

        if(NFibonacci > 0)
        {
            resultado = A + ", ";

            if(NFibonacci > 1)
            {
                resultado += B + ", ";

                do
                {
                    C = A + B;
                    resultado += C + ", ";
                    A = B;
                    B = C;
                    i = i + 1;

                }
                while(i < NFibonacci);
            
            Console.WriteLine(resultado);   
            }
        }
    
    }
}