namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int middleIndex = array.Length / 2;
      int[] newArray = new int[array.Length + 1];

      // Shift the values before the middle index to the new array
      for (int i = 0; i < middleIndex; i++)
      {
        newArray[i] = array[i];
      }

      // Insert the value at the middle index
      newArray[middleIndex] = value;

      // Shift the values after the middle index to the new array
      for (int i = middleIndex + 1; i < newArray.Length; i++)
      {
        newArray[i] = array[i - 1];
      }

      return newArray;
    }
  }
}
