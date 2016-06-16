
namespace GildedRose.Console
{
    public class ConjuredUpdateStrategy : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.Quality <= 0)
            {
                return;
            }
            else if (item.Quality == 1)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }
        }
    }
}
