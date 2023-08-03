
namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int[] resultArray = new int[array.Length + 1];

      int shiftIndex = (resultArray.Length - 1) / 2;

      for (int i = 0; i < resultArray.Length; i++)
      {
        if (i < shiftIndex)
        {
          resultArray[i] = array[i];

        }
        else if (i == shiftIndex)
        {
          resultArray[shiftIndex] = value;

        }
        else
        {
          resultArray[i] = array[i - 1];

        }
      }

      return resultArray;
    }

  }
}
