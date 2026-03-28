using System;

namespace JogoEducativo.Portugues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração do console
            Console.Title = "Jogo Educativo - Português";
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Cabeçalho
            Console.WriteLine("============================================================");
            Console.WriteLine(" JOGO EDUCATIVO - PORTUGUES ");
            Console.WriteLine(" Aprenda a diferenciar VOGAIS e CONSOANTES ");
            Console.WriteLine("============================================================");

            // Instruções
            Console.WriteLine("\nCOMO JOGAR:");
            Console.WriteLine("1. Digite UMA letra do alfabeto");
            Console.WriteLine("2. O programa dirá se é vogal ou consoante");
            Console.WriteLine("3. Digite 'sair' para encerrar o jogo");
            Console.WriteLine("4. Digite 'ajuda' para ver esta mensagem novamente");

            // Variáveis de controle
            int totalJogadas = 0;
            int acertos = 0;

            // Loop principal
            while (true)
            {
                // Entrada do usuário
                Console.Write("\nDigite uma letra: ");
                string? entrada = Console.ReadLine();

                // Validação de entrada vazia
                if (string.IsNullOrWhiteSpace(entrada))
                    continue;

                string comando = entrada.ToLower().Trim();

                // Comando SAIR
                if (comando == "sair")
                    break;

                // Comando AJUDA
                if (comando == "ajuda")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nAJUDA:");
                    Console.WriteLine("Digite UMA letra de A a Z");
                    Console.WriteLine("Vogais são: A, E, I, O, U");
                    Console.WriteLine("Digite 'sair' para encerrar");
                    Console.ResetColor();
                    continue;
                }

                // Validação: 1 caractere e letra
                if (comando.Length != 1 || !char.IsLetter(comando[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Digite apenas UMA letra do alfabeto!");
                    Console.ResetColor();
                    continue;
                }

                // Processamento
                totalJogadas++;
                char letra = comando[0];

                // Classificação com SWITCH-CASE
                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"A letra '{letra}' é uma VOGAL!");
                        acertos++;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"A letra '{letra}' é uma CONSOANTE!");
                        break;
                }

                Console.ResetColor();
            }

            // Estatísticas finais
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nJogo encerrado!");
            Console.ResetColor();

            if (totalJogadas > 0)
            {
                double porcentagem = (double)acertos / totalJogadas * 100;

                Console.WriteLine("\nESTATÍSTICAS DA SESSÃO:");
                Console.WriteLine($"Total de letras jogadas: {totalJogadas}");
                Console.WriteLine($"Acertos (vogais): {acertos}");
                Console.WriteLine($"Percentual de acertos: {porcentagem:F1}%");

                if (porcentagem >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PARABÉNS! Você está indo muito bem!");
                }
                else if (porcentagem >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bom trabalho! Continue praticando!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Continue treinando! Você vai melhorar!");
                }
                Console.ResetColor();
            }

            // Mensagem final
            Console.WriteLine("\nObrigado por jogar!");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}