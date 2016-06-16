
namespace GildedRose.Console
{
    public interface IUpdateStrategyFactory
    {
        IUpdateStrategy Create(string name);
    }
}
