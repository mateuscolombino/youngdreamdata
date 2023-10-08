using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace YoungDreamData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidade_max = 30;

            Console.WriteLine("Bem vindo ao sistema de cadastro de alunos, a capacidade máxima de cada sala de aula é de 30 alunos.");
            Console.WriteLine("Digite as credencias para fazer login no sistema.");
            Console.WriteLine();
            Console.Write("Login:");
            string login = "admin";
            Console.Write("Senha:");
            string senha = "admin333";
            Console.WriteLine();

            while (login != "admin" || senha != "admin333")
            {
                Console.WriteLine("Credencias incorretas. Tente novamente.");
                Console.WriteLine();
                Console.Write("Login:");
                login = Console.ReadLine();
                Console.Write("Senha:");
                senha = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Login autorizado!");
            Console.WriteLine();
            Room[] room1 = new Room[capacidade_max];

            Console.Write("Quantos alunos serão registrados:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1;i<= quantidade; i++)
            {
                Console.WriteLine("Id: " + (i));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Endereço: ");
                string endereço = Console.ReadLine();
                Console.Write("Nome do responsável: ");
                string nomepais = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Telefone de contato: ");
                double telefone = double.Parse(Console.ReadLine());

                room1[i + 1] = new Room { Nome = nome, Sexo = sexo, Endereço = endereço, NomePais = nomepais, Idade = idade, Email = email, Telefone = telefone};

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista de alunos da sala 1:");

            int vagas = 0;
            
            for(int i = 1; i< capacidade_max; i++)
            {
                if (room1[i] != null)
                {
                    Console.WriteLine(room1[i]);
                }
                else vagas++;
            }
            Console.WriteLine("Número de vagas restantes:" + vagas);
        }
    }
}