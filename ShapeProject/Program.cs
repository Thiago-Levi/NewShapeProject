using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProject.Models.Entitites;
using ShapeProject.Models.Entitites.Enums;
namespace ShapeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape retangle = new Retangle(Color.Blue, 10, 20);
            Console.WriteLine(retangle);

            IShape circle = new Circle(Color.White, 20);
            Console.WriteLine(circle);

            
        }
    }
}
