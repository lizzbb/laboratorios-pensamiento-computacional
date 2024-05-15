class Automovil 
{
private int modelo = 2019;
private double precio = 10000.00;
private string marca = "";
private bool disponible = false;
private double tipoCambioDolar = 7.50;
private double descuentoAplicado = 0.00;

public Automovil()
{
    modelo = 2019; 
    precio = 10000.00;
    marca = "";
    disponible = false;
    tipoCambioDolar = 7.50;
    descuentoAplicado = 0.00;
}

public void DefinirModelo(int unModelo)
{
    modelo = unModelo;
    
}
public void DefinirPrecio(double unPrecio)
{
    precio = unPrecio;
}

public void DefinirMarca(string unaMarca)
{
    marca = unaMarca; 
}

public void DefinirTipoCambio(double unTipoCambio)
{
    tipoCambioDolar = unTipoCambio;
}
public void CambiarDisponibilidad()
{
    if(disponible == true)
    {
        disponible = false;
    }
    else
    {
        disponible = true;
    }
}

public string MostrarDisponibilidad()
{
    if (disponible == true)
    {
        return "Disponible"; 
    }
    else 
    {
        return "No se encuentra disponible actualmente";
    }
}

public string MostrarInformacion()
{
    double precioEnDolares = precio / tipoCambioDolar;
    string informacion;
    return informacion = "Marca: " + marca + ". Modelo: " + modelo + ". Precio de venta: Q" + precio + 
    ". Precio en dólares: $" + precioEnDolares + ". " + MostrarDisponibilidad();
}

public void AplicarDescuento(double miDescuento)
{
    descuentoAplicado = miDescuento;
    precio = precio - descuentoAplicado;
    DefinirPrecio(precio);
}
}