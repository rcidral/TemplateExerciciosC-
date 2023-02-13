using System;

namespace NamespaceExercicioTres
{
    public class ExercicioTres
    {
        public static void ExercicioTresTask()
        {
        Console.WriteLine("Digite a palavra oculta:");
        string palavraOculta = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a quantidade de tentativas:");
        int quantidadeTentativas = Convert.ToInt32(Console.ReadLine());

        int erros = 0;
        string letrasAcertadas = "";

        while (erros < quantidadeTentativas)
        {
            Console.WriteLine("Digite uma letra:");
            string letra = Console.ReadLine().ToLower();

            if (palavraOculta.Contains(letra))
            {
                letrasAcertadas += letra;
            }
            else
            {
                erros++;
                Console.WriteLine("Você errou! Restam " + (quantidadeTentativas - erros) + " tentativas.");
                Console.WriteLine("Membro marcado: " + MarcarMembro(erros));
            }

            if (AcertouPalavra(palavraOculta, letrasAcertadas))
            {
                Console.WriteLine("Você acertou a palavra!");
                break;
            }
        }

        if (erros == quantidadeTentativas)
        {
            Console.WriteLine("Você foi enforcado!");
        }
    }

    static bool AcertouPalavra(string palavraOculta, string letrasAcertadas)
    {
        foreach (char letra in palavraOculta)
        {
            if (!letrasAcertadas.Contains(letra))
            {
                return false;
            }
        }
        return true;
    }

    static string MarcarMembro(int erros)
    {
        switch (erros)
        {
            case 1:
                return "Cabeça";
            case 2:
                return "Tronco";
            case 3:
                return "Braço Esquerdo";
            case 4:
                return "Braço Direito";
            case 5:
                return "Perna Esquerda";
            case 6:
                return "Perna Direita";
            default:
                return "";
        }
            
    }
    }
}