using System;

namespace InformacoesUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            string idadeStr = Console.ReadLine();

            // Exibir o nome completo em maiúsculo e minúsculo
            Console.WriteLine($"Nome completo em maiusculo: {nomeCompleto.ToUpper()}");
            Console.WriteLine($"Nome completo em minusculo: {nomeCompleto.ToLower()}");

            // Contar o número de caracteres no nome completo (excluindo espaços em branco)
            int numCaracteres = nomeCompleto.Replace(" ", "").Length;
            Console.WriteLine($"Numero de caracteres no nome completo: {numCaracteres}");

            // Converter a idade para um número inteiro com tratamento de erro
            int idade;
            if (int.TryParse(idadeStr, out idade))
            {
                // Calcular o ano de nascimento e o ano em que o usuário fará 100 anos
                int anoAtual = DateTime.Now.Year;
                int anoNascimento = anoAtual - idade;
                int anoCemAnos = anoNascimento + 100;

                Console.WriteLine($"Ano de nascimento calculado: {anoNascimento}");
                Console.WriteLine($"Voce fara 100 anos em: {anoCemAnos}");
            }
            else
            {
                Console.WriteLine("Idade invalida. Certifique-se de inserir um numero válido.");
            }
        }
    }
}