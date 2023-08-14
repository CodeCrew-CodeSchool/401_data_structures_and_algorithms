namespace CodeChallenges
{
  public class CodeChallenge13
  {
    public static bool ValidateBrackets(string syntax)
    {
      Stack<char> validator = new();

      foreach (char c in syntax)
      {
        if (c == '(' || c == '{' || c == '[')
        {
          validator.Push(c);
        }

        if (c == ')')
        {
          if (validator.Count == 0) return false;
          if (validator.Peek() == '(')
          {
            validator.Pop();
          }
          else
          {
            return false;
          }
        }

        if (c == '}')
        {
          if (validator.Count == 0) return false;
          if (validator.Peek() == '{')
          {
            validator.Pop();
          }

          else
          {
            return false;
          }
        }

        if (c == ']')
        {
          if (validator.Count == 0) return false;
          if (validator.Peek() == '[')
          {
            validator.Pop();
          }

          else
          {
            return false;
          }
        }

      }

      if(validator.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}