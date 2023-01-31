namespace ArrayUtilities
{
    public static class ArrayUtils
    {
        ///<summary>
        ///Finds the average of an array by adding and dividing by the length
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the average of the numbers in the array
        ///</returns>
        public static double Average(int[] array)
        {

            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            double result = sum / array.Length;
            return result;
        }

        ///<summary>
        ///Finds the average of an array by adding and dividing by the length
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the average of the numbers in the array
        ///</returns>
        public static double Average(double[] array)
        {
            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            double result = sum / array.Length;
            return result;
        }

        ///<summary>
        ///Finds the maximum number of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the maximum
        ///</returns>
        public static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        ///<summary>
        ///Finds the maximum number of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the maximum
        ///</returns>
        public static double Max(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        ///<summary>
        ///Finds the minimum number of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the minimum
        ///</returns>
        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        ///<summary>
        ///Finds the minimum number of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the minimum
        ///</returns>
        public static double Min(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        ///<summary>
        ///Adds all of the numbers of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the sum
        ///</returns>
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        ///<summary>
        ///Adds all of the numbers of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the sum
        ///</returns>
        public static double Sum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        ///<summary>
        ///Multiplies all of the numbers of an array 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the product
        ///</returns>
        public static int Product(int[] array)
        {
            int sum = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum *= array[i];
            }
            return sum;
        }
        public static double Product(double[] array)
        {
            ///<summary>
            ///Multiplies all of the numbers of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the product
            ///</returns>
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum *= array[i];
            }
            return sum;
        }

        ///<summary>
        ///Arranges all of the numbers of an array from least to greatest 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the new organized array
        ///</returns>
        public static int[] SortAscend(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        ///<summary>
        ///Arranges all of the numbers of an array from least to greatest 
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the new organized array
        ///</returns>
        public static double[] SortAscend(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        ///<summary>
        ///Arranges all of the numbers of an array from greatest to least greatest
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the new organized array
        ///</returns>
        public static int[] SortDescend(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        ///<summary>
        ///Arranges all of the numbers of an array from greatest to least greatest
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the new organized array
        ///</returns>
        public static double[] SortDescend(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        // The following methods are the additional methods

        ///<summary>
        ///Find the length of an array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the number of items in the array
        ///</returns>
        public static int GetArrayLength(int[] array)
        {
            int length = 0;
            foreach (int num in array)
            {
                length++;
            }
            return length;
        }

        ///<summary>
        ///Find the length of an array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the number of items in the array
        ///</returns>
        public static int GetArrayLength(double[] array)
        {
            int length = 0;
            foreach (int num in array)
            {
                length++;
            }
            return length;
        }

        ///<summary>
        ///Copies the contents of an array to another array
        ///</summary>
        ///<param name ="array">The array you want to be copied</param>
        ///<param name ="newArray">The array you want to copy to</param>
        ///<returns>
        ///Returns the copied array
        ///</returns>
        public static int[] Copy(int[] array, int[] newArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        ///<summary>
        ///Copies the contents of an array to another array
        ///</summary>
        ///<param name ="array">The array you want to be copied</param>
        ///<param name ="newArray">The array you want to copy to</param>
        ///<returns>
        ///Returns the copied array
        ///</returns>
        public static double[] Copy(double[] array, double[] newArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        ///<summary>
        ///Reverses the contents of the array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the reversed array
        ///</returns>
        public static int[] Reverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }

        ///<summary>
        ///Reverses the contents of the array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the reversed array
        ///</returns>
        public static double[] Reverse(double[] array)
        {
            double[] newArray = new double[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }

        ///<summary>
        ///Clears the contents of the array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the cleared array
        ///</returns>
        public static int[] Clear(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            return array;
        }

        ///<summary>
        ///Clears the contents of the array
        ///</summary>
        ///<param name ="array">The array</param>
        ///<returns>
        ///Returns the cleared array
        ///</returns>
        public static double[] Clear(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            return array;
        }
    }

}