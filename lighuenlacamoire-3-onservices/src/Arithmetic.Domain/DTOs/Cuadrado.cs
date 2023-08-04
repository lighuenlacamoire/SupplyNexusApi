using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.Domain.DTOs
{
    public class Cuadrado : Figura
    {
        public override double Area(double[] args)
        {
            // lado al cuadrado
            double side = args[0];
            return side * side;
        }

        public override double Perimetro(double[] args)
        {
            // lado por cuatro
            double side = args[0];
            return side * 4;
        }
    }
}
