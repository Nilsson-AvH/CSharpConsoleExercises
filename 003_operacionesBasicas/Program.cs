// See https://aka.ms/new-console-template for more information
using System;

namespace operacionesBasicas
{
    class Operaciones
    {
        // Constructor

        // Attribs

        // Getter and Setter methods

        // Methods
        public int superSuma(int numUno, int numDos)
        {
            return numUno+numDos;
        }
        public int superResta(int numUno, int numDos) 
        { 
            return numUno-numDos;
        }
        public int superMultiplicacion(int numUno, int numDos) 
        { 
            return numUno*numDos;
        }
        public int superDivision(int numUno, int numDos)
        {
            return numUno/numDos;
        }
        public int superResiduo(int numUno, int numDos)
        {
            return (numUno%numDos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno, numeroDos;
            Console.WriteLine("Operaciones básicas con dos numeros enteros.");
            Console.WriteLine("Digite el numero uno: ");
            numeroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero uno: ");
            numeroDos = int.Parse(Console.ReadLine());

            Operaciones operaciones = new Operaciones();

            Console.WriteLine("La suma de los numeros es: " + operaciones.superSuma(numeroUno, numeroDos));
            Console.WriteLine("La resta de los numeros es: " + operaciones.superResta(numeroUno, numeroDos));
            Console.WriteLine("La multiplicacion de los numeros es: " + operaciones.superMultiplicacion(numeroUno, numeroDos));
            Console.WriteLine("La division de los numeros es: " + operaciones.superDivision(numeroUno, numeroDos));
            Console.WriteLine("El residuo de los numeros es: " + operaciones.superResiduo(numeroUno, numeroDos));
        }
    }
}


