using System.Collections;
namespace CodeChallenges
{
    public class CodeChallenge1
    {
        public static int[] ReverseArray(int[] array)
        {
      //Console.WriteLine("Hello WOrld");
      int[] newArray = new int[array.Length];
      int arrayLength = array.Length;
            for(int i = arrayLength; i > 0; i--)
      {
        newArray[arrayLength - i ] = array[i - 1];
      }
            return newArray;
        }
    }
}