using System.Runtime.CompilerServices;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "qwertyuiop";
            string s2 = "poiiuytewq";

            isAnagrm(s1, s2);
        }


        public static void isAnagrm(string str1 , string str2)
        {
            

            if(str1.Length != str2.Length)
            {
                Console.WriteLine("NOT ANAGRAM...!");
                return;
            }

            char[] s1 = str1.ToCharArray();
            Array.Sort(s1);

            char[] s2 = str2.ToCharArray();
            Array.Sort(s2);


            for(int i = 0; i < s1.Length; i++) 
            {
             
                    if (s1[i] != s2[i])
                    {
                       Console.WriteLine("NOT ANAGRAM...!");
                       return;
                    }

                   
                
            }

            Console.WriteLine("ANAGRAM...!");


        }
    }
}
