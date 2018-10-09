using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    class Ham : CondimentDecorator
    {
        Spaghetti spaghetti;

        public Ham(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",火腿";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 38;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }
}
