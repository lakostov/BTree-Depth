using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Depth
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root { get; set; }

            public int GetDepth(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    int LeftDepth = GetDepth(root.Left);
                    int RightDepth = GetDepth(root.Right);

                    if (LeftDepth > RightDepth)
                    {
                        return LeftDepth + 1;
                    }
                    else
                    {
                        return RightDepth + 1;
                    }
                    
                }
                    
            }
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            Console.WriteLine("Height of the tree is: " + tree.GetDepth(tree.Root));
        }
    }
}
