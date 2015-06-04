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
                    //Console.WriteLine(node.RightChild.Data);
                    //CreateTree(node.RightChild);
                }

                //add values of neighbors to assign correct child value
                else
                {
                    int newValue = node.RightNeighbor.Data + node.LeftNeighbor.Data;
                    node.RightChild = new Node(newValue);
                    Console.WriteLine("Else: " + node.RightChild.Data);
                    CreateTree(node.RightChild);
                }
            }
            else
            {
                CreateTree(node.RightChild);
            }

            //check if ther eis a leftchild, then check neighbor to assing value
            if (node.LeftChild == null)
            {
                //if there is a missing neighbor, assign value of root
                if (node.RightNeighbor == null || node.LeftNeighbor == null)
                {
                    node.LeftChild = new Node(node.Data);
                    //Console.WriteLine(node.LeftChild.Data);
                    //CreateTree(node.LeftChild);
                }

                //add values of neighbors to assign correct child value
                else
                {
                    int newValue = node.RightNeighbor.Data + node.LeftNeighbor.Data;
                    node.LeftChild = new Node(newValue);
                    Console.WriteLine("Else: " + node.LeftChild.Data);
                    CreateTree(node.LeftChild);
                }
            }
            else
            {
                CreateTree(node.LeftChild);
            }
        }

        private void PrintTree(Node node, int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.WriteLine("|");
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
