using System.Data;
using System.Globalization;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];
    public int cantidadFilas = 0;
    public int cantidadCols = 0;
    int[,] cantidadDeVeces = new int[0,0];
    public int[] vector = new int[0];

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public int[,] BuscarValor(int valor)
    {
        cantidadDeVeces = new int[cantidadFilas, 2];
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            int contador = 0;
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] < valor)
                {
                    contador++;
                }
            }

        cantidadDeVeces[i, 0] = i;
        cantidadDeVeces[i, 1] = contador;
        contador = 0;
        }
        
        return cantidadDeVeces;
    }


    public int[] VectorDePares()
    {
        int mod = 0;
        vector = new int[matriz.Length];
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] % 2 == 0)
                {
                    vector[mod] = matriz[i,j];
                    mod++;
                }
            }
        }
        Array.Resize(ref vector, mod);
        return vector;
    }

    public void ImprimirMatriz()
    {
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j] + "|");
            }
            Console.WriteLine();
        }
    }

    public void ImprimirVector()
    {
        for(int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + "|");
        }
        Console.WriteLine();
    }

    public void ImprimirValores()
    {
        for(int i = 0; i < cantidadDeVeces.GetLength(0); i++)
        {
            for(int j = 0; j < cantidadDeVeces.GetLength(1); j++)
            {
                Console.Write(cantidadDeVeces[i,j] + "|");
            }
            Console.WriteLine();
        }
    }

}