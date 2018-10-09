using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    public interface Color
    {
        void fill();
    }

    public class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("塗上紅色");

        }
    }
    
    public class White : Color
    {
        public void fill()
        {
            Console.WriteLine("塗上白色");

        }
    }

}
