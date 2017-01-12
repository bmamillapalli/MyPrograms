using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    class ArraysChapter
    {
        public void CheckForUniqueness()
        {
            Console.WriteLine("Enter The String You want to Check for Uniqueness");
            string str = Console.ReadLine();
            bool found = false;

            if (str.Length > 256)
                return;

            bool[] ch = new bool[256];

            for (int ind = 0; ind < str.Length; ind++)
            {
                int num = str[ind];
                if (ch[num])
                {
                    found = true;
                    break;
                }
                ch[num] = true;
            }


            /*           
                            //int checker = 0;
                            //for (int i = 0; i < str.Length; i++)
                            //{
                            //    int val = str[i] - 'a';
                            //    if ((checker & (1 << val)) > 0)
                            //        found = false;
                            //    checker |= (1 << val);
                            //}

                            for (int i = 0; i < (str.Length - 1); i++)
                            {
                                for (int j = (i + 1); j < (str.Length); j++)
                                {
                                    //Console.WriteLine("(i,j) -> " + str[i] + "," + str[j]);
                                    if (str[i].Equals(str[j]))
                                    {
                                        found = true;
                                        break;
                                    }

                                }
                            }
            */
            if (found == true)
                Console.WriteLine("Match found");
            else
                Console.WriteLine("Match Not found");


        }
    }

    class ReverseWithPointer
    {
        public void ReverseString()
        {
            Console.WriteLine("Enter A string");
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            int j = str.Length - 1;

            for (int k = 0; k < j; k++, j--)
            {
                char temp = ch[k];
                ch[k] = ch[j];
                ch[j] = temp;
            }
            for (int l = 0; l < str.Length; l++)
            {
                Console.Write(ch[l]);
            }

        }
    }

    class Anagram
    {
        public void AnagramMethod()
        {
            Console.WriteLine("Enter The Word:");
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            bool[] used = new bool[str.Length];
            int level = 0;

            StringBuilder sb = new StringBuilder();
            Permutation(str.Length, ch, level, used, sb);
        }
        public void Permutation(int strLength, char[] ch, int level, bool[] used, StringBuilder sb)
        {
            if (level == strLength)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            for (int i = 0; i < strLength; ++i)
            {
                if (used[i])
                    continue;

                sb.Append(ch[i]);
                used[i] = true;
                Permutation(strLength, ch, level + 1, used, sb);
                used[i] = false;
                sb.Length = sb.Length - 1;
            }

        }




    }

    class StringLength
    {
        public void StrLength()
        {
            int k = 0;
            try
            {
                Console.WriteLine("Enter A String:");
                string str = Console.ReadLine();


                char[] c = str.ToCharArray();

                int dd = 0;
                for (int i = 0; i >= 0; i++, k++)
                {
                    dd++;
                    c[i] = str[i];
                }
            }
            catch (Exception)
            {
                Console.WriteLine("the length is: " + k);
            }
        }
    }

    class UpperCaseToLowerCaseViceVerse
    {
        public void u2LAndL2U()
        {
            Console.WriteLine("Select one:");
            Console.WriteLine("1. ToLowerCase");
            Console.WriteLine("2. ToUpperCase");
            Console.WriteLine("3. Flip");
            int sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:

                    Console.WriteLine("Enter A String:");
                    string lower = Console.ReadLine();

                    char[] lch = lower.ToCharArray();

                    string l2upper = "";
                    for (int i = 0; i < lower.Length; i++)
                    {
                        if (lch[i] >= 65 && lch[i] <= 90)
                        {
                            l2upper = l2upper + (char)(lch[i] + 32);
                        }
                        else if (lch[i] >= 97 && lch[i] <= 122)
                        {
                            l2upper = l2upper + lch[i];
                        }
                        else
                            l2upper = l2upper + lch[i];

                    }
                    Console.WriteLine("UpperCase: " + l2upper);

                    break;
                case 2:

                    Console.WriteLine("Enter A String:");
                    string upper = Console.ReadLine();

                    char[] uch = upper.ToCharArray();

                    string u2lower = "";
                    for (int i = 0; i < upper.Length; i++)
                    {
                        if (uch[i] >= 65 && uch[i] <= 90)
                        {
                            u2lower = u2lower + uch[i];
                        }
                        else if (uch[i] >= 97 && uch[i] <= 122)
                        {
                            u2lower = u2lower + (char)(uch[i] - 32);
                        }
                        else
                            u2lower = u2lower + uch[i];

                    }
                    Console.WriteLine("Lowercase: " + u2lower);
                    break;
                case 3:
                    Console.WriteLine("Enter A String:");
                    string str = Console.ReadLine();

                    char[] ch = str.ToCharArray();

                    string nstr = "";
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (ch[i] >= 65 && ch[i] <= 90)
                        {
                            nstr = nstr + (char)(ch[i] + 32);
                        }
                        else if (ch[i] >= 97 && ch[i] <= 122)
                        {
                            nstr = nstr + (char)(ch[i] - 32);
                        }
                        else
                            nstr = nstr + ch[i];
                    }
                    Console.WriteLine("Flipped Case Word: " + nstr);


                    break;
                default:
                    break;
            }
        }
    }

    class RemoveSpecificCharactors
    {
        public void remove()
        {
            Console.WriteLine("Enter A String:");
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();

            Console.WriteLine("Enter A char:");
            char ch = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (ch != str[i])
                {
                    Console.Write(str[i]);

                }
            }
        }
        public void RemoveMany()
        {
            Console.WriteLine("Enter A String:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter A char:");
            string rstr = Console.ReadLine();

            bool[] verify = new bool[256];
            char[] rch = rstr.ToCharArray();

            for (int i = 0; i < rstr.Length; i++)
            {
                verify[rch[i]] = true;
            }
            for (int j = 0; j < str.Length; j++)
            {
                if (!verify[str[j]])
                    Console.Write(str[j]);
            }
        }
    }

    class WhiteSpacetrimming
    {
        public void AllWhitespacetrimming()
        {
            Console.WriteLine("Enter A sentence:");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    Console.Write(str[i]);
            }
        }
        public void WhitespaceStartEnd()
        {
            Console.WriteLine("Enter A sentence:");
            string str = Console.ReadLine();
            int i = 0, j = 0;
            for (i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')
                    break;
            }
            for (j = (str.Length - 1); j >= 0; j--)
            {
                if (str[j] != ' ')
                    break;
            }
            for (int k = i; k <= j; k++)
            {
                Console.Write(str[k]);
            }
        }
    }

    class AlphabetCount
    {
        public void Count()
        {
            Console.WriteLine("Enter A sentence:");
            string str = Console.ReadLine();

            int[] count = new int[256];
            char[] ch = str.ToCharArray();

            foreach (char c in str)
            {
                count[c]++;
            }

            int i = 0;
            foreach (char c in str)
            {
                if (count[c] != 0)
                {
                    Console.WriteLine(ch[i++] + "->" + count[c] + ", ");
                    count[c] = 0;
                }
            }

            //    int i, j, k, c = 0, w;

            //    string s = "abc";

            //    char[] z = new char[s.Length];

            //    for (w = 0; w < s.Length; w++)
            //        z[w] = s[w];

            //    for (i = 0; i < w; i++)
            //    {
            //        char ch = z[i];
            //        for (j = i + 1; j < w; j++)
            //        {
            //            if (z[j] == ch)
            //            {
            //                for (k = j; k < (w - 1); k++)
            //                    z[k] = z[k + 1];
            //                w--;
            //                j = i;
            //            }
            //        }
            //    }

            //    int[] t = new int[w];

            //    for (i = 0; i < w; i++)
            //    {
            //        for (j = 0, c = 0; j < s.Length; j++)
            //        {
            //            if (z[i] == s[j])
            //                c++;
            //        }
            //        t[i] = c;
            //        Console.Write(z[i] + "=" + c + ",");
            //    }
        }
    }

    class WordsCount
    {
        public void CountWords()
        {

            string str = " My  Name  is  Brahmi  Kowsik  Mamillapalli";
            int count = 0;
            int spaces = 0;
            /*for (int i = 0; i < str.Length; i++)
            {
                if (((str[i] != ' ') && (i > 0)) && (str[i - 1] == ' ') || (str[0]!=' ' && i==0))
                    count++;
            }
            */

            for (int i = 0; i < str.Length; i++)
            {
                count++;
                if (i > 0 && str[i - 1] == ' ')
                    spaces++;

                while (str[i] != ' ' && i < str.Length - 1)
                    i++;
            }

            Console.WriteLine("The Number Of Words:" + count);
            Console.WriteLine("The Number Of spaces:" + spaces);

        }
    }

    class RevereseEveryWord
    {
        public void WordReverse()
        {
            string str = "my Name is Bramz";
            int j = 0;
            int k = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    for (k = i - 1; k >= 0; k--)
                    {
                        char c = str[k];
                        Console.Write(str[k]);
                    }

                    j = i + 1;
                }
            }
        }
    }

    class SpaceReplace
    {
        public void spaces()
        {
            string str = "    Brahmi Kowsik Mamillapalli    ";

            int len = str.Length;

            int spaceCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }

            int newLength = len + (spaceCount * 2);

            char[] ch = new char[newLength];

            int k = 0;

            for (int j = 0; j < ch.Length; j++)
            {
                if (str[k] == ' ')
                {
                    ch[j++] = '%';
                    ch[j++] = '2';
                    ch[j] = '0';
                }
                else
                {
                    ch[j] = str[k];

                }
                k++;
            }

            String newstr = new String(ch);

            Console.WriteLine("Final -->" + newstr);

        }
    }

    class StringPattern
    {
        public void stringpatterns()
        {
            string s = "aaaabbbcdfg";

            string newstr = "";

            int count = 1, i = 1;

            for (int j = 0; j < s.Length; j++)
            {
                if (i < s.Length && s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    newstr = newstr + s[i - 1] + count;
                    count = 1;
                }
                i++;
            }

            Console.WriteLine("Output: " + newstr);
        }
    }

    class Rotation
    {
        public void rotate()
        {
            //int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[,] matrix = { { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 } };
            int n = 8;

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("matrix[" + k + ", " + j + "] " + matrix[k, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------\n");

            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;

                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    // save top
                    int top = matrix[first, i];

                    // left -> top
                    matrix[first, i] = matrix[last - offset, first];

                    // bottom -> left
                    matrix[last - offset, first] = matrix[last, last - offset];

                    // right -> bottom
                    matrix[last, last - offset] = matrix[i, last];

                    // top -> right
                    matrix[i, last] = top;
                }
            }
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("matrix[" + k + ", " + j + "] " + matrix[k, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class MatrixZero
    {
        public void MatZero()
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 0 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //int[,] matrix = { { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 }, { 1, 2, 3, 4, 5, 6, 7, 8 } };
            int n = 4;
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] col = new bool[matrix.GetLength(1)];

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("matrix[" + k + ", " + j + "] " + matrix[k, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------\n");


            for(int i = 0; i < n; i++){
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
                }
            }

            for( int i = 0; i < n; i++){
                for (int j = 0; j < n; j++)
                {
                    if (row[i] || col[j])
                    {
                        matrix[i, j] = 0;
                    }

                }
            }


            Console.WriteLine("\n-------------------------------------------------------------------------------------\n");
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("matrix[" + k + ", " + j + "] " + matrix[k, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class StringRotation
    {
        public bool StrRotate()
        {
            string s1 = "waterBottle";
            string s2 = "erBottlewat";

            int len = s1.Length;
            if(len == s2.Length && len > 0)
            {
                string s1s1 = s1 + s1;
                return s1s1.Contains(s2);
            }
            return false;
        }
    }

    class ArrayAndStrings
    {
        static void Main(string[] args)
        {
            ArraysChapter Arraysobject = new ArraysChapter();
            ReverseWithPointer Arraysobject1 = new ReverseWithPointer();
            Anagram Arraysobject2 = new Anagram();
            StringLength Arraysobject3 = new StringLength();
            UpperCaseToLowerCaseViceVerse Arraysobject4 = new UpperCaseToLowerCaseViceVerse();
            RemoveSpecificCharactors Arraysobject5 = new RemoveSpecificCharactors();
            WhiteSpacetrimming Arraysobject6 = new WhiteSpacetrimming();
            WordsCount Arraysobject7 = new WordsCount();
            RevereseEveryWord Arraysobject8 = new RevereseEveryWord();
            AlphabetCount Arraysobject9 = new AlphabetCount();
            SpaceReplace Arrayobject10 = new SpaceReplace();
            StringPattern Arrayobject11 = new StringPattern();
            Rotation Arrayobject12 = new Rotation();
            MatrixZero Arrayobject13 = new MatrixZero();
            StringRotation Arrayobject14 = new StringRotation();




            //Arraysobject.CheckForUniqueness();
            //Arraysobject1.ReverseString();
            //Arraysobject2.AnagramMethod();
            //Arraysobject3.Integer2String();
            //Arraysobject3.StringLength();
            //Arraysobject4.u2LAndL2U();
            //Arraysobject5.remove();
            //Arraysobject5.RemoveMany();
            //Arraysobject6.AllWhitespacetrimming();
            //Arraysobject6.WhitespaceStartEnd();
            //Arraysobject7.CountWords();
            //Arraysobject8.WordReverse();
            //Arraysobject9.Count();
            //Arrayobject10.spaces();
            //Arrayobject11.stringpatterns();
            //Arrayobject12.rotate();
            //Arrayobject13.MatZero();
            Console.WriteLine(Arrayobject14.StrRotate());


            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}

