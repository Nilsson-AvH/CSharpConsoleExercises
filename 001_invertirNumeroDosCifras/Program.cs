// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

namespace invertirNumeroDosCifras
{
    class InvertirNumeros
    {
        // Constructors
        
        // Attribs
        private int AUX, DEC, UNI;

        // Getter and Setter methods

        // Methods
        public void Invertir(int numeroAInvertir)
        {
            DEC = numeroAInvertir/10;
            UNI = numeroAInvertir%10;
            AUX = (UNI * 10) + DEC;

            Console.WriteLine( "El numero " +numeroAInvertir+ " invertido es: " + AUX );
        }
    }
    class Program
    {
        // Constructors

        // Attribs

        // Getter and Setter methods

        // Methods

        // Main Method
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Ingrese un numero de dos cifras:");
            InvertirNumeros elNumero = new InvertirNumeros();
            try
            {
                input=int.Parse(Console.ReadLine());
                if (input >= 10 && input <= 99) elNumero.Invertir(input);
                else Console.WriteLine("Inserte un numero de dos cifras.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Caracteres invalidos: " + ex.Message);
            }
            
        }
    }
}