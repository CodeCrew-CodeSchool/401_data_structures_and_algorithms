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
        public Node Root { get; set; }
        public LinkedList<int> PreOrderSearch()
        {
            LinkedList<int> values = new LinkedList<int>();
            Stack<Node> traversalStack = new Stack<Node>();

            if (Root != null)
            {
                traversalStack.Push(Root);

                while (traversalStack.Count != 0)
                {
                    Node currentNode = traversalStack.Pop();
                    values.AddLast(currentNode.Value);

                    // Note the order of pushing to the stack is different.
                    // First, push the right child, then the left child.
                    if (currentNode.Right != null)
                    {
                        traversalStack.Push(currentNode.Right);
                    }
                    if (currentNode.Left != null)
                    {
                        traversalStack.Push(currentNode.Left);
                    }
                }
            }
            return values;
        }
    public override string ToString()
    {
        string treeString = "";

        Dictionary<int, LinkedList<Node?>> levels = new Dictionary<int, LinkedList<Node?>>();
        levels.Add(0, new LinkedList<Node?>());
        levels[0].AddLast(Root);
        int level = 0;

        while(true)
        {
            int nextLevel = level + 1;
            LinkedList<Node?> currentLevel = levels[level];
            levels.Add(nextLevel, new LinkedList<Node?>());
            foreach(Node? node in currentLevel)
            {
                levels[nextLevel].AddLast(node?.Left);
                levels[nextLevel].AddLast(node?.Right);
            }
            
            bool isNotLastLevel = (from node in levels[nextLevel]
                                where node != null
                                select node).Any();
            if(isNotLastLevel == false) { break; }
            else { level += 1; }
        }
        int numberOfSpaces = 0;
        for(int i = levels.Count-1; i > 0; i--)
        {
            string branchString = "";
            string line = "";
            for(int x = 0; x < numberOfSpaces; x++){ line += " "; }
            foreach(Node node in levels[i])
            {
                line += (node?.Value != null) ? node.Value : "n";
                line += "   ";
            }
            Console.WriteLine(line);
        }
        return "";
    }
    public void PrintInOrder(Node node)
        {
            if (node == null)
                return;

            // Traverse the left subtree
            PrintInOrder(node.Left);

            // Print the current node's value
            Console.Write(node.Value + " ");

            // Traverse the right subtree
            PrintInOrder(node.Right);
        }
    }
}