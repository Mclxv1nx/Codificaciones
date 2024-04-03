using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeraMatriz();
            //Matriz inclinada  1 3 6 
            /*
            Console.WriteLine("matriz n x n");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int acumulador = 1;

            // cambia de fila
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matriz[i - j, j] = acumulador++;

                }
            }
            // cambia de columna
            for (int j = 1; j < n; j++)
            {
                for (int i = n - 1; i >= j; i--)
                {
                    matriz[i, j + n - i - 1] = acumulador++;

                }
            }

            // imprimir la matriz 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
            //Matriz espiral 1 2 3
            /*Console.WriteLine("Ingrese el tamaño de la matriz (N x N): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            int valor = 1;
            int inicioFila = 0;
            int finFila = n - 1;
            int inicioColumna = 0;
            int finColumna = n - 1;

            while (valor <= n * n)
            {
                // Rellenar hacia la derecha
                for (int i = inicioColumna; i <= finColumna; i++)
                {
                    matriz[inicioFila, i] = valor++;
                }
                inicioFila++;

                // Rellenar hacia abajo
                for (int i = inicioFila; i <= finFila; i++)
                {
                    matriz[i, finColumna] = valor++;
                }
                finColumna--;

                // Rellenar hacia la izquierda
                for (int i = finColumna; i >= inicioColumna; i--)
                {
                    matriz[finFila, i] = valor++;
                }
                finFila--;


                // Rellenar hacia arriba
                for (int i = finFila; i >= inicioFila; i--)
                {
                    matriz[i, inicioColumna] = valor++;
                }
                inicioColumna++;
            }

            // Imprimir la matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */
            //Caja en diagonales
            /*
            Console.WriteLine("Ingrese el valor del tamaño de la matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int incremento = 1;

            // Primera Diagonal
            for (int i = 0; i < n; i++)
            {
                matriz[i, i] = incremento++;
            }

            // Segunda Diagonal
            for (int j = n - 1; j >= 0; j--)
            {
                if (matriz[n - 1 - j, j] == 0)
                {
                    matriz[n - 1 - j, j] = incremento++;
                }
            }

            // Primera fila
            for (int i = 1; i < n - 1; i++)
            {
                matriz[0, i] = incremento++;
            }

            // Última Columna
            for (int i = 1; i < n - 1; i++)
            {
                matriz[i, n - 1] = incremento++;
            }

            // Última fila
            for (int i = n - 2; i > 0; i--)
            {
                matriz[n - 1, i] = incremento++;
            }

            // Primera Columna
            for (int i = n - 2; i > 0; i--)
            {
                matriz[i, 0] = incremento++;
            }

            // Impresión de Matriz
            for (int hg = 0; hg < n; hg++)
            {
                Console.WriteLine();
                for (int wg = 0; wg < n; wg++)
                {
                    Console.Write(matriz[hg, wg] + "\t");
                }
            }
            Console.ReadLine();*/
            //Tarea 01 imprimir los números en orden descendente del 10 al 1
            /*for ( int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/
            //-------------------------------------------------------------------------------------------------------------

            //Tarea02 Imprimir los números en orden ascendente y descendente en un rango entre inicio y fin

            /*Console.WriteLine("Ingrese el valor inicial que sea menor al final");
             int inicio = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Ingrese el valor final que sea mayor al inicial");
             int final = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Lista Ascendente");
             for (int i = inicio; i <= final; i++)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("Lista Descendente");
             for (int j = final; j >= inicio; j--)
             {
                 Console.WriteLine(j);
             }
             Console.ReadLine();*/
            //---------------------------------------------------------------------------
            //Tarea03 Realizar una aplicación que calcule el factorial de un número
            /*int factorial = 1;

            Console.WriteLine("INGRESE EL NUMERO QUE VAMOS A VOLVER FACTORIAL");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);*/

            //Tarea04 Calcule potencia 
            //--------------------------------------------------------------------------------- 
            /*Console.WriteLine("Ingrese el Número de Base");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Número de Exponente");
            int exp = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 0; i < exp ; i++) 
            {
                resultado *= Base;
            }
            Console.Write("El resultado del número base elevado al exponente sera: " + resultado );
            */

            //TAREA ABECEDARIO 
            //--------------------------------------------------------------------------------------
            /*Console.WriteLine("LAS LETRAS DEL ABECEDARIO MAYUSCULAS");
            for (char letra = 'A'; letra <= 'Z'; letra ++)    
            {
                Console.Write(letra + " ");
            }
            Console.WriteLine("LAS LETRAS DEL ABECEDARIO MINUSCULA");   
            for (char letra = 'a'; letra <= 'z'; letra++)
            {
                Console.Write(letra + " ");
            }*/
            //TAREA 05 Imprimir las potencias de 2, de los numeros en un rango definido 
            //--------------------------------------------------------------------------------------
            /* Console.WriteLine("Ingrese el valor inicial del rango");
             int inicio = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el valor final del rango");
             int final = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese numero sera elevado a la potencia");
             int basenum = int.Parse(Console.ReadLine());
             for (int i = inicio ; i <= final; i++) 
             {
                 int poten = 1;

                 for (int j = 1; j <= i; j++)
                 {
                     poten *= basenum;
                 }
                 Console.WriteLine($"{basenum} Elevado a la potencia de " + i + " es " + poten);
             }*/
            //FIBONACCI
            /* Console.Write("Ingrese el número máximo de la serie de Fibonacci: ");
             int maximo = int.Parse(Console.ReadLine());

             int numAnterior = 0;
             int numActual = 1;

             Console.WriteLine("Serie de Fibonacci:");

             while (numActual <= maximo)
             {
                 Console.WriteLine(numActual);

                 int siguienteNum = numAnterior + numActual;
                 numAnterior = numActual;
                 numActual = siguienteNum;
             }*/
            /*
            * NUM PRIMOS
            */
            /* Console.WriteLine("Números primos en el rango de 1 a 100:");
            for (int numero = 2; numero <= 100; numero++)
            {
                bool esPrimo = true;

                for (int divisor = 2; divisor < numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(numero);
                }
            }*/
            //MATRIZ ANTIHORARIA
            /*
            int d = 0;
            do
            {
                Console.WriteLine("Escriba las columnas y filas de 3 a 7");
                d = int.Parse(Console.ReadLine());
            }
            while (d < 3 || d > 7);
            int[,] matriz = new int[d, d];
            int contador = 1;
            bool cambio = true;

            int i = 0;
            int j = d - 1;
            do
            {
                if (cambio)
                {
                    cambio = false;
                    matriz[0, i++] = contador++;
                }
                else
                {
                    cambio = true;
                    matriz[d - 1, j--] = contador++;

                }
            } while (contador <= d * 2);
            int m, n;
            m = 0;
            n = d - 1;
            i = d - 2;
            j = 1;
            bool change = true;
            while (contador <= d * d)
            {
                if (j == d - 1 || j == 0)
                {
                    n--;
                    if (j == d - 1)
                    {
                        j--;
                    }
                    if (j == 0)
                    {
                        j++;
                    }
                }
                if (i == 0 || i == d - 1)
                {
                    m++;
                    if (i == 0)
                    {
                        i++;
                    }
                    if (i == d - 1)
                    {
                        i--;
                    }
                }
                if (change)
                {
                    if (cambio)
                    {
                        cambio = false;
                        matriz[j++, n] = contador++;
                    }
                    else
                    {
                        cambio = true;
                        matriz[i--, m] = contador++;
                    }
                    if (i == 0)
                    {
                        change = false;
                    }
                }
                else
                {
                    if (cambio)
                    {
                        cambio = false;
                        matriz[i++, m] = contador++;
                    }
                    else
                    {
                        cambio = true;
                        matriz[j--, n] = contador++;
                    }
                    if (j == 0)
                    {
                        change = true;
                    }
                }
            }
            for (int a = 0; a < d; a++)
            {
                for (int b = 0; b < d; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
            */
            Console.Write("INGRESA EL MATRIZ N X N Impar: ");

            int n = int.Parse(Console.ReadLine());


            /*int[] vector = new int[n];
            Console.WriteLine("INGRESA VALORES");
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                suma = suma + vector[i];
            }
            Console.WriteLine("La suma es: " + suma.ToString());
            Console.WriteLine("El promedio es: " + suma / n);*/

            int[,] matriz = new int[n, n];
            int acumulador = 1;
            int aux = 0;
            int contador = 1;
            int filaInicial = 0, filaFinal = n - 1;
            int columnaInicial = 0, columnaFinal = n - 1;
            int centro = n / 2;


            // gusanito izq dere - dere izq
            /*for (int i = 0; i < n; i++)
            {   
                if (aux == 0)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        matriz[i, j] = acumulador++;

                    }
                    aux = 1;
                    
                }
                else
                {
                    for (int j = 0; j < n; j++)

                    {
                        matriz[i, j] = acumulador++;

                    }
                    aux = 0;
                } 
            }*/
            //diagonal principal 0 - 0
            /*for (int i = 0; i < n; i++)
            {
                matriz[i, i] = acumulador++;
            }*/
            //diagonal secundaria 0 - n-1
            /*for(int j = n-1; j >= 0; j--)
            {
                if (matriz[n-1-j,j] == 0)
                {
                    matriz[n - 1 - j, j] = acumulador++;
                } 
            }*/
            //diagonal secundaria n-1 - 0
            /*for(int i =n-1; i>=0; i--)
            {
                matriz[i,n-1-i] = acumulador++;
            }*/
            //diagonal principal n-1 - n-1
            /*for(int i = n-1; i >= 0; i--)
            {
                matriz[i,i ] = acumulador++;
            }*/
            //primera fila ----->
            /*for (int i = 0; i < n; i++)
            { 
                matriz[0, i] = acumulador++;
            }*/
            //primera fila <-----
            /*for(int i = n-1; i >= 0; i--)
            {
                matriz[0,i] = acumulador++;
            }*/
            //ultima fila ----->
            /*for(int i = 0; i < n; i++)
            {
                matriz[n-1, i] = acumulador++;
            }*/
            //ultima fila <-----
            /*for(int i =n-1; i>=0; i--)
            {
                matriz[n - 1, i] = acumulador++;
            }*/
            //primera columna  arriba hacia abajo
            /*for(int i = 0; i < n; i++)
            {
                matriz[i, 0] = acumulador++;
            }   */
            //primera columna abajo hacia arriba
            /*for(int i = n-1; i >=0; i--)
            {
                matriz[i, 0] = acumulador++;
            }*/
            //ultima columna abajo hacia arriba
            /*for(int i = n-1; i >=0; i--)
            {
                matriz[i,n-1]= acumulador++;
            }*/
            //ultima columna arriba hacia abajo 
            /*for(int i = 0; i < n; i++)
            {
                matriz[i,n-1]=acumulador++;
            }*/
            //Tarea 19 Gusanito desde 0-0 de izquierda a derecha
            /*for(int Fila = 0; Fila < n; Fila++)
            {
                if(aux == 0)
                {
                    for(int columna = n-1; columna >= 0; columna--)
                    {
                        matriz[Fila,columna]= acumulador++;
                    }
                     aux = 1;
                }
                else
                {
                    for(int columna = 0; columna < n; columna++)
                    {
                        matriz[Fila,columna] = acumulador++;
                    }
                    aux = 0;
                }
            }*/
            //Tarea 20 gusanito desde 0-0 de arriba hacia abajo
            /*for (int Fila = 0; Fila < n; Fila++)
            {
                if (aux == 0)
                {
                    for (int Columna = n - 1; Columna >= 0; Columna--)
                    {
                        matriz[Columna, Fila] = acumulador++;
                    }
                    aux = 1;
                }
                else
                {
                    for(int Columna = 0; Columna <n; Columna++)
                    {
                        matriz[Columna, Fila] = acumulador++;
                    }
                    aux = 0;
                }
            }*/
            //Tarea 21 Espiral desde 0-0 hacia derecha
            /*do
            {
                //SUPERIOR
                for (int i = columnaInicial; i <= columnaFinal; i++)
                {
                    matriz[filaInicial, i] = contador++;
                }
                filaInicial++;
                //DERECHA
                for (int i = filaInicial; i <= filaFinal; i++)
                {
                    matriz[i, columnaFinal] = contador++;
                }
                columnaFinal--;
                //INFERIOR
                for(int i = columnaFinal; i >= columnaInicial; i--)
                {
                    matriz[filaFinal,i] = contador++;
                }
                filaFinal--;
                //IZQUIERDA
                for(int i = filaFinal; i>=filaInicial;i--)
                {
                    matriz[i,columnaInicial] = contador++;
                }
                columnaInicial++;

            } while (contador <= n * n);*/
            //Tarea 22 gusanito desde n-1 - n-1 hacia de derecha a izquierda
            /*for (int Filas = n - 1; Filas >= 0; Filas--)
            {
                if (aux == 0)
                {
                    for (int columna = 0; columna < n; columna++) 
                    {
                        matriz[Filas, columna] = acumulador++;

                    }
                    aux = 1;

                }
                else
                {
                    for (int columna = n - 1;  columna>= 0; columna--)

                    {
                        matriz[Filas, columna] = acumulador++;

                    }
                    aux = 0;
                }
            }*/
            //Tarea 23 gusanito de n-1, n-1 de abajo hacia arriba
            /*for (int i = n - 1; i >= 0; i--)
            {
                if (aux == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matriz[j,i] = acumulador++;

                    }
                    aux = 1;

                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)

                    {
                        matriz[j,i] = acumulador++;

                    }
                    aux = 0;
                }
            }*/
            //Tarea 24 espiral desde dentro hacia afuera 

            /*matriz[centro, centro] = contador++;
            int i; // columnas
            int j; // filas
            int k; // columnas
            // l controla filas
            int o = 0;
            int p = n / 2 - 1;
            do
            {

                for(i = n/2-o; i <= n/2+1+o;i++)
                {
                    matriz[p, i] = contador++;
                }
                i--;
                for(j = n/2-o; j <= n/2+1+o;j++)
                {
                    matriz[j, i] = contador++;
                }
                j--;
                for(k = n/2+o; k >= n/2-1-o;k--)
                {
                    matriz[j,k]= contador++;
                }
                k++;
                for(int l = n/2+o; l >= n/2-1-o;l--)
                {
                    matriz[l,k] = contador++;
                }
                o++;
                p--;
            } while (contador <= n * n);

            */

            //Matriz inclinada   1  3  6 
            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matriz[i - j, j] = acumulador++;

                }
            }
            // cambia de columna
            for (int j = 1; j < n; j++)
            {
                for (int i = n - 1; i >= j; i--)
                {
                    matriz[i, j + n - i - 1] = acumulador++;

                }
            }*/

            //Matriz inclinada   1 2 4  

            /* for (int j = 0; j < n; j++)
             {
                 for (int i = 0; i <= j; i++)
                 {
                     matriz[i , j-i] = acumulador++;

                 }

             }
             // cambia de columna
             for (int j = 1; j < n; j++)
             {
                 for (int i = n - 1; i >= j; i--)
                 {
                     matriz[j + n - i - 1,i] = acumulador++;

                 }
             }*/
            //Matriz inclinada  6  8 9
            /* for (int i = 0; i < n; i++)
             {
                 int fl = n - 1;
                 int cl = i;
                 for (int j = 0; j < i + 1; j++)
                 {
                     matriz[fl--, cl--] = acumulador++;
                 }
             }

             for (int i = 1; i < n; i++)
             {
                 int fl = n - 1 - i;
                 int cl = n - 1;
                 for (int j = 0; j < n - i; j++)
                 {
                     matriz[fl--, cl--] = acumulador++;
                 }
             }*/
            //Matriz inclinada 4 7 9
            /*int valor = 1;

            //Generar posiciones dentro de la matriz. La primera mitad. 
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int cl = 0;
                int fl = n - 1 - j;
                for (int i = 0; i < j + 1; i++)
                {
                    //Console.Write(fl++ +""+ cl++ + " ");
                    matriz[fl++, cl++] = valor++;
                }
            }

            //Generar posiciones dentro de la matriz. La segunda mitad. 
            for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            {
                int cl = n-j;
                int fl = 0;
                for (int i = 0; i < j; i++)
                {
                    //Console.Write(fl++ +""+ cl++ + " ");
                    matriz[fl++, cl++] = valor++;
                }
            }*/

            //Matriz Inclinada  4 2 1
            /*int valor = 1;

            //Generar posiciones dentro de la matriz. La primera mitad. 
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int cl = n - 1 - j;
                int fl = 0;
                for (int i = 0; i < j + 1; i++)
                {
                    //Console.WriteLine(fl++ +""+ cl++ + " ");
                    matriz[fl++, cl++] = valor++;
                }
            }

            //Generar posiciones dentro de la matriz. La segunda mitad. 
            for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            {
                int cl = 0;
                int fl = n - j;
                for (int i = 0; i < j; i++)
                {
                    //Console.WriteLine(fl++ +""+ cl++ + " ");
                    matriz[fl++, cl++] = valor++;
                }
            }*/
            //Matriz Inclinada 6 3 1
            /*int valor = 1;

           //Generar posiciones dentro de la matriz. La primera mitad. 
           for (int j = 0; j < matriz.GetLength(1); j++)
           {
               int cl = n - 1;
               int fl = j;
               for (int i = 0; i < j + 1; i++)
               {
                  // Console.Write(fl-- +""+ cl-- + " ");
                   matriz[fl--, cl--] = valor++;
               }
           }

           //Generar posiciones dentro de la matriz. La segunda mitad. 
           for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
           {
               int cl = j - 1;
               int fl = n - 1;
               for (int i = 0; i < j; i++)
               {
                   //Console.Write(fl-- +""+ cl-- + " ");
                   matriz[fl--, cl--] = valor++;
               }
           }*/

            //Matriz Inclinada 9 8 6 
            /*int valor = 1;

            //Generar posiciones dentro de la matriz. La primera mitad. 
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int cl = n - 1 - j;
                int fl = n - 1;
                for (int i = 0; i < j + 1; i++)
                {
                    //Console.Write(fl-- +""+ cl++ + " ");
                    matriz[fl--, cl++] = valor++;
                }
            }

            //Generar posiciones dentro de la matriz. La segunda mitad. 
            for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            {
                int cl = 0;
                int fl = j - 1;
                for (int i = 0; i < j; i++)
                {
                    //Console.Write(fl-- +""+ cl++ + " ");
                    matriz[fl--, cl++] = valor++;
                }
            }*/
            //Matriz Inclinada 9 7 4
            /*int valor = 1;

            //Generar posiciones dentro de la matriz. La primera mitad. 
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int cl = n - 1;
                int fl = n - 1 - j;
                for (int i = 0; i < j + 1; i++)
                {
                    //Console.Write(fl++ +""+ cl-- + " ");
                    matriz[fl++, cl--] = valor++;
                }
            }

            //Generar posiciones dentro de la matriz. La segunda mitad. 
            for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            {
                int cl = j - 1;
                int fl = 0;
                for (int i = 0; i < j; i++)
                {
                    //Console.Write(fl++ +""+ cl-- + " ");
                    matriz[fl++, cl--] = valor++;
                }
            }*/
            //Matriz Inclinada gusanito -----------
            //Primera mitad
            /*for (int i = 0; i < n; i++)
             {
                 if ((i + 1) % 2 != 0)
                 {
                     int fl = i;
                     int cl = 0;
                     for (int j = 0; j < i + 1; j++)
                     {
                         //Console.Write(fl-- + "" + cl++ + " ");
                         matriz[fl--, cl++] = acumulador++;
                     }
                 }
                 if ((i + 1) % 2 == 0)
                 {
                     int fl = 0;
                     int cl = i;
                     for (int j = 0; j < i + 1; j++)
                     {
                         //Console.Write(fl++ + "" + cl-- + " ");
                         matriz[fl++, cl--] = acumulador++;
                     }
                 }
             }

             //Segunda Mitad
             for (int i = 1; i < n; i++)
             {
                 if ((i + 1) % 2 != 0)
                 {
                     int fl = n - 1;
                     int cl = i;
                     for (int j = i; j < n; j++)
                     {
                         //Console.Write(fl-- + "" + cl++ + " ");
                         matriz[fl--, cl++] = acumulador++;
                     }
                 }
                 if ((i + 1) % 2 == 0)
                 {
                     int fl = i;
                     int cl = n - 1;
                     for (int j = i; j < n; j++)
                     {
                         //Console.Write(fl++ + "" + cl-- + " ");
                         matriz[fl++, cl--] = acumulador++;
                     }
                 }
             }*/
            //matriz inclinada gusanito  -------------
            /*for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    int fl = i;
                    int cl = 0;
                    for (int j = 0; j < i + 1; j++)
                    {
                        //Console.Write(fl-- + "" + cl++ + " ");
                        matriz[fl--, cl++] = acumulador++;
                    }
                }
                if ((i + 1) % 2 != 0)
                {
                    int fl = 0;
                    int cl = i;
                    for (int j = 0; j < i + 1; j++)
                    {
                        //Console.Write(fl++ + "" + cl-- + " ");
                        matriz[fl++, cl--] = acumulador++;
                    }
                }
            }

            //Segunda Mitad
            for (int i = 1; i < n; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    int fl = n - 1;
                    int cl = i;
                    for (int j = i; j < n; j++)
                    {
                        //Console.Write(fl-- + "" + cl++ + " ");
                        matriz[fl--, cl++] = acumulador++;
                    }
                }
                if ((i + 1) % 2 != 0)
                {
                    int fl = i;
                    int cl = n - 1;
                    for (int j = i; j < n; j++)
                    {
                        //Console.Write(fl++ + "" + cl-- + " ");
                        matriz[fl++, cl--] = acumulador++;
                    }
                }
            }

           //Matriz reloj
           /* double mitad = (double)n / 2;
            int x = 0;
             for(int fila = 0; fila < n; fila++)
             {
                for (int columna = x; columna < n - x; columna++)
                {
                    matriz[fila, columna] = acumulador++;
                }
                if(fila+1<mitad)
                {
                    x++;
                }
                else
                {
                    if(fila+1>mitad)
                    {
                        x--;
                    }
                }
             }*/
            //Matriz inclinada gusanito 

            /*for (int j = 0; j < n; j++)
            {
                int cl = n - 1 - j;
                int fl = n - 1;
                for (int i = 0; i < j + 1; i++)
                {
                    //Console.Write(fl-- +""+ cl++ + " ");
                    matriz[fl--, cl++] = contador++;
                }
            }

            // Segunda mitad 

            for (int j = n - 1; j >= 0; j--)
            {
                int cl = 0;
                int fl = j - 1;
                for (int i = 0; i < j; i++)
                {
                    //Console.Write(fl-- +""+ cl++ + " ");
                    matriz[fl--, cl++] = contador++;
                }
            }
            */
            //Matriz reloj

            /*for(int fila = n-1; fila > 0; fila--)
            {
                for(int columna = fila; columna >= n - fila - 1; columna--)
                {
                    matriz[fila, columna] = contador++;
                }
            }
            for (int fila = (n / 2) - 1; fila >= 0; fila--)
            {
                for(int columna = n-fila-1   ; columna >= fila; columna--)
                {
                    matriz[fila, columna] = contador++;
                }
            }*/

            //Fibonacci
            /*Console.WriteLine("INGRESE NUMERO HASTA DONDE FINALIZA");
            int fin = int.Parse(Console.ReadLine());

            int contador2 = 1;
            int auxiliar = 0;

            for (int i = 0; contador2 < --fin; i++)
            {
                int temp = contador2 + auxiliar;

                auxiliar = contador2;

                contador2 = temp;

                Console.Write(temp + " ");
            }*/
            //Espiral en X 
            /*
            int n, contador = 1;
            Console.Write("Ingresa el tamaño de la matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            //primera columna
            for (int i = 0; i < n; i++)
            {
                matriz[i, 0] = contador;
                contador++;
            }

            //abajo: derecha a izquierda
            for (int i = 1; i < n; i++)
            {
                matriz[n - 1, i] = contador;
                contador++;
            }

            //segunda columna
            for (int i = n - 2; i >= 0; i--)
            {
                matriz[i, n - 1] = contador;
                contador++;
            }

            //arriba: izquierda a derecha
            for (int i = n - 2; i >= 1; i--)
            {
                matriz[0, i] = contador;
                contador++;
            }

            //diagonal
            for (int i = 1; i <= n - 2; i++)
            {
                for (int j = 1; j <= n - 2; j++)
                {
                    if (i == j)
                    {
                        matriz[i, j] = contador;
                        contador++;
                    }
                }
            }
            //segunda diagonal
            for (int i = 1; i <= n - 2; i++)
            {
                for (int j = 1; j <= n - 2; j++)
                {
                    if ((i + j) == n - 1)
                    {
                        if (matriz[i, j] == matriz[n - 1 - ((n - 1) / 2), n - 1 - ((n - 1) / 2)])
                        {
                            matriz[i, j] = matriz[i, j];
                        }
                        else
                        {
                            matriz[i, j] = contador;
                            contador++;
                        }
                    }
                }
            }

            //mostrar
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
        }

        // TAREA 01: MUESTRA LA LONGITUD DEL TEXTO: "ESTAMOS CREANDO, ESTAMOS SOÑANDO... . .!"
        public static int LongitudCadena(string msg)
        {
            return msg.Length;
        }
        // TAREA 02: DESMENUZA EL STRING "Programndo... Ando " Mostrandolo por pantalla caracter por caracter
        public static void DesmenuzaCadena(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i] + " ");
            }
        }
        /*
        // TAREA 03: INVERTIR EL TEXTO "ANITA LAVA LA TINA"
        */
        public static string InvertirTexto(string texto)
        {
            string inverso = "";
            for (int i = texto.Length - 1; i >= 0; i--) // Total de caracteres --> 0
            {
                inverso += texto[i];
            }
            return inverso;
        }
        /*
         * TAREA 04 ELIMINA LOS ESPACIOS DEL TEXTO " MI MUNDO, LA PROGRAMACION DE COMPUTADORES..."
         */
        public static string EliminaBlancos(string texto)

        {
            string txt = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    txt += texto[i];
                }
            }
            return txt;

            // return texto.Replace(" ", "");
        }
        /*
         * TAREA 05: CUENTA LAS VOCALES Y LAS CONSONANTES DEL STRING "EN PANDEMIA POR UN MURCIELAGO..." 
         * OJO CON LOS ESPACIOS
         */
        public static void CuentaVocalesConsonantes(string texto)
        {
            string vocales = "aeiouAEIOUáéióúÁÉÍÓÚ";
            string consonantes = "bcdfghjklmnñpqrstvwxyzBCDFGHJKLMNÑPQRSTVWXYZ";
            int gtyVocales = 0, gtyConsonantes = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (vocales.Contains(texto[i]))
                    gtyVocales++;
                if (consonantes.Contains(texto[i]))
                    gtyConsonantes++;
            }
            Console.WriteLine("Cantidad Vocales = " + gtyVocales);
            Console.WriteLine("Cantidad Consonantes = " + gtyConsonantes);
        }
        /*
         * TAREA 06: DIVIDE LA CADENA DE TEXTO "Si no duele, no te estas esforzando" en dos partes "S no duele", "No te estas esforzando" }
         * para posteriormente concaternarlas y mostrarlas de nuevo
         */
        public static void DivideConcatena(string texto, string divisor)
        {
            // string[] partes = texto.Split(','); // se necesita conocer arrays

            string parte1 = "", parte2 = "";
            int posicion = 0;
            posicion = texto.IndexOf(divisor); // encuentra primera posición del divisor

            parte1 = texto.Substring(0, posicion) + divisor;
            Console.WriteLine(parte1);

            parte2 = texto.Substring(posicion + 1);
            Console.WriteLine(parte2);

            texto = parte1 + parte2;
            Console.WriteLine(texto);

        }
        /*
         * TAREA 07: TRANSFORMA LA CADENA DE TEXTO "seguimos programando " a MAYUSCULAS
         * GUARDA EL VALOR EN LA VARIABLE Y POSTERIORMENTE CONVIERTELA D ENUEVO A MINUSCULAS
         */
        public static void MayusculasMinusculas(string texto)
        {
            string mayusculas = texto.ToUpper();
            Console.WriteLine(mayusculas);

            string minusculas = mayusculas.ToLower();
            Console.WriteLine(minusculas);
        }
        /*
         * TAREA 08: COMPARA SI EL STRING "Java" es igual que el string "JavaScript".
         */
        public static bool ComparaCadenas(string texto1, string texto2)
        {
            // return texto1 == texto2;  // el mas rapido
            //return texto1.Equals(texto2); //  la mas eficiente, mas util.
            //asi se compara cadenas 
            if (texto1.Length == texto2.Length)
            {
                for (int i = 0; i < texto1.Length; i++)
                {
                    if (texto1[i] != texto2[i])
                        return false;
                }
                return true;
            }
            else
                return false;
        }
        /*
        * TAREA 09: SOBRE LA CADENA DE TEXTO "Le ezefete Ene bejebe cede meñene e le mer selede pere lever le felede enerenjede
        * sustituye y remplaza todas las vocales e por la vocal a y mire el resultado
        */
        public static string ReemplazaE(string texto)
        {
            return texto.Replace("e", "a").Replace("E", "A");
        }
        /*
       * TAREA 10 transforma los caracteres del string "ABCD abcd" a codigo ASCII e imprimelos en la pantalla
       */
        public static void CodigoASCII(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                // usar el CAST, el INT de un CHAR representa el codigo ASCII
                Console.WriteLine(texto[i] + "    " + (int)texto[i]);
            }
        }
        /*
         * TAREA11 escribir un metodo que dado un objeto de la clase string cuente diferentes tipos de caracteres.
         * En particular, el metodo debera imorimir el numero de letras, digitos y espacios en blanco de la cadena,
         * intenta hacer un programa que escriba el conteo (por ejemplo 
         */
        public static void CuentaCaracteres(string texto)
        {
            string letras = "aeiouAEIOUáéióúÁÉÍÓÚbcdfghjklmnñpqrstvwxyzBCDFGHJKLMNÑPQRSTVWXYZ";
            string digitos = "0123456789";
            string especiales = " .,?¡!¿";
            int gtyletras = 0, gtydigitos = 0, gtyespeciales = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (letras.Contains(texto[i]))
                    gtyletras++;
                if (digitos.Contains(texto[i]))
                    gtydigitos++;
                if (especiales.Contains(texto[i]))
                    gtyespeciales++;
            }
            Console.WriteLine("Cantidad letras = " + gtyletras);
            Console.WriteLine("Cantidad digitos = " + gtydigitos);
            Console.WriteLine("cantidad de especiales = " + gtyespeciales);
        }
        public static void PrimeraMatriz()
        {
            int n = 0;
            while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7))
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());
            }

            

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;




            int[,] matriz = new int[n, n];

            do
            {
                if (auxiliar == 0)
                {
                    matriz[0, i++] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[n - 1, j--] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);

            int r, s;
            r = 0;     //controla columnas
            s = n - 1;
            i = n - 2;
            j = 1;

            int aux = 0;

            while (contador <= n * n)
            {
                if (j == n - 1 || j == 0)
                {
                    s--;
                    if (j == n - 1)
                    {
                        //j--;
                        j = n - 2;
                    }
                    if (j == 0)
                    {
                        //j++; 
                        j = 1;
                    }
                }
                if (i == 0 || i == n - 1)
                {
                    r++;
                    if (i == 0)
                    {
                        //i++;
                        i = 1;
                    }
                    if (i == n - 1)
                    {
                        //i--;
                        i = n - 2;
                    }
                }
                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[j++, s] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[i--, r] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }
                }
                else
                {
                    if (auxiliar == 0)
                    {
                        auxiliar = 1;
                        matriz[i++, r] = contador++;
                    }
                    else
                    {
                        auxiliar = 0;
                        matriz[j--, s] = contador++;
                    }
                    if (j == 0)
                    {
                        aux = 0;
                    }
                }
            }


            // imprimir matriz

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void SegundaMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;




            int[,] matriz = new int[n, n];

            do
            {
                if (auxiliar == 0)
                {
                    matriz[0, j--] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[n - 1, i++] = contador++;
                    auxiliar = 0;
                }
            } while (contador <= n * 2);

            int r, s;
            r = n - 1;     //controla columnas
            s = 0;
            i = 1;
            j = n - 2;

            int aux = 0;
            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s++;
                    if (i == n - 1)
                    {
                        i--;
                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r--;
                    if (j == n - 1)
                    {
                        j--;
                        auxiliar = 0;

                    }
                    if (j == 0)
                    {
                        j++;
                        aux = 1;
                        auxiliar = 1;

                    }
                }

                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[i++, s] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[j--, r] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[i--, s] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[j++, r] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }

                }
            }


            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void TerceraMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;

            int[,] matriz = new int[n, n];
            do
            {
                if (auxiliar == 0)
                {
                    matriz[n - 1, i++] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[0, j--] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);
            int r, s;
            r = n - 1;               // controla columnas 
            s = 0;
            i = 1;
            j = n - 2;
            int aux = 0;
            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s++;
                    if (i == n - 1)
                    {
                        i--;
                        aux = 1;

                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r--;
                    if (j == n - 1)
                    {
                        j--;


                    }
                    if (j == 0)
                    {
                        j++;

                    }


                }

                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[j--, r] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[i++, s] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[j++, r] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[i--, s] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }

                }

            }

            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void CuartaMatriz()
        {

            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;

            int[,] matriz = new int[n, n];
            do
            {
                if (auxiliar == 0)
                {
                    matriz[n - 1, j--] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[0, i++] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);
            int r, s;
            r = 0;
            s = n - 1;          // controla columnas
            i = 1;
            j = n - 2;
            int aux = 0;

            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s--;
                    if (i == n - 1)
                    {
                        i--;
                        aux = 1;

                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r++;
                    if (j == n - 1)
                    {
                        j--;


                    }
                    if (j == 0)
                    {
                        j++;

                    }
                }
                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[j--, r] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[i++, s] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[j++, r] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[i--, s] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }
                }
            }
            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void QuintaMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;

            int[,] matriz = new int[n, n];

            do
            {
                if (auxiliar == 0)
                {
                    matriz[i++, 0] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[j--, n - 1] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);
            int r, s;
            r = 0;     //controla columnas
            s = n - 1;
            i = n - 2;
            j = 1;

            int aux = 0;

            while (contador <= n * n)
            {
                if (j == n - 1 || j == 0)
                {
                    s--;
                    if (j == n - 1)
                    {
                        //j--;
                        j = n - 2;
                    }
                    if (j == 0)
                    {
                        //j++; 
                        j = 1;
                    }
                }
                if (i == 0 || i == n - 1)
                {
                    r++;
                    if (i == 0)
                    {
                        //i++;
                        i = 1;
                    }
                    if (i == n - 1)
                    {
                        //i--;
                        i = n - 2;
                    }
                }
                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[s, j++] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[r, i--] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }
                }
                else
                {
                    if (auxiliar == 0)
                    {
                        auxiliar = 1;
                        matriz[r, i++] = contador++;
                    }
                    else
                    {
                        auxiliar = 0;
                        matriz[s, j--] = contador++;
                    }
                    if (j == 0)
                    {
                        aux = 0;
                    }
                }

            }
            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void SextaMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;




            int[,] matriz = new int[n, n];

            do
            {
                if (auxiliar == 0)
                {
                    matriz[j--, 0] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[i++, n - 1] = contador++;
                    auxiliar = 0;
                }
            } while (contador <= n * 2);

            int r, s;
            r = n - 1;     //controla columnas
            s = 0;
            i = 1;
            j = n - 2;

            int aux = 0;
            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s++;
                    if (i == n - 1)
                    {
                        i--;
                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r--;
                    if (j == n - 1)
                    {
                        j--;
                        auxiliar = 0;

                    }
                    if (j == 0)
                    {
                        j++;
                        aux = 1;
                        auxiliar = 1;

                    }
                }

                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[s, i++] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[r, j--] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[s, i--] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[r, j++] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }

                }
            }


            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void SeptimaMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;

            int[,] matriz = new int[n, n];
            do
            {
                if (auxiliar == 0)
                {
                    matriz[i++, n - 1] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[j--, 0] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);
            int r, s;
            r = n - 1;               // controla columnas 
            s = 0;
            i = 1;
            j = n - 2;
            int aux = 0;
            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s++;
                    if (i == n - 1)
                    {
                        i--;
                        aux = 1;

                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r--;
                    if (j == n - 1)
                    {
                        j--;


                    }
                    if (j == 0)
                    {
                        j++;

                    }


                }

                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[r, j--] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[s, i++] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[r, j++] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[s, i--] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }

                }

            }

            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void OctavaMatriz()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingresa un número impar y positivo (3, 5 o 7):");
                n = int.Parse(Console.ReadLine());


            } while ((n % 2 == 0) || (n <= 0) || (n != 3 && n != 5 && n != 7));

            int i = 0, j = n - 1;    // controla filas
            int contador = 1;
            int auxiliar = 0;

            int[,] matriz = new int[n, n];
            do
            {
                if (auxiliar == 0)
                {
                    matriz[j--, n - 1] = contador++;
                    auxiliar = 1;
                }
                else if (auxiliar == 1)
                {
                    matriz[i++, 0] = contador++;
                    auxiliar = 0;
                }

            } while (contador <= n * 2);
            int r, s;
            r = 0;
            s = n - 1;          // controla columnas
            i = 1;
            j = n - 2;
            int aux = 0;

            while (contador <= n * n)
            {
                if (i == n - 1 || i == 0)
                {
                    s--;
                    if (i == n - 1)
                    {
                        i--;
                        aux = 1;

                    }
                    if (i == 0)
                    {
                        i++;
                    }
                }
                if (j == n - 1 || j == 0)
                {
                    r++;
                    if (j == n - 1)
                    {
                        j--;


                    }
                    if (j == 0)
                    {
                        j++;

                    }
                }
                if (aux == 0)
                {
                    if (auxiliar == 0)
                    {
                        matriz[r, j--] = contador++;
                        auxiliar = 1;
                    }
                    else if (auxiliar == 1)
                    {
                        matriz[s, i++] = contador++;
                        auxiliar = 0;
                    }
                    if (i == 0)
                    {
                        aux = 1;
                    }

                }
                if (aux == 1)
                {
                    if (auxiliar == 1)
                    {
                        matriz[r, j++] = contador++;
                        auxiliar = 0;
                    }
                    else if (auxiliar == 0)
                    {
                        matriz[s, i--] = contador++;
                        auxiliar = 1;
                    }
                    if (j == n - 1)
                    {
                        aux = 0;
                    }
                }
            }
            //imprimir matriz
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(matriz[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
     

}
    

