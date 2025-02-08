using System.Collections.Generic;
using NUnit.Framework;

// ReSharper disable ExpressionIsAlwaysNull
// ReSharper disable CollectionNeverUpdated.Local

namespace SweetAlgy.Extensions.Tests.Runtime
{
    [TestFixture]
    public class EnumerableExtensionsTest
    {
        [Test]
        public void IsNullOrEmptyReturnsTrueForEmptyCollection()
        {
            var emptyCollection = new List<int>();
            Assert.That(emptyCollection.IsNullOrEmpty(), Is.True);
        }

        [Test]
        public void IsNullOrEmptyReturnsTrueForNullCollection()
        {
            List<int> nullCollection = null;
            Assert.That(nullCollection.IsNullOrEmpty(), Is.True);
        }

        [Test]
        public void IsNotNullOrEmptyReturnsTrueForNonEmptyCollection()
        {
            var nonEmptyCollection = new List<int> { 1, 2 };
            Assert.That(nonEmptyCollection.IsNotNullOrEmpty(), Is.True);
        }

        [Test]
        public void GetDuplicateItemsReturnsEmptyWhenNoDuplicatesExist()
        {
            var collection = new List<int> { 1, 2, 3, 4, 5 };
            Assert.That(collection.GetDuplicateItems(), Is.Empty);
        }

        [Test]
        public void GetDuplicateItemsReturnsDuplicateItems()
        {
            var collection = new List<int> { 1, 2, 3, 4, 3, 5, 1 };
            Assert.That(collection.GetDuplicateItems(), Is.EquivalentTo(new List<int> { 1, 3 }));
        }

        [Test]
        public void GetDuplicatesItemsWithSelectorsTransformsDuplicates()
        {
            var items = new List<string> { "apple", "banana", "apple", "cherry", "banana" };
            Assert.That(items.GetDuplicateItems(item => item, key => key.ToUpper()),
                Is.EquivalentTo(new List<string> { "APPLE", "BANANA" }));
        }
    }
}