using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    class MincedBeef : Spaghetti
    {
        Spaghetti spaghetti;

        public MincedBeef(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",碎肉";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 8;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }
}
