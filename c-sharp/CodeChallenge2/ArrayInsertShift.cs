namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int halfPoint = 0;

      if (array.Length % 2 == 0)
      {
        halfPoint = array.Length / 2;
      }
      else
      {
        halfPoint = array.Length / 2 + 1;
      }

      int[] newArr = new int[array.Length + 1];

      for (int i = 0; i < array.Length; i++)
      {
        if (i < halfPoint)
        {
          newArr[i] = array[i];
        }
        else if (i == halfPoint)
        {
          newArr[i] = value;
        }
        else
        {
          newArr[i + 1] = array[i];
        }
      }

      return newArr;
    }
  }
}
