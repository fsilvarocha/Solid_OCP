using Solid_OCP.Certo;
using Solid_OCP.Errado;
using System;

namespace Solid_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Forma errada do OCP
            var quadrado = new FormaGeometricaErrado();
            quadrado.Altura = 10;
            quadrado.Largura = 10;
            quadrado.Tipo = FormaGeometricaTipo.Quadrado;
            var Area = quadrado.CalculaArea();

            var circulo = new FormaGeometricaErrado();
            circulo.Altura = 10;
            circulo.Largura = 10;
            circulo.Raio = 50;
            circulo.Tipo = FormaGeometricaTipo.Circulo;
            var AreaCirculo = circulo.CalculaArea();


            Console.WriteLine("Forma Errada: Area do Quadrado: " + Area.ToString());
            Console.WriteLine("Forma Errada: Area do Circulo: " + AreaCirculo.ToString());

            FormaGeometrica quadradoCerto = new Quadrado(10, 10);
            var AreaQuadrado = quadradoCerto.CalcularArea();

            FormaGeometrica circuloCerto = new Circulo(50);
            var CirculoArea = circuloCerto.CalcularArea();

            Console.WriteLine("Forma Certa: Area do Quadrado: " + AreaQuadrado.ToString());
            Console.WriteLine("Forma Certa: Area do Circulo: " + CirculoArea.ToString());

        }
    }
}
