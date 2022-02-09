using Mine.Models;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    public class DiceHelperTests
    {
       
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 1);

            // Reset

            // Assert 
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// To Role one, six sided dice and the result should be between 1 to 6
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_And_6()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(1, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 1);
            Assert.AreEqual(true, result <= 6);
        }

        /// <summary>
        /// To roll a dice and have forcedrandom value as 1 and verify result is 1 
        /// </summary>
        [Test]
        public void RollDice_Invalid_Roll_Forced_1_Should_Return_1()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 1;

            //Act
            var result = DiceHelper.RollDice(1, 1);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// To roll a two, six sided dice and check the values are between 2 to 12
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_2_Dice_6_Should_Return_Between_2_And_12()
        {
            //Arrange

            //Act
            var result = DiceHelper.RollDice(2, 6);

            //Reset

            //Assert
            Assert.AreEqual(true, result >= 2);
            Assert.AreEqual(true, result <= 12);
        }

        /// <summary>
        /// To role zero, ten sided dice and check the result as 0
        /// </summary>
        [Test]
        public void RollDice_Invalid_Roll_0_Dice_10_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 10);

            // Reset

            // Assert 
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// To role a one, zero sided dice and check result is zero
        /// </summary>
        [Test]
        public void RollDice_Invalid_Roll_1_Dice_0_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(1, 0);

            // Reset

            // Assert 
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// To role one, ten sided dice with fixed value as 5 and check the result as 5
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_1_Dice_10_Fixed_5_Should_Return_5()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 5;

            //Act
            var result = DiceHelper.RollDice(1, 10);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// To role three, ten sided dice with forcedrandomvalue as 5 and check the result is 15
        /// </summary>
        [Test]
        public void RollDice_Valid_Roll_3_Dice_10_Fixed_5_Should_Return_15()
        {
            // Arrange
            DiceHelper.ForceRollsToNotRandom = true;
            DiceHelper.ForcedRandomValue = 5;

            //Act
            var result = DiceHelper.RollDice(3, 10);

            //Reset
            DiceHelper.ForceRollsToNotRandom = false;

            //Assert
            Assert.AreEqual(15, result);
        }

    }
}

