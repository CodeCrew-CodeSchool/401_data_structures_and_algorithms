using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge15Test
  {

    [Fact]
    public void PreOrderSearch_Test()
    {
      BinaryTree tree = new BinaryTree();
      tree.Root = new Node(1);
      tree.Root.Left = new Node(2);
      tree.Root.Right = new Node(3);
      tree.Root.Left.Left = new Node(5);
      tree.Root.Left.Right = new Node(8);

      LinkedList<int> result = tree.PreOrderSearch();

      int[] expectedValues = { 1, 2, 5, 8, 3 };
      int i = 0;
      foreach (int value in result)
      {
        Assert.Equal(expectedValues[i], value);
        i++;
      }
    }

    [Fact]
    public void PreOrderSearch_EmptyTree_Test()
    {
      BinaryTree tree = new BinaryTree();

      LinkedList<int> result = tree.PreOrderSearch();

      Assert.Empty(result);
    }

    [Fact]
    public void PreOrderSearch_SingleNodeTree_Test()
    {
      BinaryTree tree = new BinaryTree();
      tree.Root = new Node(42);

      LinkedList<int> result = tree.PreOrderSearch();

      Assert.Single(result);
      Assert.Equal(42, result.First.Value);
    }

    [Fact]
    public void PreOrderSearch_LargeTree_Test()
    {
      // Create a large binary tree for testing
      BinaryTree tree = new BinaryTree();
      tree.Root = new Node(1);
      Node currentNode = tree.Root;
      for (int i = 2; i <= 6; i+=2)
      {
        currentNode.Left = new Node(i);
        currentNode.Right = new Node(i + 1);
        currentNode = currentNode.Left;
      }
      LinkedList<int> result = tree.PreOrderSearch();
      LinkedList<int> expectedResult = new LinkedList<int>(new[] { 1, 2, 4, 6, 7, 5, 3 });
      // Verify that the first few values match the expected sequence
      Assert.Equal(expectedResult, result);
    }
  }
}