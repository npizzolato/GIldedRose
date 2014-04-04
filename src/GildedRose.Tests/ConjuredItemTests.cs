namespace GildedRose.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class ConjuredItemTests
    {
        private const string Conjured = "Conjured item";

        [Test]
        public void ConjuredItemsSellinDecreaseByOne()
        {
            Item item = ItemCreator.Create().WithName(Conjured).WithSellIn(5);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void UnexpiredConjuredItemQualityDecreasesByTwo()
        {
            Item item = ItemCreator.Create().WithName(Conjured).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(3);
        }

        [Test]
        public void ExpiredConjuredItemQualityDecreasesByFour()
        {
            Item item = ItemCreator.Create().WithName(Conjured).Expired().WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(1);
        }

        [Test]
        public void ConjuredItemQualityCannotGoNegative()
        {
            Item item = ItemCreator.Create().WithName(Conjured).WithQuality(0);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(0);
        }
    }
}
