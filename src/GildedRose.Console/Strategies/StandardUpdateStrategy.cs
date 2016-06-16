
namespace GildedRose.Console
{
    public class StandardUpdateStrategy : IUpdateStrategy
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
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 1;
            }
        }
    }
}
