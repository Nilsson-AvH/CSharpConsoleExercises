// See https://aka.ms/new-console-template for more information

using System;

namespace compraRestaurante
{
    class Restaurant
    {
        // Constructor
        public Restaurant() 
        {
            precioB = 1.8;
            precioH = 4;
            precioP = 2.2;
        }

        // Attribs
        private double precioB;
        private double precioH;
        private double precioP;

        // Getter and Setter methods
        public double getPrecioB()
        {
            return precioB; 
        }
        public double getPrecioH() 
        {
            return precioH;
        }
        public double getPrecioP() 
        {
            return precioP;
        }
        // Methods
        public double aPagar(int canB, int canH, int canP) 
        {
            this.precioB = precioB * canB;
            this.precioH = precioH * canH;
            this.precioP = precioP * canP;

            return precioB + precioH + precioP;
        }

    }
    class Program
    {
        // Constructor

        // Attribs

        // Getter and Setter methods

        // Methods

        // Main method
        static void Main(string[] args)
        {
            int cantBebidas, cantHamburguesas, cantPapas;
            Restaurant precioLista = new Restaurant();
            Console.WriteLine("+-----------------------------------+\n|                                   |\n| Super Restaurante el Nicho Feliz. |\n|                                   |\n+-----------------------------------+\n\n");
            Console.WriteLine("Precios al Publico:\n\nCualquier bebida vaso 350 ml: " + precioLista.getPrecioB() + " euro\nHamburguesa con queso doble carne: " + precioLista.getPrecioH() + " euro\nPorcion de papas a la francesa: " + precioLista.getPrecioP() + " euro\n");
            
            Console.WriteLine($"¿Cuantas bebidas quiere?: ");
            cantBebidas = int.Parse(Console.ReadLine());
            Console.WriteLine($"¿Cuantas hamburguesas quiere?: ");
            cantHamburguesas = int.Parse(Console.ReadLine());
            Console.WriteLine($"¿Cuantas porciones de papas quiere?: ");
            cantPapas = int.Parse(Console.ReadLine());

            Restaurant pedido = new Restaurant();
            Console.WriteLine("\nEl costo total de su pedido es de: "+(pedido.aPagar(cantBebidas, cantHamburguesas, cantPapas))+" euro."); ;
        }
    }
}