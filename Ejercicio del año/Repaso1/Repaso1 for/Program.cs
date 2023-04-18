using System.ComponentModel;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1)
            int num1 = 0;
            int suma1 = 0;
            for (int i = 0; i < 5; i ++)
            {
                Console.Write("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());
                suma1 = suma1 + num1;

            }
            Console.Write("La suma de los 5 numeros es: " + suma1 + "\n");

            // 2)
            int prom = 0;
            int num2 = 0;
            int suma2 = 0;
            for (int u = 0; u < 8; u++)
            {
                Console.Write("Ingrese un numero: ");
                num2 = int.Parse(Console.ReadLine());
                suma2 = suma2 + num2;

            }
            prom = suma2 / 8;
            Console.Write("El promedio de los 8 numeros es: " + prom + "\n");

            // 3)
            double costo = 0;
            double total = 0;
            for (int o = 0; o < 5; o++)
            {
                Console.Write("Ingrese el costo del producto ");
                costo = double.Parse(Console.ReadLine());
                total = total + costo;

            }
            Console.Write("El total de la factura es: " + total  + "\n");

            // 4)
            int mayor = 0;
            int num3 = 0;
            for (int p = 0; p < 8; p++)
            {
                Console.Write("Ingresar 8 numeros para una lista ");
                num3 = int.Parse(Console.ReadLine());
                if (num3 > mayor)
                {
                    mayor = num3;

                }

            }
            Console.Write("El mayor número de la lista es: " + mayor + "\n");

            // 5)
            
            List<string> cliente = new List<string>();
            List<int> total = new List<int>();

            int venta = 0;
            string cliente_max;

            for (int y = 0; y < 5; y++)
            {
                Console.Write("Ingrese el nombre del cliente: ");
                cliente.Add(Console.ReadLine());
                Console.Write("Ingrese el total gastado del cliente: ");
                total.Add(int.Parse(Console.ReadLine()));


            }
            venta = total.IndexOf(total.Max());

            Console.Write("El maximo es: " + total.Max() + "\n");
            Console.Write("El cliente con el mayor costo es : " + cliente[venta] + "\n");
            Console.Write(cliente + "\n");
            Console.Write(total);
            */



            Console.ReadKey();

        }
    }
}
