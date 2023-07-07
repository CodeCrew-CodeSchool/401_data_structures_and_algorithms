namespace CodeChallenges 
{
    public class CodeChallenge2
    {
        public static int[] InsertShiftArray(int[] array, int value)
        {
      //insert the value into the middle of the array
      int middleIndex = arr.Length / 2;
      int[] newArray = new int[arr.Length + 1];

      for (int i = 0; i < newArray.Length; i++)
      {
        if (i < middleIndex)
        {
          newArray[i] = arr[i];
        }
        else if (i == middleIndex)
        {
          newArray[i] = value;
        }
        else
        {
          newArray[i] = arr[i - 1];
        }
      }

      return newArray;

        }
    }
}
