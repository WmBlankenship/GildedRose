using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        UpdateStrategyFactory _strategyFactory = new UpdateStrategyFactory();
        IList<Item> Items;

        public Program(IList<Item> items)
        {
            this.Items = items;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var itemsList = new List<Item>
            {
                new Item
                {
                    Name = "Aged Brie",
                    SellIn = 10,
                    Quality = 10
                },
                new Item
                {
                    Name = "Conjured Item",
                    SellIn = 1,
                    Quality = 2
                },
                new Item
                {
                    Name = "Foo Item",
                    SellIn = 1,
                    Quality = 2
                }
            };

            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            foreach (Item item in this.Items)
            {
                var updateStrategy = _strategyFactory.Create(item.Name);
                updateStrategy.UpdateQuality(item);
            }
        }

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}
