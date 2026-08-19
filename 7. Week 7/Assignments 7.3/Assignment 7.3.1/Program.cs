/**/
public class Solution
{

    public TreeNode BST(TreeNode root, int val)
    {

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

}