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
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________");
                Console.WriteLine("\n                         Verificação Triângulos                                ");
                Console.WriteLine("_________________________________________________________________________________");

                triangulo.LerLados();

                if (triangulo.VerificarTriangulo())
                {
                    Console.WriteLine("\n   Os valores informados formam um triângulo");

                    if (triangulo.VerificarEquilatero())
                        Console.WriteLine("\n   O triângulo é equilátero");
                    else if (triangulo.VerificarIsosceles())
                        Console.WriteLine("\n   O triângulo é isósceles");
                    else
                        Console.WriteLine("\n   O triângulo é escaleno");
                    break;
                }
                else
                {
                    ExibirMensagemEmVermelho("\n   Os valores informados não formam um triângulo");
                }
            }

            Console.ResetColor();
        }

        static void ExibirMensagemEmVermelho( string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(mensagem);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ReadLine();
        }
    }    
}