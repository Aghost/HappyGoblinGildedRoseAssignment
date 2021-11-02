using System;
using System.Linq;
using GildedRose.Core;
using GildedRose.Core.Models;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(10, 18)]
        public void AgedBrieTest(int days, int expectedValue) {
            var items = new ItemsFactory().GetInstance().GetItems();

            for (int i = 1; i <= days; i++) {
                GildedRoseBusiness.UpdateQuality(items);
            }

            int actual = items[1].Quality;
            int expected = expectedValue;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 80)]
        [InlineData(1, 80)]
        [InlineData(99, 80)]
        public void SulfurasTests(int days, int expectedValue) {
            var items = new ItemsFactory().GetInstance().GetItems();

            for (int i = 1; i <= days; i++) {
                GildedRoseBusiness.UpdateQuality(items);
            }

            int actual = items[3].Quality;
            int expected = expectedValue;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 20)]
        [InlineData(1, 21)]
        [InlineData(15, 50)]
        [InlineData(16, 0)]
        public void BackstagePassesTests(int days, int expectedValue) {
            var items = new ItemsFactory().GetInstance().GetItems();

            for (int i = 1; i <= days; i++) {
                GildedRoseBusiness.UpdateQuality(items);
            }

            int actual = items[4].Quality;
            int expected = expectedValue;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 4)]
        [InlineData(3, 0)]
        public void ConjuredCakeTests(int days, int expectedValue) {
            var items = new ItemsFactory().GetInstance().GetItems();

            for (int i = 1; i <= days; i++) {
                GildedRoseBusiness.UpdateQuality(items);
            }

            int actual = items[5].Quality;
            int expected = expectedValue;

            Assert.Equal(expected, actual);
        }

    }
}
