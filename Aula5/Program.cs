using Biblioteca;
using System;
using System.IO;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMenu = true;

            string menu = "1 - Inserir\n2 - Consultar\n3 - Gerar Arquivo\n4 - Sair";

            while (isMenu)
            {
                Console.WriteLine(menu);
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        ListAll();
                        break;
                    case 3:
                        GerarArquivo();
                        break;
                    case 4:
                        isMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            Console.ReadKey();
        }

        private static void Add()
        {
            Random random = new Random();
            int id = random.Next(1, 1000);
            Console.WriteLine($"Id: {id}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            new ClienteService().Add(id, nome, telefone, salario, endereco);
        }

        private static void ListAll()
        {
            foreach (var item in new ClienteService().ListAll())
            {
                Console.WriteLine(item + "\n-----------------------------");
            }
        }

        private static void GerarArquivo()
        {
            string caminho = @"C:\Users\Marcelo\Desktop\ralatorio-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".txt";
            StreamWriter writer = new StreamWriter(caminho);
            foreach (var item in new ClienteService().ListAll())
            {
                writer.WriteLine(item + "\n-----------------------------");
            }
            writer.Close();
        }
    }
}
