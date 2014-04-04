namespace GildedRose.Tests
{
    using NUnit.Framework;
    using FluentAssertions;

    [TestFixture]
    class GenericItemTests
    {
        [Test]
        public void SellInDateShouldDecreaseByOne()
        {
            Item item = ItemCreator.Create().WithSellIn(5);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void UnexpiredItemShouldHaveQualityDecreaseByOne()
        {
            Item item = ItemCreator.Create().WithQuality(3);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(2);
        }

        [Test]
        public void ExpiredItemShouldHaveQualityDecreaseByTwo()
        {
            Item item = ItemCreator.Create().WhichIsExpired().WithQuality(4);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(2);
        }

        [Test]
        public void QualityCannotGoNegative()
        {
            Item item = ItemCreator.Create().WithQuality(0);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(0);
        }
    }
}
