using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    public interface Shape
    {
        void draw();
    }


    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("畫出圓形");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("畫出方形");
        }
    }
}
