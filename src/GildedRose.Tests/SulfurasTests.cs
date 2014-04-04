﻿namespace GildedRose.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class SulfurasTests
    {
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";

        [Test]
        public void SulfurasSellinShouldNotDecrease()
        {
            const int Sellin = 10;
            Item item = ItemCreator.Create().WithName(Sulfuras).WithSellIn(Sellin);
            Updater.UpdateItem(item);
            item.SellIn.Should().Be(Sellin);
        }

        [Test]
        public void SulfurasQualityShouldNotChange()
        {
            const int Quality = 20;
            Item item = ItemCreator.Create().WithName(Sulfuras).WithQuality(Quality);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(Quality);
        }

        [Test]
        public void SulfurasQualityCanBeEighty()
        {
            const int Quality = 80;
            Item item = ItemCreator.Create().WithName(Sulfuras).WithQuality(Quality);
            Updater.UpdateItem(item);
            item.Quality.Should().Be(Quality);
        }
    }
}
