using System;

namespace calculador_dotenet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, opcao;
            double result;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("-------- Sejam bem-vindos a Calculadora DotNet --------");

            do
            {
                Console.WriteLine("Qual a operação desejada:\n1- Soma\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Sair\n");

                opcao = Convert.ToInt32(Console.ReadLine());

                if(opcao >= 1 && opcao <= 4) { 
                    Console.WriteLine("Digite o Primeiro Número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                }

                switch (opcao){
                    case 1:                
                        result = program.Somar(n1, n2);
                        Console.WriteLine("O resultado da soma é: " + result);
                        break;
                    case 2:
                        result = program.Subtrair(n1, n2);
                        Console.WriteLine("O resultado da subtração é: " + result);
                        break;
                    case 3:
                        result = program.Multiplicar(n1, n2);
                        Console.WriteLine("O resultado da multiplicação é: " + result);
                        break;
                    case 4:
                        result = program.Dividir(n1, n2);
                        Console.WriteLine("O resultado da divisão é: " + result);
                        break;

                    case 5:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida inválida");
                        break;
                }
                Console.WriteLine("\nPressione Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }


        public double Somar (int n1, int n2)
        {
            return n1 + n2;
        }

        public double Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public double Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

    }
}
