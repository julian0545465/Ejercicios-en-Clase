using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicios_Clases
    {


        //1.Plantear un programa que permita jugar a los dados. Las reglas de juego son: se tiran tres dados si los tres salen con el mismo valor mostrar un mensaje que "ganó", sino "perdió".Lo primero que hacemos es identificar las clases, luego los atributos y los métodos de cada clase.

        static void Main(string[] args)
        {

            Sentencia(0);

            static void Sentencia(int l)
            {


                Random dado1 = new Random();
                Console.WriteLine("Dado número uno: " + $"{dado1.Next(1, 6)}");
                Console.WriteLine("");

                Random dado2 = new Random();
                Console.WriteLine("Dado número dos: " + $"{dado2.Next(1, 6)}");
                Console.WriteLine("");

                Random dado3 = new Random();
                Console.WriteLine("Dado número tres: " + $"{dado3.Next(1, 6)}");
                Console.WriteLine("");

                if (dado1 == dado2 || dado2 == dado3)
                {
                    Console.WriteLine("Ganó");
                }
                else
                {
                    Console.WriteLine("Perdió");
                }
            }
        }



            //2.Desarrollar un programa que contenga una clase Persona que tenga como atributos el nombre y la edad(definir las propiedades para poder acceder a dichos atributos). Definir como responsabilidad un método para imprimir.Plantear una segunda clase Empleado que herede de la clase Persona.Añadir un atributo sueldo(y su propiedad) y el método para imprimir su sueldo.Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.

            //static void Main(string[]args)
            //{
            //    Persona persona = new Persona();
            //    persona.Responsabilidad();

            //    Empleado empleado = new Empleado();
            //    empleado.Imprimir();
            //}




            //3.Ejercicio Operaciones, Sumas y Restas

            //static void Suma(int sum)
            //{

            //    SumayResta sumayResta = new SumayResta();
            //    Console.WriteLine("Ingrese el primer valor para la suma: ");
            //    sumayResta.N11 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");

            //    Console.WriteLine("Ingrese el segundo valor para la suma");
            //    sumayResta.N21 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");

            //    int total = (sumayResta.N11 + sumayResta.N21);
            //    Console.WriteLine("El total de la suma: " + total);
            //    Console.WriteLine("");
            //}

            //static void Resta(int rest)
            //{
            //    SumayResta sumayResta = new SumayResta();
            //    Console.WriteLine("Ingrese el primer valor para la resta: ");
            //    sumayResta.N11 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");

            //    Console.WriteLine("Ingrese el segundo valor para la resta");
            //    sumayResta.N21 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");

            //    int total = (sumayResta.N11 - sumayResta.N21);
            //    Console.WriteLine("El total de la resta: " + total);
            //    Console.WriteLine("");

            //}
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Elegir una opción");
            //    Console.WriteLine("");
            //    Console.WriteLine("1. Suma");
            //    Console.WriteLine("2. Resta");

            //    int eleccion = 0;
            //    eleccion = int.Parse(Console.ReadLine());

            //    switch (eleccion)
            //    { 
            //        case 1:
            //            {
            //                Console.WriteLine("");
            //                Suma(0);
            //            }
            //            break;
            //        case 2:
            //            {
            //                Console.WriteLine("");
            //                Resta(0);
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Elección incorrecta");
            //            break;



            //     }  
            //}
        }
}
