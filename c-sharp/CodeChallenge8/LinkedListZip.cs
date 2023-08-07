namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedList list1, LinkedList list2)
    {
      LinkedListKth result = new LinkedListKth();

      // Get the heads of both input lists
      Node current1 = list1.Head;
      Node current2 = list2.Head;

      // Alternate between the nodes of the two lists until one of the lists reaches the end
      while (current1 != null || current2 != null)
      {
        if (current1 != null)
        {
          result.Append(current1.Value);
          current1 = current1.Next;
        }

        if (current2 != null)
        {
          result.Append(current2.Value);
          current2 = current2.Next;
        }
      }

      return result;
    }
  }
}




//**Assignment * *
//Write a function called "ZipLists" that takes two linked lists as arguments. The function should return a new linked list that is created by alternating the nodes between the two input lists

// list1, list2

// public class list1
// public class list 2
