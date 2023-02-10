using System;

namespace NamespaceProgram 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            int op = 0;
            do 
            {
                Console.WriteLine("[1] - Exercicio 1");
                Console.WriteLine("[2] - Exercicio 2");
                Console.WriteLine("[3] - Exercicio 3");
                Console.WriteLine("[4] - Exercicio 4");
                Console.WriteLine("[5] - Exercicio 5");
                Console.WriteLine("[6] - Exercicio 6");
                Console.WriteLine("[7] - Exercicio 7");
                Console.WriteLine("[8] - Exercicio 8");
                Console.WriteLine("[9] - Exercicio 9");
                Console.WriteLine("[10] - Exercicio 10");
                Console.WriteLine("[0] - Sair");
                Console.Write("Escolha uma opção: ");
                try
                {
                    op = int.Parse(Console.ReadLine());    
                } 
                catch (Exception e)
                {
                    Console.WriteLine("Opção inválida!");
                }

                switch (op) 
                {
                    case 1:
                        NamespaceExercicioUm.ExercicioUm.ExercicioUmTask();
                        break;
                    case 2:
                        NamespaceExercicioDois.ExercicioDois.ExercicioDoisTask();
                        break;
                    case 3:
                        NamespaceExercicioTres.ExercicioTres.ExercicioTresTask();
                        break;
                    case 4:
                        NamespaceExercicioQuatro.ExercicioQuatro.ExercicioQuatroTask();
                        break;
                    case 5:
                        NamespaceExercicioCinco.ExercicioCinco.ExercicioCincoTask();
                        break;
                    case 6:
                        NamespaceExercicioSeis.ExercicioSeis.ExercicioSeisTask();
                        break;
                    case 7:
                        NamespaceExercicioSete.ExercicioSete.ExercicioSeteTask();
                        break;
                    case 8:
                        NamespaceExercicioOito.ExercicioOito.ExercicioOitoTask();
                        break;
                    case 9:
                        NamespaceExercicioNove.ExercicioNove.ExercicioNoveTask();
                        break;
                    case 10:
                        NamespaceExercicioDez.ExercicioDez.ExercicioDezTask();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }
                
            } while (op == 0);      
        }
    }
}