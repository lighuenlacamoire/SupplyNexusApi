using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.Domain.DTOs
{
    public class Circulo : Figura
    {
        public static double PI = 3.14;
        public override double Area(double[] args)
        {
            // PI por radio al cuadrado
            double radio = args[0];

            return PI * (radio * radio);
        }

        public override double Perimetro(double[] args)
        {
            // PI por diametro (radio * 2)
            double radio = args[0];
            return PI * radio * 2;
        }
    }
}
