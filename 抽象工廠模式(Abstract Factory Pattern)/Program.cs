using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工廠模式_Abstract_Factory_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapefactory = FactoryProducer.GetFactory("SHAPE");
            Shape shape1 = shapefactory.GetShape("CIRCLE");
            shape1.draw();

            Shape shape3 = shapefactory.GetShape("SQUARE");
            shape3.draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");
            Color color1 = colorFactory.GetColor("RED");
            color1.fill();

            Color color2 = colorFactory.GetColor("WHITE");
            color2.fill();


            Console.ReadLine();

            /*
             優點：
                抽象工廠模式可以實現高內聚低耦合的設計目的，因此抽象工廠模式被廣泛的應用。
                當一個產品族中的多個對象被設計成一起工作時，它能保證客戶端始終使用同一個產品族中的對象。
                增加新的具體工廠和產品族很方便，不需要修改已有的系統，符合“開閉原則”。

             缺點：
                在產品族中擴充功能新的產品是很困難的，它需要修改抽象工廠的介面。
                增加新的工廠和產品族容易，增加新的產品等級結構麻煩(開閉原則的傾斜性)。

             https://rongli.gitbooks.io/design-pattern/content/chapter3.html
             */
        }
    }
}
