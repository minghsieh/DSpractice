using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Treeconstruct
{
    class Treenode
    {
        public Treenode Left;
        public Treenode Right;
        public char Value;
    }

    class Program
    {

        Tree tt;
        static void Main(string[] args)
        {
            Tree tt;
            tt = new Tree();
            char[] treenode = {'x', 'A', 'B', 'C', 'D' ,'x','F'};
            Program.construct_binary_tree(tt.root,treenode);
            Program.inorder_traversal(tt.root);
            Console.ReadLine();
        }

        //static void construct_binary_tree(Tree tt,char[] str)
        static void construct_binary_tree(Treenode root, char[] str)
        {
            Queue q = new Queue();
            if (str.Length < 1)
            {
                return;
            }
            Treenode temp;
            Treenode current;
            //current = new Treenode();
            //current.Value = str[1];
            //tt.root = new Treenode();
            //tt.root.Value = str[1];
            //current = tt.root;
            root = new Treenode();
            root.Value = str[1];
            current = root;


            for (int i = 2; i< str.Length; )
            {
                
                if(str[i] >= 65 && str[i] <= 90)
                {
                    temp = new Treenode();
                    temp.Value = str[i];
                    current.Left = temp;
                    q.Enqueue(temp);
                }
                i = i + 1;
                if (i >= str.Length)
                    break;
                if(str[i]>=65 && str[i] <= 90)
                {
                    temp = new Treenode();
                    temp.Value = str[i];
                    current.Right = temp;
                    q.Enqueue(temp);
                }
                i = i + 1;
                current = (Treenode)q.Dequeue();
            }
            Debug.Assert(root!=null);
        }

        static void inorder_traversal(Treenode tnode)
        {
           
            if (tnode == null)
                return;

            inorder_traversal(tnode.Left);
            Console.Write(tnode.Value);
            inorder_traversal(tnode.Right);
        }
    }
}
