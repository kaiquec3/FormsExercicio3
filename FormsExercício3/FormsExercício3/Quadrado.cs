using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercício3
{
    class Quadrado
    {
        double diagonal;
        double area;

        public Quadrado()
        {
            this.diagonal = 0;
        }

        public Quadrado(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public void SetDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public double GetDiagonal()
        {
            return this.diagonal;
        }

        public double GetArea()
        {
            return this.area;
        }

        public double CalcularArea()
        {
            this.area = Math.Pow(this.diagonal, 2) / 2;
            return this.area;
        }
    }
}
