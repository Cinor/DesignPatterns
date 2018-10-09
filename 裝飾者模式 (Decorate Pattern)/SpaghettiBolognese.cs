using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    class SpaghettiBolognese : Spaghetti
    {
        public override string GetName()
        {
            return "茄汁肉醬義大利麵";
        }

        public override string GetDescription()
        {
            return "義大利粗麵";
        }

        public override int GetPrice()
        {
            return 150;
        }
    }
}
