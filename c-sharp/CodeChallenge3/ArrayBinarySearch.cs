namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] array, int key)
    {

      int foundElementIndex = -1;
      int left = 0;
      int right = array.Length - 1;

      while (left <= right)
      {
        int middle = left + (right - left) / 2;
        int currentItem = array[middle];

        if (currentItem < key)
        {
          left = middle + 1;
        }
        else if (currentItem > key)
        {
          right = middle - 1;
        }
        else
        {
          // search for duplicate with lowest index
          while (middle >= 1 && array[middle - 1] == key)
          {
            middle--;
          }

          return middle;
        }

      }
      return foundElementIndex;
    }
  }
}