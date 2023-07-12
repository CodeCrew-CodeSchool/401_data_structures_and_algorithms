using System.Collections;
namespace CodeChallenges
{
  public class CodeChallenge1
  {
    public static int[] ReverseArray(int[] array)
    {
      int[] tempArray = new int[array.Length];

      int toLength = tempArray.Length;
      for (int i = array.Length; i > 0; i--)
      {
        tempArray[toLength - i] = array[i - 1];
        //Console.WriteLine(array[i]);


      }
      return tempArray;
    }
  }
}
