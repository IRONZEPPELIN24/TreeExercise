using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Tree
    {
        //Attributes
        private Node root;

        //Methods needed for the Tree class
        public void Create(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                CreateTree(root);
            }
        }
        public void Print()
        {
            if (root == null)
            {
                throw new Exception("No Data");
            }

            else
            {
                PrintTree(root, 0);
            }
        }

        private void CreateTree(Node node)
        {            
            //check in there is a rightchild, then check neighbor to assign value
            if (node.RightChild == null)
            {
                //if there is a missing neighbor, assign value of root
                if (node.RightNeighbor == null || node.LeftNeighbor == null)
                {
                    node.RightChild = new Node(node.Data);
                }

                //add values of neighbors to assign correct child value
                else
                {
                    int newValue = node.RightNeighbor.Data + node.LeftNeighbor.Data;
                    node.RightChild = new Node(newValue);
                    Console.WriteLine("Else: " + node.RightChild.Data);
                }
            }

            //Run method again once the right child has been created
            else
            {
                CreateTree(node.RightChild);
                //node.RightNeighbor = new Node(node.RightChild.Data);
            }

            //check if ther eis a leftchild, then check neighbor to assing value
            if (node.LeftChild == null)
            {
                //if there is a missing neighbor, assign value of root
                if (node.RightNeighbor == null || node.LeftNeighbor == null)
                {
                    node.LeftChild = new Node(node.Data);
                }

                //add values of neighbors to assign correct child value
                else
                {
                    int newValue = node.RightNeighbor.Data + node.LeftNeighbor.Data;
                    node.LeftChild = new Node(newValue);
                    Console.WriteLine("Else: " + node.LeftChild.Data);
                }
            }
            //Run method again now that the left child has been created
            else
            {
                CreateTree(node.LeftChild);
                //node.LeftNeighbor = new Node(node.LeftChild.Data);
            }
        }

        private void PrintTree(Node node, int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("|");
                //Console.WriteLine("Level: " + level);
            }
            Console.WriteLine(node.Data);
            level++;
            if (node.RightChild != null)
            {
                PrintTree(node.RightChild, level);
            }
            if (node.LeftChild != null)
            {
                PrintTree(node.LeftChild, level);
            }
        }
    }
}
