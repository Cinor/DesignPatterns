using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工廠方法模式__Factory_Method_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageStores stores = new BeverageStores();
            Console.WriteLine("A 客人點了綠茶");
            stores.BeverageOrders("GreenTea");

            Console.Read();
        }
                
    }
}
