using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工廠方法模式__Factory_Method_Pattern_
{
    public class BlackTeaFactory : IBeverageFactory
    {
        public IBeverageProvide CreateBeverage()
        {
            return new BlackTea();
        }
    }

    public class BlackTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("店員:加入紅茶包");
        }

        public void Brew()
        {
            Console.WriteLine("店員:沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("店員:將紅茶裝杯");
        }
    }
}
