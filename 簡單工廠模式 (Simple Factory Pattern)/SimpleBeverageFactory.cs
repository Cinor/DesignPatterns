using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單工廠模式__Simple_Factory_Pattern_
{
    class SimpleBeverageFactory
    {
        public IBeverageProvide CreateBeverage(string pBeverageType)
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
