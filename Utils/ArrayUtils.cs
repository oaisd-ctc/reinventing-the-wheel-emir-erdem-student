namespace ArrayUtilities
{
    public static class ArrayUtils
    {
        public static double Average(int[] array)
        {
            ///<summary>
            ///Finds the average of an array by adding and dividing by the length
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the average of the numbers in the array
            ///</returns>
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            double result = sum / array.Length;
            return result;
        }
        public static double Average(double[] array)
        {
            ///<summary>
            ///Finds the average of an array by adding and dividing by the length
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the average of the numbers in the array
            ///</returns>
            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            double result = sum / array.Length;
            return result;
        }
        public static int Max(int[] array)
        {
            ///<summary>
            ///Finds the maximum number of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the maximum
            ///</returns>
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
        public static double Max(double[] array)
        {
            ///<summary>
            ///Finds the maximum number of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the maximum
            ///</returns>
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
        public static int Min(int[] array)
        {
            ///<summary>
            ///Finds the minimum number of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the minimum
            ///</returns>
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
        public static double Min(double[] array)
        {
            ///<summary>
            ///Finds the minimum number of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the minimum
            ///</returns>
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
        public static int Sum(int[] array)
        {
            ///<summary>
            ///Adds all of the numbers of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the sum
            ///</returns>
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(double[] array)
        {
            ///<summary>
            ///Adds all of the numbers of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the sum
            ///</returns>
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static int Product(int[] array)
        {
            ///<summary>
            ///Multiplies all of the numbers of an array 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the product
            ///</returns>
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
        public static int[] SortAscend(int[] array)
        {
            ///<summary>
            ///Arranges all of the numbers of an array from least to greatest 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the new organized array
            ///</returns>
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
        public static double[] SortAscend(double[] array)
        {
            ///<summary>
            ///Arranges all of the numbers of an array from least to greatest 
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the new organized array
            ///</returns>
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
        public static int[] SortDescend(int[] array)
        {
            ///<summary>
            ///Arranges all of the numbers of an array from greatest to least greatest
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the new organized array
            ///</returns>
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
        public static double[] SortDescend(double[] array)
        {
            ///<summary>
            ///Arranges all of the numbers of an array from greatest to least greatest
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the new organized array
            ///</returns>
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
        public static int GetArrayLength(int[] array)
        {
            ///<summary>
            ///Find the length of an array
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the number of items in the array
            ///</returns>
            int length = 0;
            foreach (int num in array)
            {
                length++;
            }
            return length;
        }
        public static int GetArrayLength(double[] array)
        {
            ///<summary>
            ///Find the length of an array
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the number of items in the array
            ///</returns>
            int length = 0;
            foreach (int num in array)
            {
                length++;
            }
            return length;
        }
        public static int[] Copy(int[] array, int[] newArray)
        {
            ///<summary>
            ///Copies the contents of an array to another array
            ///</summary>
            ///<param name ="array">The array you want to be copied</param>
            ///<param name ="newArray">The array you want to copy to</param>
            ///<returns>
            ///Returns the copied array
            ///</returns>
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        public static double[] Copy(double[] array, double[] newArray)
        {
            ///<summary>
            ///Copies the contents of an array to another array
            ///</summary>
            ///<param name ="array">The array you want to be copied</param>
            ///<param name ="newArray">The array you want to copy to</param>
            ///<returns>
            ///Returns the copied array
            ///</returns>
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        public static int[] Reverse(int[] array)
        {
            ///<summary>
            ///Reverses the contents of the array
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the reversed array
            ///</returns>
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }
        public static double[] Reverse(double[] array)
        {
            ///<summary>
            ///Reverses the contents of the array
            ///</summary>
            ///<param name ="array">The array</param>
            ///<returns>
            ///Returns the reversed array
            ///</returns>
            double[] newArray = new double[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }
    }

}