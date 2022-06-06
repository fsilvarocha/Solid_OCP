using System;

namespace Solid_OCP.Certo
{
    public class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Raio * Raio * Math.PI;
        }
    }
}