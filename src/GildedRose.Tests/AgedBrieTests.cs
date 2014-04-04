namespace GildedRose.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class AgedBrieTests
    {
        private const string Brie = "Aged Brie";

        [Test]
        public void BrieQualityShouldIncreaseByOne()
        {
            Item item = ItemCreator.Create().WithName(Brie).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(6);
        }

        [Test]
        public void BrieSellInShouldDecreaseByOne()
        {
            Item item = ItemCreator.Create().WithName(Brie).WithSellIn(4);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(3);
        }

        [Test]
        public void BrieQualityCannotExceedFifty()
        {
            Item item = ItemCreator.Create().WithName(Brie).WithQuality(50);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(50);
        }

        [Test]
        public void ExpiredBrieQualityShouldIncreaseByTwo()
        {
            Item item = ItemCreator.Create().WithName(Brie).Expired().WithQuality(10);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(12);
        }
    }
}
