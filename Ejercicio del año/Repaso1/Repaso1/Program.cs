using System.ComponentModel.Design;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1)
            Console.Write("Ingrese el nombre del usuario: ");
            string usuario = Console.ReadLine();
            int clavecorrecta = 667788;
            int i = 0;
            
            do
            {
                Console.Write("Ingrese la clave: ");
                i = int.Parse(Console.ReadLine());
                if (i == clavecorrecta)
                {
                    Console.Write("El usuario ingreso a la cuenta \n");
                }
                else
                {
                    Console.Write("La clave es incorrecta \n");
                }

            }
            while (i != clavecorrecta);
            {
                
            }

            // 2,3)
            double Numneg = 0;
            double numero = 0;
            double prom = 0;
            int cant = 0;
            do
            {
                Console.Write("Ingrese el numero del pedido: ");
                numero = double.Parse(Console.ReadLine());
                
                if (numero >= 0)
                {
                    Console.Write("El numero del pedido es: " + numero + "\n");
                }
                else
                {
                    Console.Write("El número no puede ser negativo \n");
                    Numneg = Numneg + numero;
                    cant = cant + 1;

                }

            }
            while (numero < 0);
            {

            }
            prom = Numneg / cant;
            Console.Write("El promedio de numeros negativos es: " + prom + "\n");

            // 4,5)

            double numero1 = 0;
            double cant_numero1 = 0;
            double prom1 = 0;
            int cant1 = 0;
            do
            {
                Console.Write("Ingrese un numero mayor a 3 cifras: ");
                numero1 = double.Parse(Console.ReadLine());

                if (numero1 >= 1000)
                {
                    Console.Write("El numero del pedido es: " + numero1 + "\n");
                    cant_numero1 = cant_numero1 + numero1;
                    cant1 = cant1 + 1;
                }
                else
                {
                    Console.Write("El número no es mayor a 3 cifras \n");
                    cant_numero1 = cant_numero1 + numero1;
                    cant1 = cant1 + 1;

                }

            }
            while (numero1 <1000);
            {

            }
            prom1 = cant_numero1 / cant1;
            Console.Write("El promedio es: " + prom1);


            Console.ReadKey();



        }
    }
}