using System.Collections;

namespace CodeChallenges
{
  public class CodeChallenge13
  {
    public static bool ValidateBrackets(string syntax)
    {
      Stack Brackets = new Stack();

      foreach (char c in syntax)
      {
        if (c == '[' || c == '(' || c == '{')
        {
          Brackets.Push(c);
        }
        else if (c == ']' || c == ')' || c == '}')
        {
          if (Brackets.Count == 0)
          {
            return false; 
          }

          char top = (char)Brackets.Peek();
          if ((c == ']' && top == '[') || (c == ')' && top == '(') || (c == '}' && top == '{'))
          {
            Brackets.Pop();
          }
          else
          {
            return false; 
          }
        }
      }

      return Brackets.Count == 0; 
    }
  }
}
