using Sorts;

public class Program
{
    public static void Main()
    {
        var tree = new BinaryTree();

        // Insert values into the tree
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(12);
        tree.Insert(17);

        // Print the tree structure to verify insertion
        Console.WriteLine("Tree structure:");
        tree.PrintTree();
    }
}
