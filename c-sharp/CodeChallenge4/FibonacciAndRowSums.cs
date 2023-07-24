namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      if (nthNumberInSequence <= 0)
      {
        throw new ArgumentException("Invalid input. Nth number in sequence must be greater than zero.");
      }

      if (nthNumberInSequence == 1 || nthNumberInSequence == 2)
      {
        return 1;
      }

      int previous = 1;
      int current = 1;
      int result = 0;

      for (int i = 3; i <= nthNumberInSequence; i++)
      {
        result = previous + current;
        previous = current;
        current = result;
      }

      return result;
    }
  }
}
