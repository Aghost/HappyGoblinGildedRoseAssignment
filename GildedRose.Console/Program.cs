using System;
using System.Linq;
using System.Collections.Generic;
using GildedRose.Core;
using GildedRose.Core.Models;

using static System.Console;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args) {
            WriteLine("OMGHAI!");

            var itemsFactory = new ItemsFactory().GetInstance();
            var Items = itemsFactory.GetItems();

            GildedRoseBusiness.Simulate(Items, 30);
        }

    }
}
