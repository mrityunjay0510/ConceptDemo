using System;

namespace ConceptDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BinaryTree
            BinarySearchTree bt = new BinarySearchTree();
            bt.InsertNode(25);
            bt.InsertNode(15);
            bt.InsertNode(22);
            bt.InsertNode(10);
            bt.InsertNode(4);
            bt.InsertNode(12);
            bt.InsertNode(18);
            bt.InsertNode(24);

            bt.InsertNode(50);
            bt.InsertNode(35);
            bt.InsertNode(70);
            bt.InsertNode(31);
            bt.InsertNode(30);
            bt.InsertNode(44);
            bt.InsertNode(66);
            bt.InsertNode(90);

            bt.InOrder();
            bt.GetAllNodeInTreeLevel();

            bt.DFS();
            #endregion

            Console.ReadKey();
        }
    }
}
