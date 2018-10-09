using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 觀察者模式2
{
    interface IObserver
    {
        void Update(string pMessage);
    }
}
