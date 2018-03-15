using System;
namespace Heranca
{
    public class Triangulo : Figura
    {

        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public override double area()
        {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));

        }
    }
}
