using System.Collections;
namespace CodeChallenges
{
  // Added code challenge to new repo
    public class CodeChallenge1
    {
        public static int[] ReverseArray(int[] array)
        {
      int[] newArr = new int[array.Length];
      int taLength = newArr.Length;
      
        for (int x = array.Length; x > 0; x--) {
          newArr[taLength - x] = array[x - 1];
              }

      
            return newArr;
        }
    }
}