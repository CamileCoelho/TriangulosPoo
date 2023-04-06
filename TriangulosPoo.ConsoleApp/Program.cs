namespace TriangulosPoo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Triangulo triangulo = new Triangulo();

            while (true)
            {
                ImprimirTitulo();

                LerImputLados(triangulo);

                if (triangulo.VerificarTriangulo())
                {
                    ExibirMensagem("\n   Os valores informados formam um triângulo. ", ConsoleColor.DarkGreen);

                    if (triangulo.VerificarEquilatero())
                        Console.WriteLine("\n   O triângulo é equilátero! ");
                    else if (triangulo.VerificarIsosceles())
                        Console.WriteLine("\n   O triângulo é isósceles! ");
                    else
                        Console.WriteLine("\n   O triângulo é escaleno! ");

                    break;
                }
                else
                {
                    ExibirMensagem("\n   Os valores informados não formam um triângulo. Tente novamente...", ConsoleColor.DarkRed);
                    Console.ReadLine();
                }
            }

            Console.ResetColor();
        }

        private static void LerImputLados(Triangulo triangulo)
        {
            bool valido;
            do
            {
                Console.Write("\n   Digite o comprimento do primeiro lado do triângulo: ");
                valido = double.TryParse(Console.ReadLine(), out triangulo.lado1);
                if (!valido)
                {
                    ExibirMensagem("\n   Valor inválido. Digite apenas números. Tente novamente...", ConsoleColor.DarkRed);
                }
            } while (!valido);
            do
            {
                Console.Write("\n   Digite o comprimento do segundo lado do triângulo: ");
                valido = double.TryParse(Console.ReadLine(), out triangulo.lado2);
                if (!valido)
                {
                    ExibirMensagem("\n   Valor inválido. Digite apenas números. Tente novamente...", ConsoleColor.DarkRed);
                }
            } while (!valido);
            do
            {
                Console.Write("\n   Digite o comprimento do terceiro lado do triângulo: ");
                valido = double.TryParse(Console.ReadLine(), out triangulo.lado3);
                if (!valido)
                {
                    ExibirMensagem("\n   Valor inválido. Digite apenas números. Tente novamente...", ConsoleColor.DarkRed);
                }
            } while (!valido);
        }
        private static void ImprimirTitulo()
        {
            Console.Clear();
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("\n                         Verificação Triângulos                                ");
            Console.WriteLine("_________________________________________________________________________________");
        }
        static void ExibirMensagem( string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }     
       
    }    
}