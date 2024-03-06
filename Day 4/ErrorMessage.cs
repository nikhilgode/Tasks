using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public interface IErrorMessage
    {

        void printerrormessage1(String s);
        void printerrormessage2(String s);
    }

    public class AudioError:IErrorMessage
    {
        public void printerrormessage1(String s) 
        {
            Console.WriteLine(s);
        }

        public void printerrormessage2(String s) {  Console.WriteLine(s); }

    }

    public class VideoError:IErrorMessage
    { 
        public void printerrormessage1(String s)
        {
            Console.WriteLine(s);
        }
    
       public void printerrormessage2(String s)
        {
            Console.WriteLine(s);
        }
    }

    public class TvError : AudioError, IErrorMessage
    {
        public void printerrormessage1(String s)
        {
            Console.WriteLine(s);
        }

        // This method is inherited from AudioError
        public void printerrormessage2(String s)
        {
            Console.WriteLine(s);
        }

        // This method is from IErrorMessage interface

        void IErrorMessage.printerrormessage1(string s)
        {
            Console.WriteLine(s);
        }


    }
}
