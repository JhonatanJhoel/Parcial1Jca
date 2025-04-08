using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    public class Circulo : FiguraGeometrica
    {
        private readonly double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public override double perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
