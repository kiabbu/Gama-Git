using System;

namespace vs_first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");
            Console.WriteLine("Olá {0}, você tem {1} anos", nome, idade);

            if (idade > 25){
                Console.WriteLine("Nossa você é velho!");
            }else{            
                Console.WriteLine("Nossa você é novo!");
            }
        }
    }
}
