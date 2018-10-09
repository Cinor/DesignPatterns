using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裝飾者模式__Decorate_Pattern_
{
    abstract class Spaghetti
    {
        public string name = "未知名稱";
        public string description = "未知配料";

        public abstract int GetPrice();

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual string GetDescription()
        {
            return this.description;
        }
    }
}
