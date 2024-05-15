using System.Runtime.CompilerServices;

namespace L12___Lizbeth_Herrera___1246024;

public class Circulo
{
    private double radio; 
     public Circulo(double radio)
    {
        this.radio = radio;
        
    }

    private double ObtenerPerimetro(double radio)
    {
        return 2 * Math.PI * radio;
    }

    private double ObtenerArea(double radio)
    {
        return Math.PI * Math.Pow(2, radio);
    }

    private double ObtenerVolumen(double radio)
    {
        return (4 * Math.PI * Math.Pow(3, radio)) / 3;
    }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    {
        unPerimetro = ObtenerPerimetro(radio);
        unArea = ObtenerArea(radio);
        unVolumen = ObtenerVolumen(radio);

    }
   

}
