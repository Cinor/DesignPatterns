using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工廠方法模式__Factory_Method_Pattern_
{
    class BeverageStores
    {

        public IBeverageProvide BeverageOrders(string pBeverageType)
        {
            IBeverageProvide beverage;
            beverage = CreateBeverage(pBeverageType);

            beverage.AddMaterial(); // 加料
            beverage.Brew(); // 沖泡
            beverage.PouredCup(); // 裝杯

            return beverage;
        }

        public IBeverageProvide CreateBeverage(String pBeverageType)
        {
            IBeverageProvide beverage;
            if (pBeverageType == "GreenTea")
                return beverage = new GreenTea();
            if (pBeverageType == "BlackTea")
                return beverage = new BlackTea();
            else
                return null;
        }

    }


}
