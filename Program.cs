using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial_EEC_2010067
{
    class Program
    {
        static void Main(string[] args)
        {
            /*@author: Erick Escamilla Charco*/
            /*--Examen ordinario de Primer Parcial
             * Asignatura: Programación
             * Periodo: Septiembre-Diciembre 2020.--*/
            char continuar = 'n';
            byte index;
            double[] numeros;
            string[] messages = {"menor", "intermedio", "MAYOR"};
            Console.WriteLine("EXAMEN PRÁCTICO DE 1er Parcial, por Erick Escamilla Charco");
            do {
                index = 0;
                numeros = new double[3];
                Console.WriteLine("####################################################");
                for (int i = 0; i < numeros.Length; i++) {
                    Console.WriteLine("Ingrese el número (con punto decimal) [{0}]: ", i + 1);
                    numeros[i] = Convert.ToDouble(Console.ReadLine());
                }

                // -- Ordenamiento de los datos ingresados por el usuario por Algoritmo de Burbuja (Bubble Sort)
                OrdenamientoBurbuja(numeros);

                // -- Indicar cuál es el mayor, menor e intermedio
                foreach (string messg in messages) {
                    Console.WriteLine("El número {0} es: {1}", messg, numeros[index]);
                    index++;
                }

                Console.WriteLine("\t¿Desea ordenar otros 3 números? [y/n]: ");
                continuar = Console.ReadKey().KeyChar;
            } while(Char.ToLower(continuar).Equals('y'));

            Console.WriteLine("Hasta luego, que tenga un excelente día, gracias por usar BubbleSort App.");
            Console.WriteLine("Presione cualquier tecla para salir del programa.");
            Console.ReadKey();
        } //-- fin método main

        private static void OrdenamientoBurbuja(double[] numeros) {
            Console.WriteLine("Dentro de ordenamiento Burbuja...");
            double pesado = -2;
            // -- Requiere n-1 recorridos completos del array para garantizar ordenamiento completo
            for (int j = 0; j < numeros.Length - 1; j++) {
                // length -1 para evitar comparación ERRONEA por IndexOutOfBounds
                for (int i = 0; i < numeros.Length - 1; i++)
                {
                    if (numeros[i] > numeros[i+1]) {
                        // numeros[i] es el elemento MÁS PESADO
                        pesado = numeros[i];
                        // pesado se debe ir hacia ABAJO
                        // ligero (numeros[i+1]) debe subir [i]
                        numeros[i] = numeros[i + 1];
                        numeros[i+1] = pesado;
                    }
                }
            }
        } // -- fin: ordenamiento por Burbuja

        private static void ShowDoubleArrayContent(double[] numeros) {
            Console.WriteLine("--Mostrando contenido del Arreglo--");
            byte index = 0;
            foreach (double valor in numeros) {
                Console.WriteLine("[{0}] : <{1}>", index, valor);
                index++;
            }
        } //-- fin: showDoubleArrayContent()

    }
}
