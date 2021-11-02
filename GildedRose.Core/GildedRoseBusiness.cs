using System;
using System.Linq;
using System.Collections.Generic;
using GildedRose.Core;
using GildedRose.Core.Models;

using static System.Console;

namespace GildedRose.Core
{
    public static class GildedRoseBusiness
    {
        public static void Simulate(List<Item> items, int days) {
            for (int i = 0; i <= days; i++) {
                WriteLine($"-------- day {i} --------");
                WriteLine("name, sellIn, quality");

                foreach (var item in items)
                    WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");

                WriteLine("");

                UpdateQuality(items);
            }
        }

        public static void UpdateQuality(List<Item> items) {
            foreach (var item in items.Where(_i => _i.Name[0] != 'S')) {
                item.SellIn--;

                item.Quality = item.Name[0] switch {
                    'A' => item.Quality + (item.SellIn < 0 ? 2 : 1),
                    'B' => item.SellIn switch {
                                            < 0 => 0,
                                            < 5 => item.Quality + 3,
                                            < 10 => item.Quality + 2,
                                            _ => item.Quality + 1
                                        },
                    'C' => item.Quality - (item.SellIn < 0 ? 4 : 2),
                    _ => item.Quality - (item.SellIn < 0 ? 2 : 1),
                };

                item.Quality = item.Quality < 0 ? 0 :
                                    item.Quality > 50 ? 50 :
                                        item.Quality;
            }
        }

    }
}
