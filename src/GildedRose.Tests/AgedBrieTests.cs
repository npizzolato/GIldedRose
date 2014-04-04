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
            Item item = CreateBrie().WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(6);
        }

        [Test]
        public void BrieSellInShouldDecreaseByOne()
        {
            Item item = CreateBrie().WithSellIn(4);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(3);
        }

        [Test]
        public void BrieQualityCannotExceedFifty()
        {
            Item item = CreateBrie().WithQuality(50);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(50);
        }

        [Test]
        public void ExpiredBrieQualityShouldIncreaseByTwo()
        {
            Item item = CreateBrie().WhichIsExpired().WithQuality(10);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(12);
        }

        private static Item CreateBrie()
        {
            return ItemCreator.Create().WithName(Brie);
        }
    }
}
