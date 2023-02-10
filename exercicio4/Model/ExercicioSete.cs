using System;

namespace NamespaceExercicioSete
{
    public class ExercicioSete
    {
        public static void ExercicioSeteTask()
        {
            string[] fila = new string[10];
            fila[0] = "João";
            fila[1] = "Maria";
            fila[2] = "José";
            fila[3] = "Pedro";
            fila[4] = "Paulo";
            fila[5] = "Ana";
            fila[6] = "Marcos";
            fila[7] = "Julia";
            fila[8] = "Rafael";
            fila[9] = "Ricardo";
            fila[10] = "Rafaela";
            foreach(string i in fila)
            {
                Console.WriteLine(i);
            }
        }
    }
}