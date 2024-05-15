using L12___Lizbeth_Herrera___1246024;

class Program
{
    public static void Main(string[] argrs)
    {
        Console.WriteLine("Ingrese el radio del círculo");
        string Radio = Console.ReadLine(); 
        double dRadio = double.Parse(Radio);
        Console.WriteLine(); 
        
        Circulo objCirculo = new Circulo(dRadio);

        double perimetro = 0;
        double area = 0;
        double volumen = 0; 

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
        Console.WriteLine("Perímetro: " + perimetro); 
        Console.WriteLine("Área: " + area); 
        Console.WriteLine("Volumen: " + volumen); 
    }
}
