using MBoxShapeLib.Classes.Abstractions;
using MBoxShapeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBoxShapeLib.Classes.Figures
{
    public class Triangle : Shape, IShapeSquareCalculator
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(string typeName, double A, double B, double C) : base(typeName)
        {
            if (A < 0 || B < 0 || C < 0)
            {
                throw new ArgumentException("Значения сторон не могут быть меньше нуля");
            }
            else
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }    
        }
        
        public double CalculateSquare()
        {
            var P = (A + B + C) / 2; 

            var shapeSquare = Math.Round(Math.Sqrt(P * (P - A) * (P - B) * (P - C)), 1);

            return shapeSquare;
        }

        public bool IsRectangular()
        {
            var IsRectangularResult = 
               (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
             || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
             || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));

            return IsRectangularResult;
        }
    }
}
