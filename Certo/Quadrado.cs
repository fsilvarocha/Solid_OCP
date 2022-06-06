namespace Solid_OCP.Certo
{
    public class Quadrado : FormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Quadrado(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double CalcularArea()
        {
            return Altura * Largura;
        }
    }
}