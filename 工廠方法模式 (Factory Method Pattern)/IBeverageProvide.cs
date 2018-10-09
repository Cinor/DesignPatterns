using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工廠方法模式__Factory_Method_Pattern_
{
    public interface IBeverageProvide
    {
        void AddMaterial();
        void Brew();
        void PouredCup();
    }
}
