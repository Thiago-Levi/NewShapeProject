using ShapeProject.Models.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject.Models.Entitites
{
    internal class Retangle : AbstractShape
    {
        public double Width {  get; private set; }
        public double Height { get; private set; }

        public Retangle(Color color, double width, double height): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Color: {Color}; Width: {Width}; Height: {Height}; Area: {Area()}";
        }

    }
}
