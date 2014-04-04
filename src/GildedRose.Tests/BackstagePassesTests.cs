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
            Item item = CreatePass().WithSellIn(5);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }

        [Test]
        public void PassForConcertInOverTenDaysShouldHaveQualityIncreaseByOne()
        {
            Item item = CreatePass().WithSellIn(11).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(6);
        }

        [Test]
        public void PassesForConcertInOverFiveDaysShouldHaveQualityIncreaseByTwo()
        {
            Item item = CreatePass().WithSellIn(6).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(7);
        }

        [Test]
        public void PassesForConcertInUnderSixDaysShouldHaveQualityIncreaseByThree()
        {
            Item item = CreatePass().WithSellIn(5).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(8);
        }

        [Test]
        public void PassesAfterTheConcertShouldHaveZeroQuality()
        {
            Item item = CreatePass().WithSellIn(0).WithQuality(5);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(0);
        }

        private static Item CreatePass()
        {
            return ItemCreator.Create().WithName(Pass);
        }
    }
}
