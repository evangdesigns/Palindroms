using System;
using Xunit;

namespace Palindroms.Test
{
    public class PalindromsTest
    {
        [Fact]
        public void StarsBackwords()
        {
            //Arrange
            var word = "Stars";
            var expectedResult = false;
            var reverserTests = new Reverser();

            // Act
            bool actualResult = reverserTests.ReverserTester(word);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GiberishBackwords()
        {
            //Arrange
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var reverserTests = new Reverser();

            // Act
            bool actualResult = reverserTests.ReverserTester(word);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NineMemosBackwords()
        {
            //Arrange
            var word = "Some men interpret nine memos";
            var expectedResult = true;
            var reverserTests = new Reverser();

            // Act
            bool actualResult = reverserTests.ReverserTester(word);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Anna()
        {
            //Arrange
            var word = "Anna";
            var expectedResult = true;
            var reverserTests = new Reverser();

            // Act
            bool actualResult = reverserTests.ReverserTester(word);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FunnyThings()
        {
            //Arrange
            var word = "I write funny things that make people sad";
            var expectedResult = false;
            var reverserTests = new Reverser();

            // Act
            bool actualResult = reverserTests.ReverserTester(word);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
