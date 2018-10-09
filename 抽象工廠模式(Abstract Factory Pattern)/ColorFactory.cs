using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    public class ColorFactory : AbstractFactory
    { 

        public override Color GetColor(String color)
        {
            if (color == null)
            {
                return null;
            }

            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("WHITE"))
            {
                return new White();
            }

            return null;
        }

        public override Shape GetShape(String Shape)
        {
            return null;
        }
    }
}
