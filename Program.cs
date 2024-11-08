namespace samogłoski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.countVovels("aab"));
            Console.WriteLine(StringHelper.removeRepetitions("aaabba"));
        }
    }

    public static class StringHelper
    {
        public static int countVovels(string text)
        {
            int numberOfVovels = 0;

            if(text == null || string.IsNullOrEmpty(text))
            {
                return numberOfVovels;
            }
            string vovels = "aąeęiouóyAĄEĘIOUÓY";

            foreach(char character in text)
            {
                foreach(char vovel in vovels) 
                {
                    if(character == vovel)
                    {
                        numberOfVovels++;
                    }
                }
            }

            return numberOfVovels;
        }

        public static string removeRepetitions(string text)
        {
            string stringWithoutRepetitions = text[0].ToString();

            if (text == null || string.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            char currentCharacter = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                if(i < text.Length - 1 && currentCharacter != text[i + 1])
                {
                    stringWithoutRepetitions += text[i + 1];
                }

                currentCharacter = text[i];
            }

            return stringWithoutRepetitions;
        }
    }
}
