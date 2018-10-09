using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    class Cheese : CondimentDecorator
    {
        Spaghetti spaghetti;

        public Cheese(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",起司";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 20;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }
}
