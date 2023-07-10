namespace CodeChallenges 
{
    public class CodeChallenge2
    {
        public static int[] InsertShiftArray(int[] array, int value)
        {
      int midIndex = array.Length / 2;
      int[] newArray = new int[array.Length + 1];
      for (int i = 0; i < midIndex; i++)
      {
        newArray[i] = array[i];
      }
      newArray[midIndex] = value;
      for (int i = midIndex + 1; i < newArray.Length; i++)
      {
        newArray[i] = array[i - 1];
      }

      //insert the value into the middle of the array
      return newArray;
        }
    }
}
