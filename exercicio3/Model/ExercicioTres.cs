using System;

namespace NamespaceExercicioTres
{
    public class ExercicioTres
    {
        //public static void ExercicioTresTask(string[] args)
        // só argumentei pq tava dando erro de build :)
        public static void ExercicioTresTask()
        {
            //int numero = int.Parse(args[0]);
            //int numero2 = int.Parse(args[1]);
            int numero = 0;
            int numero2 = 0;
            int soma = 0;
            int subtracao = 0;
            int multiplicacao = 0;
            int divisao = 0;
            soma = numero + numero2;
            subtracao = numero - numero2;
            multiplicacao = numero * numero2;
            divisao = numero / numero2;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
        }
    }
}