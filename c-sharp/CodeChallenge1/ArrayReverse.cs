using System.Collections;

namespace CodeChallenges
{
  public class CodeChallenge1
  {
    public static int[] ReverseArray(int[] array)
    {
      int[] tempArray = new int[array.Length];
      int tempArrayLength = tempArray.Length;

      //reverse array
      for (int i = array.Length; i > 0; i--)
      {
        tempArray[tempArrayLength - i] = array[i - 1];
        Console.WriteLine(array[i]);
      }
      return tempArray;
    }
  }
}
