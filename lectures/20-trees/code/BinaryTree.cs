// Binary Tree basics
public class TreeNode
{
    public int Val;
    public TreeNode? Left, Right;
    public TreeNode(int val) => Val = val;
}

static void InOrder(TreeNode? root)
{
    if (root == null) return;
    InOrder(root.Left);
    Console.Write($"{root.Val} ");
    InOrder(root.Right);
}

var root = new TreeNode(1)
{
    Left = new TreeNode(2),
    Right = new TreeNode(3)
};
root.Left.Left = new TreeNode(4);
root.Left.Right = new TreeNode(5);

InOrder(root); // 4 2 5 1 3