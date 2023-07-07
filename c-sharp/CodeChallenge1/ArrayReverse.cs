using System.Collections;
namespace CodeChallenges
{
  public class CodeChallenge1
  {
    public static int[] ReverseArray(int[] array)
    {
      int i = 0;
      int j = array.Length - 1;

      while (j > i)
      {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
      }

      return array;
    }
  }
}