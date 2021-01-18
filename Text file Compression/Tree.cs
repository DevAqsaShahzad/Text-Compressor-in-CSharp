using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_file_Compression
{
    class Tree
    {
        //public string file;
        public List<Node> getListFromFile()
        {
            List<Node> nodeList = new List<Node>();  // Node List.
            Console.WriteLine("Example file: \"a.txt\"\n");
            Console.Write("Enter the path of the file: ");
            String filename = Console.ReadLine();
            //file = filename;
            FileInfo f = new FileInfo(filename);
            long s1 = f.Length;
            Console.Write("FileSize: " + s1.ToString());
            Console.Write("\n");
            try
            {
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                for (int i = 0; i < stream.Length; i++)
                {
                    string read = Convert.ToChar(stream.ReadByte()).ToString();
                    if (nodeList.Exists(x => x.symbol == read))
                        nodeList[nodeList.FindIndex(y => y.symbol == read)].FrequencyIncrement(); 
                    else
                        nodeList.Add(new Node(read));  
                }
                nodeList.Sort();   
                return nodeList;
            }
            catch (Exception)
            {
                return null;
            }
              
        }
        public void extension()
        {
            string file = @"C:\Users\Pisces Khan\OneDrive\Documents\GitHub\AOA-Project\Text file Compression\Huffman.txt";
            FileInfo filename = new FileInfo(file);
            filename.MoveTo(Path.ChangeExtension(file, ".cmp"));
        }
        public void Filewrite( Node node)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Pisces Khan\OneDrive\Documents\GitHub\AOA-Project\Text file Compression\Copy.txt");
            writer(node, streamWriter);
            streamWriter.Close();
            //extension();
        }
        public void writer(Node node, StreamWriter path)
        {            
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                
                path.WriteLine("Symbol : {0} - Bytes : {1} - Code : {2}", node.symbol, node.ascii, node.bitcode);
                return;
            }
            
            writer(node.Left, path);
            writer(node.Right, path);
            
        }
        public void Replace(Node node)
        {
            StreamWriter filename = new StreamWriter(@"C:\Users\Pisces Khan\OneDrive\Documents\GitHub\AOA-Project\Text file Compression\Replace.txt");
            //filename.Replace(node.ascii, node.ascii);
        }
        
        public void Ascii(string asci, Node node)
        {
            string s = node.symbol;
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                foreach (char c in s.ToCharArray())
                {
                    asci = Convert.ToString(c, 2).PadLeft(8, '0');
                    node.ascii = asci;
                    return;
                }
            }
            Ascii(asci, node.Left);
            Ascii(asci, node.Right);
        }
        public void TreeList(List<Node> n)
        {
            while (n.Count > 1)
            {
                Node n1 = n[0];
                n.RemoveAt(0);
                Node n2 = n[0];
                n.RemoveAt(0);
                n.Add(new Node(n1, n2));
                n.Sort();
            }
        }
        public void setBitcode(string code, Node node)
        {
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                node.bitcode = code;
                return;
            }
            setBitcode(code + "0", node.Left);
            setBitcode(code + "1", node.Right);
        }
        public void PrintFrequency(List<Node> n)
        {
            foreach (var item in n)
                Console.WriteLine("Symbol : {0} - Frequency : {1}", item.symbol, item.frequency);
        }
        public void Printcode(Node node)
        {
            if (node == null)
                return;
            if (node.Left == null && node.Right == null)
            {
                Console.WriteLine("Symbol : {0} -  Code : {1}", node.symbol, node.bitcode);
                return;
            }
            Printcode(node.Left);
            Printcode(node.Right);
        }

    }
}