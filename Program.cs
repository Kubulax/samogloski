namespace samogłoski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać dowolny łańcuch znaków: ");
            string text = Console.ReadLine();
            Console.WriteLine("Liczba samogłosek w podanym łańcuchu znaków: ");
            Console.WriteLine(StringHelper.countVovels(text));
            Console.WriteLine("Łańcuch znaków po wyeliminowaniu powtarzających się obok siebie znaków: ");
            Console.WriteLine(StringHelper.removeRepetitions(text));
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
            if (text == null || string.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            string stringWithoutRepetitions = text[0].ToString();   

            char currentCharacter = text[0];
            for (int i = 0; i < text.Length -1; i++)
            {
                if(currentCharacter != text[i + 1])
                {
                    stringWithoutRepetitions += text[i + 1];
                }

                currentCharacter = text[i + 1];
            }

            return stringWithoutRepetitions;
        }
    }
}
