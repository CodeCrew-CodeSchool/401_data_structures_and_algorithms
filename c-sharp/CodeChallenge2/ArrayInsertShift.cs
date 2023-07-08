namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      // Calculate the length of the new array by adding 1 to the original array's length
      int newArrayLength = array.Length + 1;

      // Create a new array with the calculated length
      int[] newArray = new int[newArrayLength];

      // Calculate the index where the new value should be inserted
      int valuesIndex = (newArray.Length - 1) / 2;

      // Iterate through the new array
      for (int i = 0; i < newArray.Length; i++)
      {
        // If the current index matches the value's index, insert the value
        if (i == valuesIndex)
        {
          newArray[i] = value;
        }
        // If the current index is before the value's index, copy the corresponding value from the original array
        else if (i < valuesIndex)
        {
          newArray[i] = array[i];
        }
        // If the current index is after the value's index, copy the corresponding value from the original array but shifted by one position
        else
        {
          newArray[i] = array[i - 1];
        }
      }

      // Return the new array
      return newArray;
    }
  }
}
