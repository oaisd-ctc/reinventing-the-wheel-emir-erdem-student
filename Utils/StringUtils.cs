namespace StringUtilities
{
    public static class StringUtils
    {
        // public static string ToUpper(string input)
        // {
        //     string output = "";
        //     for (int i = 0; i < input.Length; i++)
        //     {
        //         if ()
        //         {

        //         }
        //     }
        // }

        // public static string ToLower()
        // {

        // }

        public static int Length(string input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output++;
            }
            return output;
        }

        public static string Reverse(string input)
        {
            int length = input.Length - 1;
            string reversie = "";
            char[] array = new char[input.Length];
            while (length >= 0)
            {

                reversie = reversie + input[length];
                length--;
            }
            return reversie;
        }

        public static int CountVowels(string input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    output++;

                }

            }
            return output;
        }

        public static int CountConsonants(string input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {

                }
                else
                {
                    output++;
                }

            }
            return output;
        }

        public static bool HasLetter(String Word, Char Letter)
        {

            int hasletter = 0;
            bool letterItHas = false;
            for (int i = 0; i < Word.Length; i++)
            {
                if (Letter == Word[i])
                {
                    hasletter++;
                }

            }
            if (hasletter > 0)
            {
                letterItHas = true;

            }
            return letterItHas;

        }

        // The following methods are the additional methods

        public static string spaceOut(string word)
        {
            string nice = "";
            foreach (char letter in word)
            {
                nice = nice + letter + " ";
            }
            return nice;
        }
        public static bool EndsWith(string word, char letter)
        {
            int length = word.Length;
            bool endingWith = false;
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == letter && word.Length == length)
                {
                    endingWith = true;
                }
            }
            return endingWith;
        }
        public static bool Compare(string word, string word2)
        {
            int letterAmount = 0;
            if (word.Length != word2.Length)
            {
                return false;
            }
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == word2[i])
                {
                    letterAmount++;
                }

            }
            if (letterAmount == word.Length)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        public static string Remove(string word, char letterRemove)
        {
            
            string newWord = "";
            foreach(char letter in word)
            {
                if(letter == letterRemove)
                {
                    newWord = newWord + "";
                }
                else
                {
                    newWord += letter;
                }
                
            }
            return newWord;
        }
    }
}