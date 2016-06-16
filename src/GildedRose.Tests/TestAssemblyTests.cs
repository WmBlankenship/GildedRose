using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        private Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }

        [Fact]
        public void Item_Quality_Decrease_By_One_Each_Day()
        {
            var items = new List<Item>
            {
                CreateItem("Foo Item", 10, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(9, items[0].Quality);
        }

        [Fact]
        public void Item_Quality_Decrease_By_Two_After_SellBy()
        {
            var items = new List<Item>
            {
                CreateItem("Foo Item", 0, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(8, items[0].Quality);
        }

        [Fact]
        public void Item_Quality_Is_Never_Negative()
        {
            var items = new List<Item>
            {
                CreateItem("Foo Item", 0, 0)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void Aged_Brie_Quality_Increases_With_Age()
        {
            var items = new List<Item>
            {
                CreateItem("Aged Brie", 10, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(11, items[0].Quality);
        }

        [Fact]
        public void Item_Quality_Never_Exceeds_Fifty()
        {
            var items = new List<Item>
            {
                CreateItem("Aged Brie", 10, 50)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void Sulfuras_Never_Decreases_In_Quality()
        {
            var items = new List<Item>
            {
                CreateItem("Sulfuras, Hand of Ragnaros", 0, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(10, items[0].Quality);
        }

        [Fact]
        public void Backstage_Passes_Quality_Increases_With_Age()
        {
            var items = new List<Item>
            {
                CreateItem("Backstage passes to a TAFKAL80ETC concert", 20, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(11, items[0].Quality);
        }

        [Fact]
        public void Backstage_Passes_Quality_Increases_By_Two_With_Less_Than_Eleven_Days_Left_But_More_Than_Five()
        {
            var items = new List<Item>
            {
                CreateItem("Backstage passes to a TAFKAL80ETC concert", 10, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(12, items[0].Quality);
        }

        [Fact]
        public void Backstage_Passes_Quality_Increases_By_Three_With_Less_Than_Six_Days_Left_But_More_Than_Zero()
        {
            var items = new List<Item>
            {
                CreateItem("Backstage passes to a TAFKAL80ETC concert", 4, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(13, items[0].Quality);
        }

        [Fact]
        public void Backstage_Passes_Quality_Decreases_To_Zero_With_Zero_Days_Left()
        {
            var items = new List<Item>
            {
                CreateItem("Backstage passes to a TAFKAL80ETC concert", 0, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void Conjured_Item_Quality_Decrease_By_Two_Each_Day()
        {
            var items = new List<Item>
            {
                CreateItem("Conjured Item", 10, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(8, items[0].Quality);
        }

        [Fact]
        public void Conjured_Item_Quality_Decrease_By_Four_After_SellBy()
        {
            var items = new List<Item>
            {
                CreateItem("Conjured Item", 0, 10)
            };

            var program = new Program(items);
            program.UpdateQuality();

            Assert.Equal(6, items[0].Quality);
        }
    }
}