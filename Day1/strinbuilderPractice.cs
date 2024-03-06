using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1._0
{
    public class strinbuilderPractice
    {
        StringBuilder sb1=new StringBuilder();
        StringBuilder sb2=new StringBuilder();

        public void useStingBuilder()
        {
            sb1.Append('-', 10);
            sb1.AppendLine();
            sb1.Append("WELCOME TO STRINGBUILDR PRCTICE Line 1");
            sb1.AppendLine();
            sb1.Append('*',10);

            


            Console.WriteLine(sb1);


            sb2.Append('-', 10).AppendLine().Append("WELCOME TO STRINGBUILDR PRCTICE Line 2").AppendLine().Append('-', 10);
            Console.WriteLine(sb2);

 }



    }
}
