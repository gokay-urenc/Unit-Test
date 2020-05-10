using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Spaces_that_are_at_the_beginning_and_the_ending_of_the_entered_expression_must_be_deleted()
        {
            // Arrange
            var phrase = "          Negan    ";
            var expected = "Negan";

            // Act
            var actual = StringHelper.DeleteUnnecessarySpaces(phrase);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Spaces_that_are_inside_of_the_entered_expression_must_be_deleted()
        {
            // Arrange
            var phrase = "Coach      Nick   Ellis     Zoey   Francis          Bill";
            var expected = "Coach Nick Ellis Zoey Francis Bill";

            // Act
            var actual = StringHelper.DeleteUnnecessarySpaces(phrase);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}