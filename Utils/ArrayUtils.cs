namespace ArrayUtilities
{
    public static class ArrayUtils
    {
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
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
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
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum *= array[i];
            }
            return sum;
        }
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
        public static int GetLength(int[] array)
        {
            int length = 0;
            foreach(int num in array)
            {
                length++;
            }
            return length;
        }
        public static int GetLength(double[] array)
        {
            int length = 0;
            foreach(int num in array)
            {
                length++;
            }
            return length;
        }
    }
}