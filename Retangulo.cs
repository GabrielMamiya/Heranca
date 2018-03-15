using System;
namespace Heranca
{
    public class Retangulo : Figura
    {

        public double lado { get; set; }
        public double altura { get; set; }

        public Retangulo(double lado, double altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public override double area(){
            double area = lado * altura;
            return area;
        }
    }
}
