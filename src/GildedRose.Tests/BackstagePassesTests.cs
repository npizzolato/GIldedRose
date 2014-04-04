namespace GildedRose.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class BackstagePassesTests
    {
        private const string Pass = "Backstage pass";

        [Test]
        public void PassesSellinDecreaseByOne()
        {
            Item item = ItemCreator.Create().WithName(Pass).WithSellIn(5);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void PassForConcertInOverTenDaysShouldHaveQualityIncreaseByOne()
        {
            Item item = ItemCreator.Create().WithName(Pass).WithSellIn(11).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(6);
        }

        [Test]
        public void PassesForConcertInOverFiveDaysShouldHaveQualityIncreaseByTwo()
        {
            Item item = ItemCreator.Create().WithName(Pass).WithSellIn(6).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(7);
        }

        [Test]
        public void PassesForConcertInUnderSixDaysShouldHaveQualityIncreaseByThree()
        {
            Item item = ItemCreator.Create().WithName(Pass).WithSellIn(5).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(8);
        }

        [Test]
        public void PassesAfterTheConcertShouldHaveZeroQuality()
        {
            Item item = ItemCreator.Create().WithName(Pass).WithSellIn(0).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(0);
        }
    }
}
