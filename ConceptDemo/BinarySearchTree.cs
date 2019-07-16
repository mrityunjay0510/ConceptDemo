using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptDemo
{
    public class Node
    {
        public Node Left { get; set; }
        public int Item { get; set; }
        public Node Right { get; set; }
        public Node(int num)
        {
            Item = num;
            Left = Right = null;
        }
    }
    public class BinarySearchTree
    {
        Node root;
        public void InsertNode(int num)
        {
            Node node = new Node(num);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node currentNode = root;
                while (true)
                {
                    Node parent = currentNode;
                    if(num < currentNode.Item)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parent.Left = node;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parent.Right = node;
                            break;
                        }
                    }
                }
            }
        }

        public void InOrder()
        {
            InOrderIteration(root);
        }

        public void InOrderIteration(Node node)
        {
            if (node != null)
            {
                InOrderIteration(node.Left);
                Console.WriteLine(node.Item);
                InOrderIteration(node.Right);
            }
        }

        public void GetAllNodeInTreeLevel()
        {
            List<List<int>> elementListByLevel = new List<List<int>>();
            Queue<Node> queue = new Queue<Node>();
            //List<int> outerNodes = new List<int>();
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                queue.Enqueue(root);
                //outerNodes.Add(root.Item);
                elementListByLevel.Add(new List<int> { root.Item });
                while (queue.Count > 0)
                {
                    int queueElementCount = queue.Count;
                    List<int> element = new List<int>();
                    for (int i = 1; i <= queueElementCount; i++)
                    {
                        Node n = queue.Dequeue();
                        if(n.Left != null)
                        {
                            element.Add(n.Left.Item);
                            queue.Enqueue(n.Left);
                        }
                        if (n.Right != null)
                        {
                            element.Add(n.Right.Item);
                            queue.Enqueue(n.Right);
                        }
                        //if (n.Left == null && n.Right == null)
                        //{
                        //    outerNodes.Add(n.Item);
                        //}
                       
                    }
                    if (element.Count > 0)
                    {                    
                        elementListByLevel.Add(element);
                    }               
                }
            }

            int treeLevel = 1;
            foreach(var level in elementListByLevel)
            {
                
                Console.Write(treeLevel++ + "---->");      
                foreach (var item in level)
                {
                    Console.Write(" "+item);
                }           
                Console.WriteLine();
            }

            

            //for (int i = 0; i < elementListByLevel.Count-1; i++)
            //{
            //    List<int> level = elementListByLevel[i];    
            //    if (level.Count == 1)
            //    {
            //        outerNodes.Add(level[0]);
            //    }
            //    else
            //    {
            //        outerNodes.Add(level[0]);
            //        outerNodes.Add(level[level.Count - 1]);
            //    }
            //}

            //outerNodes.AddRange(elementListByLevel[elementListByLevel.Count - 1]);

            //foreach (var item in outerNodes)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
