// See https://aka.ms/new-console-template for more information
using System;

namespace invTresCifras
{
    class InvTresCifras
    {
        // Constructor

        // Attribs
        private int CEN, DEC, UNI, NUM; 

        // Getter and setter methods

        // Methods
        public int superInversor(int numeroAInvertir)
        {
            NUM = numeroAInvertir;
            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;

            return (UNI * 100) + (DEC * 10) + CEN;
        }
    }
    class Program
    {
        // Constructor

        // Attribs

        // Gettter and Setter methods

        // Methods

        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("Programa inversor de numeros:");
            Console.WriteLine("Digite un numero de tres digitos");
            
            InvTresCifras input = new InvTresCifras();

            Console.WriteLine("El numero inverso es: " + input.superInversor(int.Parse(Console.ReadLine())));
        }
    }
}