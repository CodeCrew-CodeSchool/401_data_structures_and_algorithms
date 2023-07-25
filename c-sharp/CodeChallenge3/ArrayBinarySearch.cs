using System.Security.Cryptography;

namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] array, int key)
    {
      int high = array.Length - 1;
      int low = 0;

      while (low <= high)
      {
        int mid = low + (high - low) / 2;

        if (array[mid] == key)
        {
          // Check if the current mid is the first occurrence of the key
          while (mid > 0 && array[mid - 1] == key)
          {
            mid--;
          }
          return mid;
        }
        else if (array[mid] < key)
        {
          low = mid + 1;
        }
        else
        {
          high = mid - 1;
        }
      }

     /* int foundElementIndex = -1;*/
      return -1; // key isnt present in the array
    }
  }
}
