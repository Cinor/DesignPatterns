﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 簡單工廠模式__Simple_Factory_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageStores store = new BeverageStores(new SimpleBeverageFactory());
            Console.WriteLine("A 客人點了綠茶");
            store.BeverageOrders("GreenTea");

            Console.WriteLine("B 客人點了紅茶");
            store.BeverageOrders("BlackTea");

            Console.ReadLine();
        }
    }
}
