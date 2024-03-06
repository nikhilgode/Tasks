namespace CharCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "maharashtra";
            printoccurence(s);
            
        }


        public static void printoccurence(String s)
        {
            char[] sortedString = s.ToCharArray();
            Array.Sort(sortedString); // Sort the characters for easier counting

            int l = sortedString.Length;
            int charCount = 1; // Initialize the character count
            for (int i = 0; i < l; i++)
            {
                // Check if the current character is the same as the next one
                if (i < l - 1 && sortedString[i] == sortedString[i + 1])
                {
                    charCount++; // If yes, increment the character count
                }
                else
                {
                    Console.WriteLine(sortedString[i] + "=" + charCount); // If no, print the character and its count
                    charCount = 1; // Reset the character count for the next character
                }

            }
        }
    }
}
