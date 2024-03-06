using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class BalanceParenthisis
    {

        public void checkBalancParnthisis(String brackets)
        {
            var sapratebrackets = brackets.ToCharArray();

            Stack<Char> s1 = new Stack<Char>();
            bool flag = true;



            for (int i = 0; i < sapratebrackets.Length; i++)
            {
                if (sapratebrackets[i] == '(')
                { s1.Push(')'); }
                else if (sapratebrackets[i] == '{')
                { s1.Push('}'); }
                else if (sapratebrackets[i] == '[')
                { s1.Push(']'); }
                else
                {
                    if (s1.Count == 0)
                    {
                        flag = false;
                        break;
                    }
                    else if (sapratebrackets[i] != s1.Pop())
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if(flag==true)
                Console.WriteLine("Paranthisis Balanced");
            else
                Console.WriteLine("Parenthisis not Balanced");
        }
    }
}
