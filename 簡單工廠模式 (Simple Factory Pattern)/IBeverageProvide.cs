using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單工廠模式__Simple_Factory_Pattern_
{
    interface IBeverageProvide
    {
        void AddMaterial();
        void Brew();
        void PouredCup();
    }
}
