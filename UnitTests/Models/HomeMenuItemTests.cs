using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            // Arrange
            var result = new HomeMenuItem();

            // Act

            // Test all the Setters
            result.Id = MenuItemType.Items;
            result.Title = "Title";

            // Reset

            // Assert
            Assert.AreEqual("Title", result.Title);
            Assert.AreEqual(MenuItemType.Items, result.Id);
        }


    }
}

