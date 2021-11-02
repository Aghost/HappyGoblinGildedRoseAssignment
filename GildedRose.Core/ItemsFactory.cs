using System;
using System.Collections.Generic;
using GildedRose.Core.Models;

namespace GildedRose.Core
{
    public class ItemsFactory
    {
        private ItemsFactory _Instance;
        private List<Item> _Items;

        public ItemsFactory() { }

        public ItemsFactory GetInstance() {
            return _Instance ??= new();
        }

        public List<Item> GetItems() {
            return _Items ??= new List<Item>() {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 },
            };
        }

        public void AddItem(string name, int sellin, int quality) {
            GetItems().Add(new Item { Name = name, SellIn = sellin, Quality = quality });
        }

    }
}
