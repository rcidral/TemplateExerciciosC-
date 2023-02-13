using System;

namespace NamespaceCircunferencia
{
    public class Circunferencia
    {
        private double raio;
        private const double pi = 3.14;

        public Circunferencia(double raio)
        {
            this.raio = raio;
        }

        public double area()
        {
            return pi * Math.Pow(raio, 2);
        }
    }
}
