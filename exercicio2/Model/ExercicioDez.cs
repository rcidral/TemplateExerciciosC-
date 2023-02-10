using System;

namespace NamespaceExercicioDez
{
    public class ExercicioDez
    {
        public static void ExercicioDezTask()
        {
            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int operacao = int.Parse(Console.ReadLine());
            switch(operacao)
            {
                case 1:
                    Console.WriteLine("A soma é: " + (a+b));
                    break;
                case 2:
                    Console.WriteLine("A subtração é: " + (a-b));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação é: " + (a*b));
                    break;
                case 4:
                    Console.WriteLine("A divisão é: " + (a/b));
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }
}