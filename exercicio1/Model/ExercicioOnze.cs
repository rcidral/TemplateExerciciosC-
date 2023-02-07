using System;

namespace NamespaceExercicioOnze
{
    public class ExercicioOnze
    {
        public static void ExercicioOnzeTask()
        {
            Console.WriteLine("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());
            if(salario == 1903.98) 
            {
                Console.WriteLine("Isento de imposto");
            }
            else if(salario >= 1903.99 && salario <= 2826.65)
            {
                Console.WriteLine("Imposto é de 7.5%");
            }
            else if(salario >= 2826.66 && salario <= 3751.05)
            {
                Console.WriteLine("Imposto é de 15%");
            }
            else if(salario >= 3751.06 && salario <= 4664.68)
            {
                Console.WriteLine("Imposto é de 22.5%");
            }
            else if(salario > 4664.68)
            {
                Console.WriteLine("Imposto é de 27.5%");
            }
        }
    }
}