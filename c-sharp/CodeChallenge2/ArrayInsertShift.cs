namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int length = array.Length + 1;
      int[] newArray = new int[length];
      int midPoint = length / 2;

      for (int i = 0; i < length; i++)
      {
        if (i == midPoint)
        {
          newArray[i] = value;
        }
        else if (i < midPoint)
        {
          newArray[i] = array[i];
        }
        else
        {
          newArray[i] = array[i - 1];
        }
      }

      return newArray;
    }
  }
}
