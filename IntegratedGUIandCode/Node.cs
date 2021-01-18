using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedGUIandCode
{
    class Node: IComparable<Node>
    {
        public string symbol;
        public int frequency;
        public Node Left;
        public Node Right;
        public Node Parent;
        public string bitcode;
        public string ascii;
        public bool isleaf;
        public Node(string input)
        {
            Left = null;
            Right = null;
            Parent = null;
            symbol = input;
            frequency = 1;
            bitcode = "";
            isleaf = true;
        }
        public Node(Node Node1, Node Node2)
        {
            Parent = null;
            bitcode = "";
            isleaf = false;
            if (Node1.frequency >= Node2.frequency)
            {
                Right = Node1;
                Left = Node2;
                Right.Parent = Left.Parent = this;
                frequency = Node1.frequency + Node2.frequency;
                symbol = Node1.symbol + Node2.symbol;
            }
            else if (Node1.frequency < Node2.frequency)
            {
                Right = Node2;
                Left = Node1;
                Right.Parent = Left.Parent = this;
                frequency = Node1.frequency + Node2.frequency;
                symbol = Node1.symbol + Node2.symbol;
            }
        }
        public int CompareTo(Node node)
        {
            return this.frequency.CompareTo(node.frequency);
        }
        public void FrequencyIncrement()
        {
            frequency++;
        }
    }
}

