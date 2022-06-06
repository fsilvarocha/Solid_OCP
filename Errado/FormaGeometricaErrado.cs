using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_OCP.Errado
{
    public class FormaGeometricaErrado
    {
        public FormaGeometricaTipo Tipo { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Raio { get; set; }
        //Forma errada do OCP
        public double CalculaArea()
        {
            double Area = 0;
            if (Tipo == FormaGeometricaTipo.Retangulo || Tipo == FormaGeometricaTipo.Quadrado)
                Area = Largura * Altura;

            if (Tipo == FormaGeometricaTipo.Circulo)
                Area = Raio * Raio * Math.PI;

            return Area;
        }
    }
}
