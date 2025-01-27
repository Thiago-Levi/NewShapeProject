﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProject.Models.Entitites.Enums;

namespace ShapeProject.Models.Entitites
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
        
    }
}
