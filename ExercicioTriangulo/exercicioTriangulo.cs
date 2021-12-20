using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatro
{
    class ExercicioTriangulo
    {
        public static void ExecutarExercicioTriangulo()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.LadoA = double.Parse(Console.ReadLine());
            x.LadoB = double.Parse(Console.ReadLine());
            x.LadoC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.LadoA = double.Parse(Console.ReadLine());
            y.LadoB = double.Parse(Console.ReadLine());
            y.LadoC = double.Parse(Console.ReadLine());

            
            Console.WriteLine("A área de X é: " + x.CalcularAreaTriangulo().ToString("F4"));
            Console.WriteLine("A área de Y é: " + y.CalcularAreaTriangulo().ToString("F4"));


            
        }
    }
}