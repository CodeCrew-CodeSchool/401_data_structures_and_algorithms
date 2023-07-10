
namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int[] resultArray = new int[array.Length + 1];

      int shiftIndex = array.Length / 2;

      for (int i = 0; i < resultArray.Length; i++)
      {
        if(i < shiftIndex)
        {
          resultArray[i] = array[i];

        }
        else if(i == shiftIndex)
        {
          resultArray[shiftIndex] = value;

        }
        else
        {
          resultArray[i] = array[i - 1];

        }
      }

      return resultArray;
    }

    //static void Main()
    //{
    //  int[] testArr = { 5, 1, 4, 7 };
    //  int[] arr = InsertShiftArray(testArr, 3);
    //  Console.WriteLine($"{arr[0]},{arr[1]},{arr[2]},{arr[4]}");
    //  Console.ReadLine();
    //}
  }
}

