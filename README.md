#  Jogo Educativo - Português

##  Sobre o Projeto

O **Jogo Educativo - Português** é um software educativo desenvolvido em C# para auxiliar alunos do Ensino Fundamental I na identificação e classificação de vogais e consoantes. O programa roda em console e oferece uma experiência interativa com feedback visual por meio de cores, promovendo aprendizado autônomo e divertido.

---

##  Objetivo

Ensinar de forma lúdica a diferença entre vogais e consoantes, proporcionando:

- Prática autônoma sem supervisão constante
- Feedback imediato com cores diferenciadas
- Estatísticas de desempenho ao final da sessão
- Experiência interativa e motivadora

---

## ⚙️ Funcionalidades

| Funcionalidade | Descrição |
|----------------|-----------|
| ✅ Menu inicial | Exibe título e instruções de uso |
| ✅ Entrada de letras | Usuário digita uma letra no console |
| ✅ Comando "ajuda" | Exibe instruções novamente |
| ✅ Comando "sair" | Encerra o jogo e mostra estatísticas |
| ✅ Validação de entrada | Aceita apenas uma letra válida |
| ✅ Classificação vogal/consoante | Utiliza estrutura switch-case |
| ✅ Cores no console | Verde (vogal), Azul (consoante), Vermelho (erro), Amarelo (ajuda) |
| ✅ Estatísticas | Total de jogadas, acertos e percentual |
| ✅ Feedback motivacional | Mensagens personalizadas por desempenho |

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Finalidade |
|------------|--------|------------|
| **C#** | .NET 8.0 | Linguagem de programação |
| **.NET SDK** | 8.0 | Framework de desenvolvimento |
| **Console Application** | - | Interface do programa |

---

##  Estrutura do Projeto
JogoEducativo.Portugues/
│
├── Programa.cs #
├──JogameDucativo.Portugues.csproj # configuração de Arquivo de projeto do
└── README.md # Documentação do projeto
texto


----

##  Como Executar

### Pré-requisito

- [. NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (opcional) nosso Código do Visual Studio

## Método# 1: Visual Studio 2022

1. 1. Abra o Visual Studio 2022
2. 2. Clique em **"Criar um novo projeto"**
3. Escolha **"Aplicativo de Console (. NET)"**
4. 4. Configurar:
   - Nome do projeto: `JogoEducativo.Portugues`
   - Enquadramento: `. NET 8.0`
5. Substitua o conteúdo de `Program.cs` por código abaixo
6. Pressione **F5** para executar

### Método 2: Visual Studio Código / Linha de Comando

```bash
# Criação do projeto
dotnet novo console -n JogoEducativo.Portugues -f net8.0

# Entrar na massa
cd JogoEducativo.Portugues

# Substituir o em Código de Código

# Executar o jogo
dotnet correr

afiação

usando Sistema;

namespace JogoEducativo.Portugues
{
    Programa de classe
    {
        staticstatic void Main(string[] ]args)Tradução
        {
            // Configuração do console
            Console..Título = "Jogo Educativo - Português" ;
            Console.ForegroundColor .= ConsoleColor.Cyan ;

            // Cabeçalho
            Console.WriteLine("============================================================")"==================================================================================================================================================================
            Console.WriteLine.WriteLine(" JOGO EDUCATIVO - PORTUGUES "));
            Console.WriteLine(Júnures" a diferenciar VOGAIS e CONSOANTES "));
            Console.WriteLine("============================================================")"==================================================================================================================================================================

            // Ingressos
            Console..WriteLine("\nCOMO JOGAR:"));
            .Console.WriteLine("1. Digite UMA letra do alfabeto"));
            .Console.WriteLine("2. O programa dirá se é vogal )ou"constory);
            Console..WriteLine("3. Digite 'sair' para o jogo de encerramento"));
            Console.WriteLineWriteLine("4. Digite 'ajuda' para ver esta mensagem")); novamente

            // Variáveis de controle
            int totalJogadas = 0 ;
            int acertos = 0 ;

            // Loop principal
            enquanto (verdadeiro)
            {
                Console.Write("\nDigite uma letra: "));
                corda ? entrada = .Console.ReadLine());

                if (string.IsNullOrWhiteSpace(entrada)) (em inglês)
                    continuar ;

                comando de string = entrada..ToLower()). Aparar());

                if (comando == "sair""sair")
                    quebra ;

                if (comando == "ajuda"))
                {
                    Console.ForegroundColor = ConsoleColor.Amarelo ;
                    Console.WriteLine.WriteLine("\nAJUDA:"));
                    Console..WriteLine("Digite UMA de letra de A a Z"););
                    Console..WriteLine("Vogais são: A, E, I, O, U"));
                    Console.WriteLine.WriteLine("Digite 'sair' para"));
                    Console.ResetColor());
                    continuar ;
                }

                se (comando..Length ! = 1 || ! char.IsLetter(comando[[0]))
                {
                    Console..ForegroundColor = ConsoleColor..Red ;
                    Console.WriteLine.WriteLine("ERRO: Digite apenas UMA letra do alfabeto!"));
                    Console.ResetColor());
                    continuar ;
                }

                totalJogadas++;
                char = letra comum[0];

                interruptor (letra)
                {
                    caso 'a' :
                    caso 'e' :
                    caso 'i' :
                    caso 'o' :
                    caso 'u''u' :
                        Console..ForegroundColor = ConsoleColor.Green ;
                        Console.WriteLine($"A letra '{letra}' é uma VOGAL!"));
                        acertos ++ ;;
                        quebra ;

                    inadimplente :
                        Console..ForegroundColor = ConsoleColor..Blue ;
                        Console..WriteLine($"A letra '{letra}' é uma CONSOANTE!"));
                        quebra ;
                }

                Console.ResetColor());
            }

            Console.ForegroundColor = ConsoleColor.Amarelo ;
            Console.WriteLine("\nJogogo!"));
            Console.ResetColor());

            se (totalJogadas > 0)
            {
                doubleduplo percentual = (duplo)acertos / totalJogadas * 100 ;;

                Console..WriteLine("\nESTATÍSTICAS DA SESSÃO:"));
                Console..WriteLine($"Total de letras jogadas: {totalJogadas}"));
                Console..WriteLine($"Acertos (vogais): {acertos}"));
                Console.WriteLineWriteLine($"Percentual de acertos: {porcentagem : F1}}%"));

                se (porcentagem >= 80)
                {
                    Console..ForegroundColor = ConsoleColor.Green ;
                    Console..WriteLine(("PARABÉNS! Você está indo bem!"));
                }
                mais se (Percental >= 50)
                {
                    Console.ForegroundColor .= ConsoleColor.Cyan ;
                    Console..WriteLine("Bom trabalho! Continuar praticando!"));
                }
                mais
                {
                    Console.ForegroundColor = ConsoleColor.Amarelo ;
                    Console..WriteLine("Continue trainendo! Vai )Vai!";
                }
                Console.ResetColor());
            }

            Console.Linha de escrita("\nObrigado por jogo!");
            Console.WriteLine.WriteLine("Pressione qualquer tecla para sair...")"Presionanêséquioétéquioé-tá para para...");
            Console.LeiaKey();
        }
    }
}

Comando	Função	Cor
a Tá z	Classifica uma letra	Verde (vogal) / Azul (consoante)
ajuda	Exibe como instruções	Amarelo
sair	Encerra o jogo	Amarelo
A exemplo de Execução
texto

=========================================================================================================
 JOGO EDUCATIVO - PORTUGUES 
 Aprenda a diferador VOGAIS e CONSOANTES 
=========================================================================================================

COMO JOGAR:
1. 1. Digite UMA letra do alfabeto
2. 2. O programa dirá se é vogal oucontários
3. Digite 'sair' para o jogo de encerramento
4. 4. Digite 'ajuda' para ver esta mensagem de volta

Digite uma letra: a
Uma letra 'a' é uma VOGAL!

Digite uma letra: b
Uma letra 'b' é uma CONSOANTE!

Digite uma letra: sai

Jogo!

ESTATÍSTICAS DA SESSÃO:
Total de letras jogas: 2
Acertos (vogais): 1
Percentual de acertos: 50,0%
Bom trabalho! Continuar praticando!

Obrigado por!
Pressione há tecla para sair...

 Núcleos sem Console
Cor	Significado
	Vogal (acerto)
🔵 Azul	Consoante
🔴 Vermelho	Erro de entrada
🟡 Amarelo	Ajuda e informações
🔵 Ciano	Cabeçalho e menu
texto

Programa.cs
│
├── Configuração do Console
│ ├── Console.Título
│ └── Console.ForegroundColor
│
├── Exibição do Cabeçalho
│ └── Console.WriteLine
│
├── Exibição das Instantes
│ └── Console.WriteLine
│
├── Variáveis de Controle
│ ├── totalJogadas (int)
│ └── acertos (int)
│
├── Loop Principal (enquanto verdadeiro)
│ ├── Entrada do usuário
│ ├── Validação de entrada vazia
│ ├── Comando "sair"
│ ├── Comando "ajuda"
│ ├── Validação (1 personagem + letra)
│ ├── (interruptor de classificação-caso)
│ └──Exibição do resultado
│
├── Exibição de Estatísticas
│ ├── Total de aviões
│ ├── Acertos
│ ├── Percentual
│ └── Feedback motivacional
│
└── Mensagem Final
    └── Console.ReadKey()

🧪 Testes Realizados
Cenário	Entrada	Resultado
Vogal	a	VOGAL
Consoante	b	
Categoria: Número	1	 ERRO
Múltiplo	abc	 ERRO
Caractere especial	@	 ERRO
Entrada vazia	(Enter)Tradução	 Aguarda nova entrada
Comando "sair"	Sair	 Encerra
Comando "ajuda"	ajuda	
🔧 Possíveis Melhores Futuras
Melhoria	Categoria:	Prioridade
Letras	Suporte para á, é, í, ó, ú, ç	Alta
Sistema de pontuação	Acumular pontos por acertos consecutivos	Média
Níveisíveis de dificuldade	Letras → sílab	Média
Interface	Migrar de console para Windows Forms	Baixa
Categoria: Relatórios	Gerar relata para professores	Média
Versão web	Disponibilizar como	Baixa
Banco de dados	Armazenar histórico de desempenho	Média
Nome	RA	Papel
David Aparecido da Silva	830143	Desenvolvedor / Documentação

