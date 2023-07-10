using System.Collections;
namespace CodeChallenges
{
  public class CodeChallenge1
  {
    public static int[] ReverseArray(int[] array)
    {
      int[] tempArray = new int[array.Length];
      int talength = tempArray.Length;
      for (int i = array.Length; i > 0; i--)
      {
        tempArray[talength - i] = array[i - 1];
      }
      return tempArray;
    }
  }
}
