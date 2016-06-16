
namespace GildedRose.Console
{
    public class DoNothingUpdate : IUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            return;
        }
    }
}
