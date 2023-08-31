using System;

namespace BancoPiquis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeConta = "";
            double saldo = 1000; 
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Bem-vindo ao Banco Piquis!");
                Console.Write("Digite o nome da conta (a1 ou a2): ");
                nomeConta = Console.ReadLine().ToLower();

                if (nomeConta != "a1" && nomeConta != "a2")
                {
                    Console.WriteLine("Conta não reconhecida. Tente novamente.");
                    continue;
                }

                Console.WriteLine($"Ola, {nomeConta}! Seu saldo atual e de {saldo:C}");

                Console.Write("Digite o nome do beneficiario: ");
                string beneficiario = Console.ReadLine().ToLower();

                if (beneficiario == nomeConta)
                {
                    Console.WriteLine("Nao e possivel transferir para a propria conta.");
                    continue;
                }

                Console.Write("Digite o valor da transferencia: ");
                double valorTransferencia;
                if (!double.TryParse(Console.ReadLine(), out valorTransferencia) || valorTransferencia <= 0)
                {
                    Console.WriteLine("Valor invalido. A transferencia deve ser um valor positivo.");
                    continue;
                }

                if (valorTransferencia > saldo)
                {
                    Console.WriteLine("Saldo insuficiente para realizar a transferencia.");
                    continue;
                }

                if (beneficiario != "a1" && beneficiario != "a2")
                {
                    Console.WriteLine("Beneficiario não encontrado. Transferencia nao realizada.");
                    continue;
                }

     
                saldo -= valorTransferencia;
                Console.WriteLine("Transferencia realizada com sucesso!");
                Console.WriteLine($"Novo saldo: {saldo:C}");

                Console.Write("Deseja sair? (S/N): ");
                if (Console.ReadLine().ToLower() == "s")
                {
                    sair = true;
                }
            }

            Console.WriteLine("Obrigado por usar o Banco Piquis. Até logo!");
        }
    }
}