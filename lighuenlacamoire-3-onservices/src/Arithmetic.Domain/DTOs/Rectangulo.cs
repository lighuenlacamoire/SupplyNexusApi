using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.Domain.DTOs
{
    public class Rectangulo : Figura
    {
        public override double Area(double[] args)
        {
            // longitud * ancho
            double longitude = args[0];
            double wide = args[1];
            return longitude * wide;
        }

        public override double Perimetro(double[] args)
        {
            // longitud * 2 + ancho * 2
            double longitude = args[0];
            double wide = args[1];
            return longitude * 2 + wide * 2;
        }
    }
}
