using TestingAssignment2;
using Xunit;

namespace TestProjectAssignment2
{
    public class TestMyExtension
    {
        [Theory]
        [InlineData("COMPUTER", "computer")]
        [InlineData("MOBILE", "mobile")]
        [InlineData("HAPPY", "happy")]
        public void TestPositive_ChangeToLowerCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToLowerCase(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("COMPUTER", "COMPUTER")]
        [InlineData("MOBILE", "MOBILE")]
        [InlineData("HAPPY", "HAPPY")]
        public void TestNegative_ChangeToLowerCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToLowerCase(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Theory]
        [InlineData("computer", "COMPUTER")]
        [InlineData("mobile", "MOBILE")]
        [InlineData("happy", "HAPPY")]
        public void TestPositive_ChangeToUpperCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToUpperCase(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("computer", "computer")]
        [InlineData("mobile", "mobile")]
        [InlineData("happy", "happy")]
        public void TestNegative_ChangeToUpperCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToUpperCase(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Theory]
        [InlineData("computer keyboard mouse", "Computer Keyboard Mouse")]
        [InlineData("mobile charger and internet", "Mobile Charger And Internet")]
        [InlineData("happy birthday", "Happy Birthday")]
        public void TestPositive_changeToTitleCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToTitleCase(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("computer keyboard mouse", "cOmputer keYboard mouse")]
        [InlineData("mobile charger and internet", "mobile charger and internet")]
        [InlineData("happy birthday", "hapPy birThday")]
        public void TestNegative_changeToTitleCase(string input, string output)
        {
            // Act
            var result = MyExtension.ChangeToTitleCase(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Theory]
        [InlineData("test", "Test")]
        [InlineData("catch", "Catch")]
        [InlineData("happy", "Happy")]
        public void TestPositive_FirstLetterCapital(string input, string output)
        {
            // Act
            var result = MyExtension.FirstLetterCapital(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("test", "tEst")]
        [InlineData("catch", "caTch")]
        [InlineData("happy", "happY")]
        public void TestNegative_FirstLetterCapital(string input, string output)
        {
            // Act
            var result = MyExtension.FirstLetterCapital(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Theory]
        [InlineData("1234", true)]
        [InlineData("10000", true)]
        [InlineData("5800014", true)]
        public void TestPositive_FindStrToNum(string input, bool output)
        {
            // Act
            var result = MyExtension.FindStrToNum(input);
            // Asseret
            Assert.True(output);
        }
        [Theory]
        [InlineData("b1234", false)]
        [InlineData("10000.yg", false)]
        [InlineData("580001a.4", false)]
        public void TestNegative_FindStrToNum(string input, bool output)
        {
            // Act
            var result = MyExtension.FindStrToNum(input);
            // Asseret
            Assert.False(output);
        }
        [Theory]
        [InlineData("test", "tes")]
        [InlineData("catch", "catc")]
        [InlineData("happy", "happ")]
        public void TestPositive_RemoveLastChar(string input, string output)
        {
            // Act
            var result = MyExtension.RemoveLastChar(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("test", "tst")]
        [InlineData("catch", "cath")]
        [InlineData("happy", "hapy")]
        public void TestNegative_RemoveLastChar(string input, string output)
        {
            // Act
            var result = MyExtension.RemoveLastChar(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Theory]
        [InlineData("test match", 2)]
        [InlineData("catch out by filder", 4)]
        [InlineData("enjoy this food", 3)]
        public void TestPositive_TotalCount(string input, int output)
        {
            // Act
            int result = MyExtension.TotalCount(input);
            // Asseret
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("test match", 1)]
        [InlineData("catch out by filder", 6)]
        [InlineData("enjoy this food", 7)]
        public void TestNegative_TotalCount(string input, int output)
        {
            // Act
            var result = MyExtension.TotalCount(input);
            // Asseret
            Assert.NotEqual(output, result);
        }
        [Fact]
        public void Test_All_LowerCase_FindLowerCaseChar()
        {
            // Arrange
            var arrange = "mobile";
            // Act
            var result = MyExtension.FindLowerCaseChar(arrange);
            // Asseret
            Assert.Equal("All are in lowercase.", result);
        }
        [Fact]
        public void Test_Some_Not_In_LowerCase_FindLowerCaseChar()
        {
            // Arrange
            var arrange = "MobiLe";
            // Act
            var result = MyExtension.FindLowerCaseChar(arrange);
            // Asseret
            Assert.Equal("There are only 2 character in uppercase", result);
        }
        [Fact]
        public void Test_All_UpperCase_FindUpperCaseChar()
        {
            // Arrange
            var arrange = "MOBILE";
            // Act
            var result = MyExtension.FindUpperCaseChar(arrange);
            // Asseret
            Assert.Equal("All are in uppercase.", result);
        }
        [Fact]
        public void Test_Some_Not_In_UpperCase_FindUpperCaseChar()
        {
            // Arrange
            var arrange = "MobiLE";
            // Act
            var result = MyExtension.FindUpperCaseChar(arrange);
            // Asseret
            Assert.Equal("There are only 3 character in lower", result);
        }
        [Fact]
        public void TestPositive_ConvertStrToInt()
        {
            // Arrange
            var arrange = "12345";
            // Act
            var result = MyExtension.ConvertStrToInt(arrange);
            // Asseret
            Assert.Equal(12345, result);
        }
        [Fact]
        public void TestNegative_ConvertStrToInt()
        {
            // Arrange
            var arrange = "123451";
            // Act
            var result = MyExtension.ConvertStrToInt(arrange);
            // Asseret
            Assert.NotEqual(12345, result);
        }
    }
}
