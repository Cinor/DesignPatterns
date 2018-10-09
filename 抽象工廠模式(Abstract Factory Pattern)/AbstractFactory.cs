using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    public abstract class AbstractFactory
    {
        public abstract Color GetColor(String color);
        public abstract Shape GetShape(String shape);
    }
}
