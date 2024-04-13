using ShapeProject.Models.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ShapeProject.Models.Entitites.Enums;

namespace ShapeProject.Models.Entitites
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; private set; }
       

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Radius * Radius);   
        }

        public override string ToString()
        {
            return $"Color: {Color}; Radius: {Radius} Area: {Area()}";
        }
    }
}
