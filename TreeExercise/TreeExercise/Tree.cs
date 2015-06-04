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
            if (root = null)
            {
                root = new Node(data);
            }
            else
            {
                CreateTree(data, root);
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

        private void CreateTree(int data, Node node)
        {
            
        }

        private void PrintTree(Node node, int level)
        {

        }
    }
}
