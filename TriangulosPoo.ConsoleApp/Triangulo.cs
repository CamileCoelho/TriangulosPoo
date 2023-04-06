using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulosPoo.ConsoleApp
{
    internal class Triangulo
    {
        double lado1, lado2, lado3;

        public void LerLados()
        {
            Console.Write("\n   Digite o comprimento do primeiro lado do triângulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("\n   Digite o comprimento do segundo lado do triângulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.Write("\n   Digite o comprimento do terceiro lado do triângulo: ");
            lado3 = double.Parse(Console.ReadLine());
        }
        public bool VerificarTriangulo()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarEquilatero()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarIsosceles()
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
