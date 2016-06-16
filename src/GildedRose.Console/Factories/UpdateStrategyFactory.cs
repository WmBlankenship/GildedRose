
namespace GildedRose.Console
{
    public class UpdateStrategyFactory : IUpdateStrategyFactory
    {
        public IUpdateStrategy Create(string name)
        {
            if (name == "Sulfuras, Hand of Ragnaros")
            {
                return new DoNothingUpdate();
            }
            else if (name == "Aged Brie")
            {
                return new AgedBrieUpdateStrategy();
            }
            else if (name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePassUpdateStrategy();
            }
            else if (name.Contains("Conjured"))
            {
                return new ConjuredUpdateStrategy();
            }
            else
            {
                return new StandardUpdateStrategy();
            }
        }
    }
}
