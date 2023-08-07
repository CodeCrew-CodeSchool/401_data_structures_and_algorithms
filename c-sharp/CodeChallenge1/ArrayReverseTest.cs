using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge1Test
  {
    [Fact]
    public void ReverseArray_WithIntArray_ReturnsReversedArray()
    {
      // Arrange
      int[] inputArray = { 1, 2, 3, 4, 5 };
      int[] expectedArray = { 5, 4, 3, 2, 1 };

      // Act
      var result = CodeChallenge1.ReverseArray(inputArray);

      // Assert
      Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void ReverseArray_WithEmptyArray_ReturnsSameArray()
    {
      // Arrange
      int[] inputArray = new int[0];

      // Act
      var result = CodeChallenge1.ReverseArray(inputArray);

      // Assert
      Assert.Equal(inputArray, result);
    }
    [Fact]
    public void ReverseArray_WithNegativeNumbers_ReturnsReversedArray()
    {
      // Arrange
      int[] inputArray = { -3, -2, -1, 0, 1, 2, 3 };
      int[] expectedArray = { 3, 2, 1, 0, -1, -2, -3 };

      // Act
      var result = CodeChallenge1.ReverseArray(inputArray);

      // Assert
      Assert.Equal(expectedArray, result);
    }
  }
}
