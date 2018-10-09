using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單工廠模式__Simple_Factory_Pattern_
{
    class GreenTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("店員:加入綠茶包");
        }

        public void Brew()
        {
            Console.WriteLine("店員:沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("店員:將綠茶裝杯");
        }
    }
}
