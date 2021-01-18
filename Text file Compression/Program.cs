using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_file_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Huffman Code";
            List<Node> nodeList;
            Tree tree = new Tree();
            while (true)
            {
                Console.Clear();
                nodeList = tree.getListFromFile();
                if (nodeList == null)
                {
                  
                    Console.WriteLine("File cannot be read!");
                    Console.WriteLine("Pressthe any key to continue or Enter \"E\" to exit the program.");
                    string choise = Console.ReadLine();
                    if (choise.ToLower() == "e")
                        break;
                    else
                        continue;
                }
                else
                {
                    //Console.Clear();
                    Console.WriteLine("#Symbols   -   #Frequency");
                    tree.PrintFrequency(nodeList);
                    tree.TreeList(nodeList);
                    tree.setBitcode("", nodeList[0]);
                    tree.Ascii("", nodeList[0]);
                    tree.Filewrite(nodeList[0]);
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\n\n#Symbols    -    #Codes\n");
                    //tree.Filewrite(nodeList[0]);
                    tree.Printcode(nodeList[0]);
                    Console.WriteLine("\n\n");
                    //tree.Ascii(nodeList[0]);
                    Console.WriteLine("Press the any key to contunie");
                    Console.WriteLine("Enter the\"E\" to exit the program.");
                    string choise = Console.ReadLine();
                    if (choise.ToLower() == "e")
                        break;
                    else
                        continue;

                }
            }
        }
    }
}
