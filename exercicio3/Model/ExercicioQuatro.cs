using System;

namespace NamespaceExercicioQuatro
{
    public class ExercicioQuatro
    {
        public static void ExercicioQuatroTask()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());
            int exponenciacao = 1;
            for(int i = 0; i<numero2; i++)
            {
                exponenciacao *= numero;
            }
            Console.WriteLine(numero + " elevado a " + numero2 + " é: " + exponenciacao);
        }
    }
}