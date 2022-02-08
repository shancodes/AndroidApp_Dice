using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItemModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItemModel_Set_Default_Should_Pass()
        {
            // Arrange
            var result = new HomeMenuItem();

            // Act

            // Test all the Setters
            result.Id = MenuItemType.Items;
            result.Title = "Title";

            // Reset

            // Assert

            // The Get is tested by retrieving it here as well.
            Assert.AreEqual("Title", result.Title);
            Assert.AreEqual(MenuItemType.Items, result.Id);
        }


    }
}

