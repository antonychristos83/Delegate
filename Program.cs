using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Rectangle
    {
        public delegate void RectDelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is : {0}", (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is : {0}",(2*(width+height)));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectDelegate rectdel = new RectDelegate(rect.area);
            rectdel += rect.perimeter;
            rectdel.Invoke(3, 5);
        }

    }


}
