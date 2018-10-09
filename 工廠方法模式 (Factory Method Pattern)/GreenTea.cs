using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工廠方法模式__Factory_Method_Pattern_
{
    public class GreenTeaFactory : IBeverageFactory
    {
        public IBeverageProvide CreateBeverage()
        {
            return new GreenTea();
        }
    }

    public class GreenTea : IBeverageProvide
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
