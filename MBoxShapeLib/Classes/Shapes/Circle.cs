using MBoxShapeLib.Classes.Abstractions;
using MBoxShapeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBoxShapeLib.Classes.Figures
{
    public class Circle : Shape, IShapeSquareCalculator
    {
        public double Radius { get; set; }
        public Circle(string typeName, double radius) : base(typeName)
        {
            Radius = radius;
        }
        public double CalculateSquare() => Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
    }
}
