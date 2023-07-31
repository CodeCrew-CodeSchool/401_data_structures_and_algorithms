namespace CodeChallenges 
{
    public class CodeChallenge2
    {
        public static int[] InsertShiftArray(int[] array, int value)
        {
      //initializing variables
      int[] newArray = new int[array.Length + 1];
      int midIndex = array.Length / 2;

      //loop
      for (int i = 0; i < newArray.Length; i++)
      {
        if (i < midIndex)
        {
          newArray[i] = array[i];
        }
        else if (i == midIndex)
        {
          newArray[i] = value;
        }
        else
        {
          newArray[i] = array[i - 1];
        }

      }
      return newArray;
    }
  }
    
}
