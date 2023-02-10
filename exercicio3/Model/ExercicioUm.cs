using System;

namespace NamespaceExercicioUm 
{
    public class ExercicioUm 
    {
        public static async void ExercicioUmTask() 
        {
            Console.WriteLine("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine());
            List<string> lista = new List<string>();
            for(int i = 0; i<=10; i++)
            {
                lista.Add(String.Format("{0} x {1} = {2}", numero, i, (numero*i)));
            }
            await File.WriteAllLinesAsync("multiplicacao.txt", lista);
        }
    }
}
