using System;

namespace SistemaDeAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome de usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (usuario == "admin" && senha == "1234")
            {
                Console.WriteLine("Acesso concedido. Bem-vindo ao sistema!");
            }
            else
            {
                Console.WriteLine("Nome de usuario ou senha incorretos. Acesso negado.");
            }
        }
    }
}
