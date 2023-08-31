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

   
            Console.WriteLine($"Nome completo em maiusculo: {nomeCompleto.ToUpper()}");
            Console.WriteLine($"Nome completo em minusculo: {nomeCompleto.ToLower()}");

           
            int numCaracteres = nomeCompleto.Replace(" ", "").Length;
            Console.WriteLine($"Numero de caracteres no nome completo: {numCaracteres}");

            int idade;
            if (int.TryParse(idadeStr, out idade))
            {
             
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
