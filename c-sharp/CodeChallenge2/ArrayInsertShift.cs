namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] numbers, int newNum)
    {
        int[] newArray = new int[numbers.Length + 1];
        int midPoint = numbers.Length / 2;
        for (int i = 0; i < midPoint; i++)
        {
          newArray[i] = numbers[i];
        }
        newArray[midPoint] = newNum;
        for (int i = midPoint + 1; i < newArray.Length; i++)
        {
          newArray[i] = numbers[i - 1];
        }
        return newArray;
      }
    }
  
}
