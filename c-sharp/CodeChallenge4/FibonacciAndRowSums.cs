
namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      if (nthNumberInSequence == 0)
      {
        return 0;
      }

      int prevNumber = 0, prevPrevNumber = 1, currentNumber = 1;

      for (int i = 1; i < nthNumberInSequence; i++)
      {
        prevPrevNumber = prevNumber;
        prevNumber = currentNumber;
        currentNumber = prevNumber + prevPrevNumber;
      }

      return currentNumber;
    }

    public static int[] RowSums(int[][] matrix)
    {
      int[] rowSums = new int[matrix.Length];

      for (int i = 0; i < matrix.Length; i++)
      {
        int sum = 0;
        for (int j = 0; j < matrix[0].Length; j++)
        {
          sum += matrix[i][j];
        }
        rowSums[i] = sum;
      }

      return rowSums;
    }

  }
}
