using System;

namespace NamespaceExercicioNove
{
    public class ExercicioNove
    {
        public static void ExercicioNoveTask()
        {
            Console.WriteLine("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if(imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if(imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if(imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }
        }
    }
}