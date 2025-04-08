using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    public class Triangulo : FiguraGeometrica
    {
        private readonly double base_;
        private readonly double altura;
        public Triangulo(double base_, double altura)
        {
            this.base_ = base_;
            this.altura = altura;
        }
        public override double area()
        {
            return (base_ * altura) / 2;
        }
        public override double perimetro()
        {
            return 3 * base_;
        }
    }
}
