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
            Item item = new Item()
            {
                SellIn = 5,
                Name = "Random item",
                Quality = 5,
            };

            Updater.UpdateItem(item);
            item.SellIn.Should().Be(4);
        }
    }
}
