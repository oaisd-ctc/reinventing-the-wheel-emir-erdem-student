namespace StringUtilities
{
    public static class StringUtils
    {
        ///<summary>
        ///Uppercases the entire string
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns uppercased string 
        ///</returns>

        public static string ToUpper(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    result = result + (char)(input[i] - 'a' + 'A');
                }
                else
                {
                    result = result + input[i];
                }
            }
            return result;
        }


        ///<summary>
        ///Lowercases the entire string
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns lowercased string 
        ///</returns>

        public static string ToLower(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    result = result + (char)(input[i] - 'A' + 'a');
                }
                else
                {
                    result = result + input[i];
                }
            }
            return result;

        }

        ///<summary>
        ///Finds the length of a string
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns the reversed array
        ///</returns>

        public static int Length(string input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output++;
            }
            return output;
        }

        ///<summary>
        ///Reverses the word 
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns the reversed string
        ///</returns>
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

        ///<summary>
        ///Counts the amount of vowels in a string 
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns the vowel count 
        ///</returns>

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

        ///<summary>
        ///Counts the amount of consonants in a string 
        ///</summary>
        ///<param name ="input">The string</param>
        ///<returns>
        ///Returns the consonant count 
        ///</returns>

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

        ///<summary>
        ///Checks a string to see if specified character is included 
        ///</summary>
        ///<param name ="Word">The string</param>
        ///<param name ="Letter">The character</param>
        ///<returns>
        ///Returns if the word contains the specified character 
        ///</returns>

        public static bool HasLetter(string Word, char Letter)
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

        ///<summary>
        ///Adds spacing between the words 
        ///</summary>
        ///<param name ="word">The string</param>
        ///<returns>
        ///Returns the spaced out string 
        ///</returns>
        public static string spaceOut(string word)
        {
            string nice = "";
            foreach (char letter in word)
            {
                nice = nice + letter + " ";
            }
            return nice;
        }

        ///<summary>
        ///Checks to see if string ends with specified character 
        ///</summary>
        ///<param name ="word">The string</param>
        ///<param name ="letter">The character</param>
        ///<returns>
        ///Returns a bool determining whether the word ends with the desired character
        ///</returns>
        public static bool EndsWith(string word, char letter)
        {
            int length = word.Length;
            bool endingWith = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter && word.Length == length)
                {
                    endingWith = true;
                }
            }
            return endingWith;
        }

        ///<summary>
        ///Checks to see if both strings are same 
        ///</summary>
        ///<param name ="word">The string</param>
        ///<param name ="word2">The second string</param>
        ///<returns>
        ///Returns a bool determining whether the two strings are the same or not 
        ///</returns>
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

        ///<summary>
        ///Checks to find the character that the user wants to remove
        ///</summary>
        ///<param name ="word">The string</param>
        ///<param name ="letterRemove">The character to be removed</param>
        ///<returns>
        ///Returns the new word without the character
        ///</returns>
        public static string Remove(string word, char letterRemove)
        {
            string newWord = "";
            foreach (char letter in word)
            {
                if (letter == letterRemove)
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