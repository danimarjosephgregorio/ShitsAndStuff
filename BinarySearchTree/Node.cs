using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public Node RightNode;
        public Node LeftNode;
        public int Data;

        public Node(int data)
        {
            this.Data = data;
        }

        public void Insert(int value)
        {
            if(value <= Data)
            {
                if(LeftNode != null)
                {
                    LeftNode.Insert(value);
                }
                else
                {
                    LeftNode = new Node(value);
                }
            }
            else
            {
                if (RightNode != null)
                {
                    RightNode.Insert(value);
                }
                else
                {
                    RightNode = new Node(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }

            Console.Write($"{this.Data}, ");

            if (RightNode != null)
            {
                RightNode.InOrderTraversal();
            } 
        }

        public void PreOrderTraversal()
        {
            Console.Write($"{Data}, ");

            if (LeftNode != null)
            {
                LeftNode.PreOrderTraversal();
            }

            if (RightNode != null)
            {
                RightNode.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.PostOrderTraversal();
            }

            if (RightNode != null)
            {
                RightNode.PostOrderTraversal();
            }

            Console.Write($"{Data}, ");
        }

        public bool Contains(int value)
        {
            if (value == Data)
            {
                return true;
            }

            if (value < Data)
            {
                if (LeftNode != null)
                {
                    return LeftNode.Contains(value);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (RightNode != null)
                {
                    return RightNode.Contains(value);
                }
                else
                {
                    return false;
                }
            }
        }

        public Node FindRecursive(int value)
        {
            if (value == Data)
            {
                return this;
            }

            if (value < Data)
            {
                if (LeftNode != null)
                {
                    return LeftNode.FindRecursive(value);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (RightNode != null)
                {
                    return RightNode.FindRecursive(value);
                }
                else
                {
                    return null;
                }
            }
        }

        public Node Find(int value)
        {
            Node currentNode = this;
            if (value == currentNode.Data)
            {
                return currentNode;
            }

            if (value < currentNode.Data)
            {
                if (currentNode.LeftNode != null)
                {
                    return currentNode.LeftNode.Find(value);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (currentNode.RightNode != null)
                {
                    return currentNode.RightNode.Find(value);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
