using System;
using System.Globalization;
namespace Heranca
{
    public class Util
    {

        public static Figura lerRetangulo(){
			Console.Write("Largura: ");
			double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Altura: ");
			double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Figura f = new Retangulo(largura, altura);
            return f;
   
        }



    }
}
