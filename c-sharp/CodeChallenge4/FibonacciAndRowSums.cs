namespace CodeChallenges 
{
    public class CodeChallenge4
    {
        public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
        {
      if (nthNumberInSequence <= 0)
        throw new ArgumentException("The input should be a positive integer.", nameof(nthNumberInSequence));

      if (nthNumberInSequence == 1 || nthNumberInSequence == 2)
        return 1;

      int previous = 1;
      int current = 1;

      for (int i = 3; i <= nthNumberInSequence; i++)
      {
        int next = previous + current;
        previous = current;
        current = next;
      }
      return current;
            int result = 0;

            return result;
        }

        public static int[] RowSums(int[][] matrix)
        {
      int rows = matrix.Length;
      int[] rowSums = new int[rows];

      for (int i = 0; i < rows; i++)
      {
        int columns = matrix[i].Length;

        for (int j = 0; j < columns; j++)
        {
          rowSums[i] += matrix[i][j];
        }
      }
      return rowSums;
        }

    }
}
