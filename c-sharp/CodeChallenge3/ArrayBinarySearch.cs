using System.ComponentModel.DataAnnotations;

namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] sortedArray, int searchKey, int min, int max)
    {

      // int low = 0;
      // int mid = sortedArray.Length/2;
      // int high = sortedArray.Length -1;

      int mid = (min + max) / 2;

      if (searchKey == sortedArray[mid])
      {
        return mid;
      }
      else if (searchKey < sortedArray[mid])
      {
         max = mid - 1;
        mid = (min + max) / 2;
      }
      else if (searchKey > sortedArray[mid])
      {
        min = mid + 1;
        mid = (min + max) / 2;
      }
    int  foundElementIndex = BinarySearch(sortedArray, searchKey, min, max);
      
      return foundElementIndex;
    }
  }
}
