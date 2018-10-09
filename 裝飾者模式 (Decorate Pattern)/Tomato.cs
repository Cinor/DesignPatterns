using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    class Tomato : Spaghetti
    {
        Spaghetti spaghetti;

        public Tomato(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",大蒜";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 3;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }
}
