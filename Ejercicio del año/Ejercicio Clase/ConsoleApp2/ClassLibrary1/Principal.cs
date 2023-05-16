using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Libro> ListaLibro = new List<Libro>();
        List<Moto> Listaproducto = new List<Moto>();
        public void AltaCliente(int dni, string nombre, string apellido,string gmail, DateTime fechaNac)
        {
            Cliente clienteNuevo = new Cliente();
            clienteNuevo.id = clienteNuevo.id + 1;
            clienteNuevo.DNI = dni;
            clienteNuevo.Nombre = nombre;
            clienteNuevo.Apellido = apellido;
            clienteNuevo.Gmail = gmail;
            clienteNuevo.FechaNacimiento = fechaNac;

            ListaClientes.Add(clienteNuevo);
        }
        public void AltaLibro(int isbn, string nombre, string autor, double precio, int stock)
        {
            Libro LibroNuevo = new Libro();
            LibroNuevo.ISBN = isbn;
            LibroNuevo.NOMBRE = nombre;
            LibroNuevo.AUTOR = autor;
            LibroNuevo.PRECIO = precio;
            LibroNuevo.STOCK = stock;


        }
        public void AltaMoto(int codigo, string modelo, int año, string pintura, double precio, int stock)
        {
            Moto MotoNuevo = new Moto();
            MotoNuevo.Codigo = codigo;
            MotoNuevo.Modelo = modelo;
            MotoNuevo.Año = año;
            MotoNuevo.Pintura = pintura;
            MotoNuevo.Precio = precio;
            MotoNuevo.Stock = stock;

        }
     
    }
}
