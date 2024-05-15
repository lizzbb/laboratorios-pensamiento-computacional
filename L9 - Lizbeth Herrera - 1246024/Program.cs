class Program {
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil();

        Console.WriteLine("Ingrese el modelo del automóvil");
        objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));
        Console.WriteLine("Ingrese el precio del automóvil");
        objAutomovil.DefinirPrecio(double.Parse(Console.ReadLine()));
        Console.WriteLine("Ingrese la marca del automóvil");
        objAutomovil.DefinirMarca(Console.ReadLine());
        Console.WriteLine("Ingrese el tipo de cambio del automóvil");
        objAutomovil.DefinirTipoCambio(double.Parse(Console.ReadLine()));
        
        Console.WriteLine();
        Console.WriteLine("Modelo: " + objAutomovil.MostrarInformacion());
        Console.WriteLine(); 

        Console.WriteLine("¿Desea cambiar la disponibilidad? (Disponibilidad actual: " + objAutomovil.MostrarDisponibilidad() + "). Sí = y, No = n");
        if (Console.ReadLine().ToLower() == "y")
        {
            objAutomovil.CambiarDisponibilidad();
        }
        Console.WriteLine(); 
        
        Console.WriteLine("¿Desea aplicar un descuento?");
        Console.WriteLine("1. Sí");
        Console.WriteLine("2. No");
        Console.WriteLine();
        if (Console.ReadLine().ToLower() == "1")
        {
            Console.WriteLine("Descuento a aplicar:");
        objAutomovil.AplicarDescuento(double.Parse(Console.ReadLine()));
        
        Console.WriteLine();
        Console.WriteLine(objAutomovil.MostrarInformacion()); 
        }
        else
        {
            Console.WriteLine(objAutomovil.MostrarInformacion());
        }
    }
}
