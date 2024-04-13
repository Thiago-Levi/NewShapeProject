using ShapeProject.Models.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject.Models.Entitites
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color {  get; private set; }
        public abstract double Area();

        public AbstractShape(Color color)
        {
            Color = color;
        }
    }
}
