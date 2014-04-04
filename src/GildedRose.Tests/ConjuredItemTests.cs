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
            Item item = CreateConjuredItem().WithSellIn(5);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void UnexpiredConjuredItemQualityDecreasesByTwo()
        {
            Item item = CreateConjuredItem().WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(3);
        }

        [Test]
        public void ExpiredConjuredItemQualityDecreasesByFour()
        {
            Item item = CreateConjuredItem().WhichIsExpired().WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(1);
        }

        [Test]
        public void ConjuredItemQualityCannotGoNegative()
        {
            Item item = CreateConjuredItem().WithQuality(0);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(0);
        }

        private static Item CreateConjuredItem()
        {
            return ItemCreator.Create().WithName(Conjured);
        }
    }
}
