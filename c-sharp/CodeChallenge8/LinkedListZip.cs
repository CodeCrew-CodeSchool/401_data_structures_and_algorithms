using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedListKth list1, LinkedListKth list2)
    {

      LinkedListKth result = new LinkedListKth();
      Node currentNode1 = list1.Head;
      Node currentNode2 = list2.Head;
      while (currentNode1 != null || currentNode2 != null)
      {

        if (currentNode1 != null)
        {

          result.Append(currentNode1.Value);
          currentNode1 = currentNode1.Next;
        }

        if (currentNode2 != null)
        {
          result.Append(currentNode2.Value);
          currentNode2 = currentNode2.Next;
        }
      }


      return result;
    }
  }
}




















