using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge15Test
  {
    public PropertyInfo LeftNodeProperty;
    public PropertyInfo RightNodeProperty;
    public PropertyInfo ValueNodeProperty;
    public PropertyInfo BinaryTreeRootProperty;
    public ConstructorInfo NodeConstructorMethod;
    public ConstructorInfo BinaryTreeConstructorMethod;

    public CodeChallenge15Test()
    {
      var nodeType = typeof(Node);
      var binaryTree = typeof(BinaryTree);
      NodeConstructorMethod = nodeType.GetConstructor(new Type[] { typeof(int) });
      BinaryTreeConstructorMethod = binaryTree.GetConstructor(new Type[] { });
      BinaryTreeRootProperty = binaryTree.GetProperty("Root");
      LeftNodeProperty = nodeType.GetProperty("Left");
      RightNodeProperty = nodeType.GetProperty("Right");
      ValueNodeProperty = nodeType.GetProperty("Value");
    }

    [Fact]
    public void Node_Class_Has_Left_Property()
    {
      Assert.NotNull(LeftNodeProperty);
    }

    [Fact]
    public void Node_Class_Has_Right_Property()
    {
      Assert.NotNull(RightNodeProperty);
    }
    [Fact]
    public void Node_Class_Has_Value_Property()
    {
      Assert.NotNull(ValueNodeProperty);
    }
    [Fact]
    public void Node_Class_Has_Constructor_Method()
    {
      Assert.NotNull(NodeConstructorMethod);
    }
    [Fact]
    public void PreOrderSearch_Test()
    {
      BinaryTree tree = (BinaryTree)BinaryTreeConstructorMethod.Invoke(null);
      Node Root = (Node)NodeConstructorMethod.Invoke(new object[] { 1 });
      BinaryTreeRootProperty.SetValue(tree, Root);

      LeftNodeProperty.SetValue(BinaryTreeRootProperty.GetValue(tree), (Node)NodeConstructorMethod.Invoke(new object[] { 2 }));
      RightNodeProperty.SetValue(BinaryTreeRootProperty.GetValue(tree), (Node)NodeConstructorMethod.Invoke(new object[] { 3 }));
      LeftNodeProperty.SetValue((Node)LeftNodeProperty.GetValue(BinaryTreeRootProperty.GetValue(tree)), (Node)NodeConstructorMethod.Invoke(new object[] { 5 }));

      RightNodeProperty.SetValue((Node)LeftNodeProperty.GetValue(BinaryTreeRootProperty.GetValue(tree)), (Node)NodeConstructorMethod.Invoke(new object[] { 8 }));

      LinkedList<int> result = tree.PreOrderSearch();

      int[] expectedValues = { 1, 2, 5, 8, 3 };
      Assert.Equal(expectedValues, result);
    }

    [Fact]
    public void PreOrderSearch_EmptyTree_Test()
    {
      BinaryTree tree = (BinaryTree)BinaryTreeConstructorMethod.Invoke(null);

      LinkedList<int> result = (LinkedList<int>)typeof(BinaryTree)
          .GetMethod("PreOrderSearch")
          .Invoke(tree, null);

      Assert.Empty(result);
    }
    [Fact]
    public void PreOrderSearch_SingleNodeTree_Test()
    {
      BinaryTree tree = (BinaryTree)BinaryTreeConstructorMethod.Invoke(null);
      Node rootNode = (Node)NodeConstructorMethod.Invoke(new object[] { 42 });
      BinaryTreeRootProperty.SetValue(tree, rootNode);

      LinkedList<int> result = (LinkedList<int>)typeof(BinaryTree)
          .GetMethod("PreOrderSearch")
          .Invoke(tree, null);

      Assert.Single(result);
      Assert.Equal(42, result.First.Value);
    }

    [Fact]
    public void PreOrderSearch_LargeTree_Test()
    {
      // Create a large binary tree for testing
      BinaryTree tree = (BinaryTree)BinaryTreeConstructorMethod.Invoke(null);
      Node rootNode = (Node)NodeConstructorMethod.Invoke(new object[] { 1 });
      BinaryTreeRootProperty.SetValue(tree, rootNode);

      Node currentNode = rootNode;
      for (int i = 2; i <= 6; i += 2)
      {
        LeftNodeProperty.SetValue(currentNode, (Node)NodeConstructorMethod.Invoke(new object[] { i }));
        RightNodeProperty.SetValue(currentNode, (Node)NodeConstructorMethod.Invoke(new object[] { i + 1 }));
        currentNode = (Node)LeftNodeProperty.GetValue(currentNode);
      }

      LinkedList<int> result = (LinkedList<int>)typeof(BinaryTree)
          .GetMethod("PreOrderSearch")
          .Invoke(tree, null);

      LinkedList<int> expectedResult = new LinkedList<int>(new[] { 1, 2, 4, 6, 7, 5, 3 });
      Assert.Equal(expectedResult, result);
    }

  }
}