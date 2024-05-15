namespace L11___Lizbeth_Herrera___1246024;

public class Operaciones
{
    public double ObtenerAreaTriangulo(double b, double altura)
    {
        return b * altura / 2;
    }

    public double ObtenerAreaCuadrado(double lado)
    {
        return Math.Pow(lado, 2);
    }

    public double ObtenerAreaRectangulo(double b, double altura)
    {
        return b * altura;
    }

    public double ObtenerAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }


}
