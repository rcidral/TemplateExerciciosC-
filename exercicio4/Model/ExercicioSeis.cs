using System;

namespace NamespaceExercicioSeis
{
    public class ExercicioSeis
    {
        public static void ExercicioSeisTask()
        {
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            List<int> lista3 = new List<int>();
            Console.WriteLine("Digite a quantidade de números que deseja inserir na primeira lista: ");
            int quantidade = int.Parse(Console.ReadLine());
            for(int i = 0; i<quantidade; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º número da primeira lista: ");
                lista1.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Digite a quantidade de números que deseja inserir na segunda lista: ");
            quantidade = int.Parse(Console.ReadLine());
            for(int i = 0; i<quantidade; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º número da segunda lista: ");
                lista2.Add(int.Parse(Console.ReadLine()));
            }
            lista3.AddRange(lista1);
            lista3.AddRange(lista2);
            Console.WriteLine("A lista 3 é: ");
            foreach(int i in lista3)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}