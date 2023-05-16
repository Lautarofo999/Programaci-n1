using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)

        {
            int opcion;
            Principal principal = new Principal();
            do
            {
                Console.WriteLine("--------MENU---------");
                Console.WriteLine("Ingrese 1 para Cliente");
                Console.WriteLine("Ingrese 2 para Libro");
                Console.WriteLine("Ingrese 3 para Moto");
                
                opcion = int.Parse(Console.ReadLine());
                principal = new Principal();    
                switch (opcion)

                {
                    case 1:
                        Cliente clienteAgregado = new Cliente();

                        Console.WriteLine("Agrega una persona");
                        Console.WriteLine("Arranca con el dni");
                        clienteAgregado.DNI = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segui con el nombre");
                        clienteAgregado.Nombre = (Console.ReadLine());
                        Console.WriteLine("Segui con el apellido");
                        clienteAgregado.Apellido = (Console.ReadLine());
                        Console.WriteLine("Segui con el gmail");
                        clienteAgregado.Gmail = (Console.ReadLine());
                        Console.WriteLine("Segui con la fecha de nacimiento");
                        clienteAgregado.FechaNacimiento = DateTime.Parse(Console.ReadLine());


                        principal.AltaCliente(clienteAgregado.DNI, clienteAgregado.Nombre, clienteAgregado.Apellido,
                        clienteAgregado.Gmail, clienteAgregado.FechaNacimiento);
                        break;


                    case 2:

                        
                        Libro libroAgregado = new Libro();
                        Console.WriteLine("Agrega un libro");
                        Console.WriteLine("Arranca con el codigo de barra");
                        libroAgregado.ISBN = int.Parse(Console.ReadLine());
                        Console.WriteLine("Arranca con el nombre del libro");
                        libroAgregado.NOMBRE = Console.ReadLine();
                        Console.WriteLine("Arranca con el Autor del libro");
                        libroAgregado.AUTOR = Console.ReadLine();
                        Console.WriteLine("Arranca con el precio del libro");
                        libroAgregado.PRECIO = double.Parse(Console.ReadLine());
                        Console.WriteLine("Arranca con el Stock del libro");
                        libroAgregado.STOCK = int.Parse(Console.ReadLine());
                        principal.AltaLibro(libroAgregado.ISBN, libroAgregado.NOMBRE, libroAgregado.AUTOR,
                        libroAgregado.PRECIO, libroAgregado.STOCK);
                        break;

                    case 3:

                        
                        Moto MotoAgregado = new Moto();


                        Console.WriteLine("Ingrese el codigo de la moto");
                        MotoAgregado.Codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Arranca con el modelo de la moto");
                        MotoAgregado.Modelo = (Console.ReadLine());
                        Console.WriteLine("Arranca con el año de la moto");
                        MotoAgregado.Año = int.Parse(Console.ReadLine());
                        Console.WriteLine("Arranca con la pintura de la moto");
                        MotoAgregado.Pintura = (Console.ReadLine());
                        Console.WriteLine("Arranca con el precio de la moto");
                        MotoAgregado.Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Arranca con el stock de la moto");
                        MotoAgregado.Stock = int.Parse(Console.ReadLine());
                        principal.AltaMoto(MotoAgregado.Codigo, MotoAgregado.Modelo, MotoAgregado.Año,
                        MotoAgregado.Pintura, MotoAgregado.Precio, MotoAgregado.Stock);
                        break;
                  
                }

            }
            while (true);



        }

        
    }
}
