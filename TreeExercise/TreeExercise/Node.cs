using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Node
    {
        //Create the attributes 
        private int data;
        private Node rightChild;
        private Node leftChild;

        //Create the properties
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        public Node LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }

        public Node(int data)
        {
            this.data = data;
        }
    }
}
