using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1,2)
            int cont = 0;
            double prom = 0;
            int num1 = 1;
            int suma = 0;
            while (num1 != 0 && num1 > 0)
            {
                Console.Write("Ingrese un valor, para sumarlo ingrese 0: \n");
                num1 = int.Parse(Console.ReadLine());

                suma = suma + num1;
                cont = cont + 1;

            }
            prom = suma / cont;
            Console.Write("La suma de todos los numeros ingresado es: " + suma + "\n");
            Console.Write("El promedio de la suma de los valores es: " + prom);
            */

            
            /*
            //3)
            string nombres;
            List<string> list_nombres = new List<string>();
            while (true)
            {
                Console.Write("Si no ingresa nada el sistema dara los nombres dados y finalizara el programa \n");
                Console.Write("Ingrese el nombre del ususario: ");
                nombres = (Console.ReadLine());
                if (string.IsNullOrEmpty(nombres))
                {
                    Console.Write("Los nombres ingresados son: " );
                    foreach (string nombre in list_nombres)
                    {
                        Console.Write(nombre + " - ");
                    }
                    break;

                }
                else
                {
                    list_nombres.Add(nombres);
                }

            }
            
            // 4)
            int cant = 0;
            int costo = 1;
            int total = 0;
            Console.Write("Si quiere saber el costo total de la compra ingrese 0: \n");
            Console.Write("Ingrese el costo de los productos que quiere comprar: \n");
            while (costo != 0)
            {
                costo = int.Parse(Console.ReadLine());
                total = total + costo;
            }
            Console.Write("El total de los productos es: " + total);
            */

            // 5)
            int total = 0;
            int costo = 0;
            int productos = 0;
            Console.Write("Ingrese la cantidad de productos comprados: ");
            productos = int.Parse(Console.ReadLine());
            for (int i = 1; i != productos + 1; i++)
            { 
                Console.Write("Ingrese el precio del producto " + i + "\n");
                costo = int.Parse(Console.ReadLine());
                total = total + costo;

            }
            Console.Write("El total de los productos es: " + total);


        }
    }
}