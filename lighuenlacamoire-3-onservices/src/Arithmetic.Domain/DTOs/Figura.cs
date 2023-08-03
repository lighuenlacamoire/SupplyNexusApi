using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.Domain.DTOs
{
    public abstract class Figura
    {
        public abstract double Area(double[] args);

        public abstract double Perimetro(double[] args);
    }
}
