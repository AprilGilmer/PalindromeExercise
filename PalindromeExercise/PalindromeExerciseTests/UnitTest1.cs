using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests;

public class WordSmith_Tests
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("Racecar", true)]
    [InlineData("hannah", true)]
    [InlineData("kayak", true)]
    [InlineData("Lula", false)]
    [InlineData("April", false)]
    [InlineData("Maya", false)]
    [InlineData("", false)]
    [InlineData(null, false)]

    public void IsAPalidrome_Test(string word, bool expected)
    {
        //Arrange
        var ws = new WordSmith();

        //Act
        var actual = ws.IsAPalindrome(word);
        //Assert
        Assert.Equal(expected, actual);
    }



}
