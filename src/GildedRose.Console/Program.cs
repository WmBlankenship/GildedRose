using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        UpdateStrategyFactory _strategyFactory = new UpdateStrategyFactory();
        IList<Item> Items;

        public Program()
        {

        }

        public Program(IList<Item> items)
        {
            this.Items = items;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            //var app = new Program(new List<Item>
            //            {
            //                new Item
            //                { 
            //                    Name = "Aged Brie", 
            //                    SellIn = 10, 
            //                    Quality = 10
            //                }
            //            });
            //app.UpdateQuality();

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
