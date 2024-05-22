namespace PROYECTO2;

public class Pieza
{
    public string tipoPieza;
    public string colorPieza;
    public string posicionPieza;
    public string letra = "";
    public string numero = "";
    public int letraInt = 0;
    public int numeroInt = 0;

    public Pieza(string tipo, string color, string posicion)
    {
        //Asignar propiedades al ingresar una pieza en el Program
        tipoPieza = tipo;
        colorPieza = color;
        posicionPieza = posicion;
        letra = posicion.Substring(0,1);
        numero = posicion.Substring(1,1);

        //Convierte la notación de juego en números enteros para utilizar 
        //como posiciones en el arreglo de string[,] del tablero
        switch(letra)
        {
            case "a":
                letra = "0";
                letraInt = int.Parse(letra);
                break;
            case "b":
                letra = "1";
                letraInt = int.Parse(letra);
                break;
            case "c":
                letra = "2";
                letraInt = int.Parse(letra);
                break;
            case "d":
                letra = "3";
                letraInt = int.Parse(letra);
                break;
            case "e":
                letra = "4";
                letraInt = int.Parse(letra);
                break;
            case "f":
                letra = "5";
                letraInt = int.Parse(letra);
                break;
            case "g":
                letra = "6";
                letraInt = int.Parse(letra);
                break;
            case "h":
                letra = "7";
                letraInt = int.Parse(letra);
                break;
            default: 
                Console.WriteLine("Posición de columna inválida.");
                break;
        }
        numeroInt = int.Parse(numero);
        numeroInt -= 1;
    }

     //Convierte las propiedades del objeto en un string para poder ingresarlo al tablero
    public override string ToString()
    {
        return $"{tipoPieza}, {colorPieza}";
    }
}
