namespace SistemaDeAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            int tentativasRestantes = 5;
            
            while (tentativasRestantes > 0)
            {
                Console.Write("Digite o nome de usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                if (usuario == "admin" && senha == "1234")
                {
                    Console.WriteLine("Acesso concedido. Bem-vindo ao sistema!");
                    break;
                }
                else
                {
                    tentativasRestantes--;
                    Console.WriteLine($"Nome de usuário ou senha incorretos. {tentativasRestantes} tentativas restantes.");
                }
            }

            if (tentativasRestantes == 0)
            {
                Console.WriteLine("Número máximo de tentativas excedido. Acesso bloqueado.");
            }
        }
    }
}