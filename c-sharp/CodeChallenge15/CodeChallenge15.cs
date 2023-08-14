using System.Collections.Generic;
namespace CodeChallenges
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }
    public class BinaryTree
    {
        public LinkedList<int> PreOrderSearch()
        {
            return new LinkedList<int>();
        }
    }
}