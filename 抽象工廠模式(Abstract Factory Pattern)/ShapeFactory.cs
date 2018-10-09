using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    public class ShapeFactory : AbstractFactory
    {

        public override Color GetColor(String color)
        {
            return null;
        }

        public override Shape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
