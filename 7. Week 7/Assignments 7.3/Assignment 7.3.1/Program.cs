/*1. You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.*/

Solution s = new Solution();
TreeNode<int> root = new TreeNode<int>(4);
root.Insert(2);
root.Insert(6);
root.Insert(1);
root.Insert(3);
root.Insert(5);
root.Insert(7);

var result = s.BST(root, 5);    
if (result != null)
{
    Console.WriteLine($"Found: {result.Data}");
}
else
{
    Console.WriteLine("Node not found");
}


public class Solution
{
    //Added ? to the return type of the BST method to indicate that it can return a null value if the node is not found in the binary search tree.
    public TreeNode<int>? BST(TreeNode<int>? root, int val)
    {
        if (root == null || root.Data == val)
        {
            return root;
        }

        if (val < root.Data)
        {
            return BST(root.Left, val);
        }
        else
        {
            return BST(root.Right, val);
        }
    }
}


public class TreeNode<T> where T : IComparable<T>
{
    //Added interface constraint to ensure that the data type T can be compared, which is necessary for binary search tree operations.

    public T Data { get; set; }

    public TreeNode<T>? Parent { get; set; }

    public TreeNode<T>? Left { get; set; }

    public TreeNode<T>? Right { get; set; }

    public TreeNode(T data)
    {
        Data = data;
    }

    public void Insert(T data)
    {
        if (data.CompareTo(Data) < 0)
        {
            if (Left == null)
            {
                Left = new TreeNode<T>(data) { Parent = this };
            }
            else
            {
                Left.Insert(data);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = new TreeNode<T>(data) { Parent = this };
            }
            else
            {
                Right.Insert(data);
            }
        }
    }

}