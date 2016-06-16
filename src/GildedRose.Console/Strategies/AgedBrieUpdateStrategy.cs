
namespace GildedRose.Console
{
    public class AgedBrieUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.Quality == 50)
            {
                return;
            }
            else
            {
                item.Quality += 1;
            }
        }
    }
}
