using System.Drawing;

namespace PROYECTO2;

public class Tablero
{
    public string[,] tablero = new string[8,8]; //arreglo en el que se guardan las piezas
    public string[] listaMovimientos = new string[64]; //arreglo en el que se guardan los movimientos

    //Metodo para agregar la pieza de la reina
    public void AgregarReina(Reina reina)
    {
        //Valida que las posiciones estén en el rango de tamaño del arreglo tablero
        if(reina.letraInt > 8 || reina.letraInt < 0 && reina.numeroInt > 8 || reina.numeroInt < 0)
        {
            Console.WriteLine("Posición inválida.");
        }

        //Verificar que la posición en la que se ingresa la pieza esté desocupada
        if(tablero[reina.numeroInt,reina.letraInt] == null)
        {
            tablero[reina.numeroInt,reina.letraInt] = reina.ToString();
        }
        else
        {
            Console.WriteLine("Ya existe una pieza en esa posición.");
        }
    }

    //Metodo para agregar piezas en el tablero
    public void AgregarPieza(Pieza pieza)
    {
        //Valida que las posiciones estén en el rango de tamaño del arreglo tablero
        if(pieza.letraInt > 8 || pieza.letraInt < 0 && pieza.numeroInt > 8 || pieza.numeroInt < 0)
        {
            Console.WriteLine("Posición inválida.");
        }

        //Verificar que la posición en la que se ingresa la pieza esté desocupada
        if(tablero[pieza.numeroInt,pieza.letraInt] == null)
        {
            tablero[pieza.numeroInt,pieza.letraInt] = pieza.ToString();
        }
        else
        {
            Console.WriteLine("Ya existe una pieza en esa posición.");
        }
    }

    //Función que recorre el tablero en base a la posición de la reina
    //y retorna un arreglo de los movimientos que puede realizar
    public string[] ListaMovimientos(Reina reina)
    {
        int k = 0; //valor que define la posición del arreglo de movimientos
        bool salir = false; 
        char letraR = char.Parse(reina.posicionReina.Substring(0,1));
        int aumento = 1;

        //Validar movimientos diagonal hacia arriba e izquierda de la reina
        // for (int i = reina.numeroInt - 1; i > 0; i--)
        // {
        //     for (int j = reina.letraInt - 1; j > reina.letraInt - 2; j--)
        //     {
        //         if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
        //         {
        //             listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: Vacío";
        //             k++;
        //             aumento++;
        //         }
        //         else 
        //         {
        //             int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
        //             if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
        //             {
        //                 listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: {tablero[i,j]}";
        //                 k++;
        //                 aumento++;
        //             }
        //             else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
        //             {
        //                 salir = true; 
        //                 break;
        //             }
        //         }
        //     }
        //     if (salir) //Se detiene el ciclo de la fila
        //     {
        //         break;
        //     }
        // }

        // aumento = 1;
        //  //Validar movimientos diagonal hacia abajo y derecha de la reina
        // for (int i = reina.numeroInt + 1; i < tablero.GetLength(0); i++)
        // {
        //     for (int j = reina.letraInt + 1; j < reina.letraInt + 2; j++)
        //     {
        //         if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
        //         {
        //             listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: Vacío";
        //             k++;
        //             aumento++;
        //         }
        //         else 
        //         {
        //             int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
        //             if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
        //             {
        //                 listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: {tablero[i,j]}";
        //                 k++;
        //                 aumento++;
        //             }
        //             else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
        //             {
        //                 salir = true; 
        //                 break;
        //             }
        //         }
        //     }
        //     if (salir) //Se detiene el ciclo de la fila
        //     {
        //         break;
        //     }
        // }

        // aumento = 1;
        //  //Validar movimientos diagonal hacia abajo e izquierda de la reina
        // for (int i = reina.numeroInt + 1; i < tablero.GetLength(0); i++)
        // {
        //     for (int j = reina.letraInt - 1; j < reina.letraInt - 2; j--)
        //     {
        //         if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
        //         {
        //             listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: Vacío";
        //             k++;
        //             aumento++;
        //         }
        //         else 
        //         {
        //             int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
        //             if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
        //             {
        //                 listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: {tablero[i,j]}";
        //                 k++;
        //                 aumento++;
        //             }
        //             else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
        //             {
        //                 salir = true; 
        //                 break;
        //             }
        //         }
        //     }
        //     if (salir) //Se detiene el ciclo de la fila
        //     {
        //         break;
        //     }
        // }

        // aumento = 1;
        //  //Validar movimientos diagonal hacia arriba y derecha de la reina
        // for (int i = reina.numeroInt - 1; i >= 0; i--)
        // {
        //     for (int j = reina.letraInt + 1; j < reina.letraInt + 2; j++)
        //     {
        //         if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
        //         {
        //             listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: Vacío";
        //             k++;
        //             aumento++;
        //         }
        //         else 
        //         {
        //             int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
        //             if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
        //             {
        //                 listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: {tablero[i,j]}";
        //                 k++;
        //                 aumento++;
        //             }
        //             else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
        //             {
        //                 salir = true; 
        //                 break;
        //             }
        //         }
        //     }
        //     if (salir) //Se detiene el ciclo de la fila
        //     {
        //         break;
        //     }
        // }

        aumento = 1;
        //Validar movimientos hacia la izquierda de la reina
        for (int i = reina.numeroInt; i < reina.numeroInt + 1; i++)
        {
            for (int j = reina.letraInt - 1; j >= 0; j--)
            {
                if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
                {
                    listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: Vacío";
                    k++;
                    aumento++;
                }
                else 
                {
                    int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
                    if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
                    {
                        listaMovimientos[k] = $"{(char)(letraR - aumento)}{i + 1}: {tablero[i,j]}";
                        k++;
                        aumento++;
                    }
                    else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
                    {
                        salir = true; 
                        break;
                    }
                }
            }
            if (salir) //Se detiene el ciclo de la fila
            {
                break;
            }
        }

        aumento = 1;
        //Validar movimientos hacia la derecha de la reina
        for (int i = reina.numeroInt; i < reina.numeroInt + 1; i++)
        {
            for (int j = reina.letraInt + 1; j < tablero.GetLength(1); j++)
            {
                if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
                {
                    listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: Vacío";
                    k++;
                    aumento++;
                }
                else 
                {
                    int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
                    if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
                    {
                        listaMovimientos[k] = $"{(char)(letraR + aumento)}{i + 1}: {tablero[i,j]}";
                        k++;
                        aumento++;
                    }
                    else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
                    {
                        salir = true; 
                        break;
                    }
                }
            }
            if (salir) //Se detiene el ciclo de la fila
            {
                break;
            }
        }

        //Validar movimientos hacia arriba de la reina
        for (int i = reina.numeroInt + 1; i < tablero.GetLength(0); i++)
        {
            for (int j = reina.letraInt; j < reina.letraInt + 1; j++)
            {
                if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
                {
                    listaMovimientos[k] = $"{letraR}{i + 1}: Vacío";
                    k++;
                }
                else 
                {
                    int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
                    if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
                    {
                        listaMovimientos[k] = $"{letraR}{i + 1}: {tablero[i,j]}";
                        k++;
                    }
                    else //Si encuentra coincidencias, detiene el ciclo al recorrer la columna
                    {
                        salir = true; 
                        break;
                    }
                }
            }
            if (salir) //Se detiene el ciclo de la fila
            {
                break;
            }
        }

        //Validar movimientos hacia abajo de la reina
        for (int i = reina.numeroInt; i >= 0; i--)
        {
            for (int j = reina.letraInt; j < reina.letraInt + 1; j++)
            {
                if (tablero[i, j] == null) //Si se encuentra vacía la posición se agrega a la lista
                {
                    listaMovimientos[k] = $"{letraR}{i + 1}: Vacío";
                    k++;
                }
                else 
                {
                    int si = tablero[i,j].IndexOf(reina.colorReina); //Index del color de la reina
                    if(si == -1) //Si no se encuentran coincidencias con el color, se agrega la pieza a la lista
                    {
                        listaMovimientos[k] = $"{letraR}{i + 1}: {tablero[i,j]}";
                        k++;
                    }
                    else
                    {
                        if(tablero[i,j] == reina.ToString()) //Se agrega la posición de la reina en la lista
                        {
                            listaMovimientos[k] = $"{letraR}{i + 1}: {tablero[i,j]}";
                            k++;
                        }
                        else //Se detiene el ciclo al recorrer la columna
                        {
                        salir = true; 
                        break;
                        }
                    }
                }
            }
            if (salir) //Se detiene el ciclo de la fila
            {
                break;
            }
        }

        Array.Resize(ref listaMovimientos, k); // Se actualiza el tamaño del arreglo según el número total de movimientos que se encuentren
        return listaMovimientos; //Retorna el arreglo de la lista
    }

    //Metodo para mostrar la lista de movimientos
    public void ImprimirListaMovimientos(string[] mov)
    {
        for (int i = 0; i < mov.Length; i++) //Se recorre el arreglo de la lista
        {
            Console.WriteLine(mov[i]); //Se escribe cada elemento
        }
    }
    
    //Metodo para mostrar el tablero con las piezas agregadas
    public void ImprimirTablero()
    {
        //Se recorre el arreglo de tablero en sus dos dimensiones
        for(int i = 0; i < tablero.GetLength(0); i++)
        {
            int aumento = 0;
            for(int j = 0; j < tablero.GetLength(1); j++)
            {
                Console.Write($"{(char)('a' + aumento)}{i + 1}: " + tablero[i,j] + "    |    "); //Se escribe la posición en notación de juego y lo que contiene esa posición
                aumento++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
