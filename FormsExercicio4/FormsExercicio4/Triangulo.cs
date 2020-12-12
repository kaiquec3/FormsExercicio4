using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercicio4
{
    class Triangulo
    {
        double @base;
        double altura;
        double area;

        public Triangulo()
        {
            this.@base = 0;
            this.altura = 0;
        }

        public Triangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public void SetBase(double @base)
        {
            this.@base = @base;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public double GetBase()
        {
            return this.@base;
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public double GetArea()
        {
            return this.area;
        }

        public double CalcularArea()
        {
            this.area = (this.@base * this.altura) / 2;
            return this.area;
        }
    }
}
