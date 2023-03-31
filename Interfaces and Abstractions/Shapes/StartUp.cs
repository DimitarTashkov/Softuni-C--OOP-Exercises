using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IDrawable> figures = new List<IDrawable>();

            var radius = int.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());

            var height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            figures.Add(circle);
            figures.Add(rect);

            circle.Draw();

            rect.Draw();
        }
    }
}
