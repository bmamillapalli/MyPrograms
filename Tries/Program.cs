using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    class TriesNode
    {
        public Dictionary<char, TriesNode> map;
        public bool endOfWord;
        public TriesNode()
        {
            map = new Dictionary<char, TriesNode>();
            endOfWord = false;
        }
    }
    class Tries
    {

        readonly TriesNode root;
        public Tries()
        {
            root = new TriesNode();
        }
        public void Insert(string word)
        {
            TriesNode current = root;

            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                TriesNode node;
                current.map.TryGetValue(ch, out node);
                if (node == null)
                {
                    node = new TriesNode();
                    current.map.Add(ch, node);
                }
                current = node;
                Console.WriteLine("End Of The Word:" + current.endOfWord);
            }
            current.endOfWord = true;
        }
        public void InsertRec(string word)
        {
            InsertRecUtil(root, word, 0);
        }
        public void InsertRecUtil(TriesNode current, string word, int index)
        {
            if (index == word.Length)
            {
                current.endOfWord = true;
                return;
            }
            char ch = word[index];
            TriesNode node;
            current.map.TryGetValue(ch, out node);

            if (node == null)
            {
                node = new TriesNode();
                current.map.Add(ch, node);
            }
            Console.WriteLine("End Of The Word:" + node.endOfWord);

            InsertRecUtil(node, word, index+1);
        }
        static void Main(string[] args)
        {
            Tries obj = new Tries();

            obj.Insert("abc");
            Console.WriteLine("***********************");
            obj.Insert("ab");
            Console.WriteLine("***********************");
            obj.Insert("abcdef");
            Console.WriteLine("***********************");
            obj.Insert("abcdef");


            obj.InsertRec("abc");
            Console.WriteLine("***********************");
            obj.InsertRec("ab");
            Console.WriteLine("***********************");
            obj.InsertRec("abcdef");
            Console.WriteLine("***********************");
            obj.InsertRec("abcdef");


            Console.Read();
        }
    }
}
