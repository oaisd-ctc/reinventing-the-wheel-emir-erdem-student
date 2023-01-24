namespace MathUtilities
{
    public static class MathUtils
    {
        public static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static double Min(double x, double y)
        {
            if (x < y)
            {
                return x;
            }
            else if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static float Min(float x, float y)
        {
            if (x < y)
            {
                return x;
            }
            else if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static int Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static double Max(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static float Max(float x, float y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static float Subtract(float x, float y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static float Divide(float x, float y)
        {
            return x / y;
        }
        public static int AbsValue(int x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            else
            {
                return x;
            }
        }
        public static double AbsValue(double x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            else
            {
                return x;
            }
        }
        public static float AbsValue(float x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            else
            {
                return x;
            }
        }
        public static int Square(int x)
        {
            return x * x;
        }
        public static double Square(double x)
        {
            return x * x;
        }
        public static float Square(float x)
        {
            return x * x;
        }
        public static int Power(int x, int y)
        {
            int sum = 1;
            for (int i = 0; i < y; i++)
            {
                sum *= x;
            }
            return sum;
        }
        public static double Power(double x, double y)
        {
            double sum = 1;
            for (int i = 0; i < y; i++)
            {
                sum *= x;
            }
            return sum;
        }
        public static float Power(float x, float y)
        {
            float sum = 1;
            for (int i = 0; i < y; i++)
            {
                sum *= x;
            }
            return sum;
        }

        public static int Round(float x)
        {
            return (int)x;
        }
        public static int Round(double x)
        {
            return (int)x;
        }
        public static int Round(decimal x)
        {
            return (int)x;
        }
        public static double Cubrt(int x)
        {
            
           
        }

    }
}