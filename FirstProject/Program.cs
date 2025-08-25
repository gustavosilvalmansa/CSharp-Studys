using System;
using System.Globalization;

namespace FirstProject
{
    internal class Program
    {
        // -----------------------------
        // Funções utilitárias matemáticas
        // -----------------------------
        static int MaiorDeTres(int n1, int n2, int n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }

        static double Raiz(double x) => Math.Sqrt(x);

        static void CalcularEquacaoSegundoGrau(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existem raízes reais.");
                return;
            }

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"Delta = {delta}");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }

        // -----------------------------
        // Funções de entrada de dados
        // -----------------------------
        static string LerFrase()
        {
            Console.Write("Digite uma frase: ");
            return Console.ReadLine();
        }

        static int LerInteiro(string mensagem)
        {
            int valor;
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out valor))
                    return valor;

                Console.WriteLine("Valor inválido, tente novamente.");
            }
        }

        static double LerDouble(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                    return valor;

                Console.WriteLine("Valor inválido, tente novamente.");
            }
        }

        // -----------------------------
        // Lógica principal
        // -----------------------------
        static void VerificarParImpar()
        {
            int numero = LerInteiro("Digite um número inteiro: ");
            Console.WriteLine(numero % 2 == 0 ? "Número par" : "Número ímpar");
        }

        static void CalcularRaizesInterativo()
        {
            while (true)
            {
                double valor = LerDouble("Digite um número para calcular a raiz (negativo para sair): ");
                if (valor < 0) break;

                Console.WriteLine($"A raiz de {valor} é {Raiz(valor):F3}");
            }
        }

        static void MostrarSequencia()
        {
            int N = LerInteiro("Digite a quantidade de números a exibir: ");
            for (int i = 0; i < N; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        // -----------------------------
        // Main
        // -----------------------------
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("=== Cálculo de Área de Triângulos ===");
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = LerDouble("A: ");
            x.B = LerDouble("B: ");
            x.C = LerDouble("C: ");
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = LerDouble("A: ");
            y.B = LerDouble("B: ");
            y.C = LerDouble("C: ");
          
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");
            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else if (areaY > areaX)
                Console.WriteLine("Maior área: Y");
            else
                Console.WriteLine("Áreas iguais");
            // Fim do exercício de triângulos




            Console.WriteLine("=== Equação do 2º Grau ===");
            CalcularEquacaoSegundoGrau(1, -3, -4);

            Console.WriteLine("\n=== Verificar Par/Ímpar ===");
            VerificarParImpar();

            Console.WriteLine("\n=== Maior de três números ===");
            int maior = MaiorDeTres(5, 10, 8);
            Console.WriteLine($"Maior: {maior}");

            Console.WriteLine("\n=== Calcular Raízes ===");
            CalcularRaizesInterativo();

            Console.WriteLine("\n=== Sequência de números ===");
            MostrarSequencia();
        }
    }
}
