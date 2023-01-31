namespace MathUtilities
{
    public static class MathUtils
    {
        ///<summary>
        ///Finds the minimum of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The minimum between the two. 
        ///</returns>
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
        ///<summary>
        ///Finds the minimum of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The minimum between the two. 
        ///</returns>
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

        ///<summary>
        ///Finds the minimum of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The minimum between the two. 
        ///</returns>
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

        ///<summary>
        ///Finds the max of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The maximum between the two. 
        ///</returns>
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

        ///<summary>
        ///Finds the max of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The maximum between the two. 
        ///</returns>
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

        ///<summary>
        ///Finds the max of the two
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The maximum between the two. 
        ///</returns>
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

        ///<summary>
        ///Finds the sum of two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The sum of the two. 
        ///</returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        ///<summary>
        ///Finds the sum of two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The sum of the two. 
        ///</returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }

        ///<summary>
        ///Finds the sum of two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The sum of the two. 
        ///</returns>
        public static float Add(float x, float y)
        {
            return x + y;
        }

        ///<summary>
        ///Finds the result of two numbers being subtracted
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The result of the first number being subtracted by the second. 
        ///</returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        ///<summary>
        ///Finds the result of two numbers being subtracted
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The result of the first number being subtracted by the second. 
        ///</returns>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        ///<summary>
        ///Finds the result of two numbers being subtracted
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///The result of the first number being subtracted by the second. 
        ///</returns>
        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        ///<summary>
        ///Finds the product of the two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Product of the formula x * y 
        ///</returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        ///<summary>
        ///Finds the product of the two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Product of the formula x * y
        ///</returns> 
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        ///<summary>
        ///Finds the product of the two numbers
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Product of the formula x * y
        ///</returns> 
        public static float Multiply(float x, float y)
        {
            return x * y;
        }

        ///<summary>
        ///Finds the result of the two numbers once divided
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Result of the formula x / y
        ///</returns> 
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        ///<summary>
        ///Finds the result of the two numbers once divided
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Result of the formula x / y
        ///</returns> 
        public static double Divide(double x, double y)
        {
            return x / y;
        }

        ///<summary>
        ///Finds the result of the two numbers once divided
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The second number.</param>
        ///<returns>
        ///Result of the formula x / y
        ///</returns>
        public static float Divide(float x, float y)
        {
            return x / y;
        }

        ///<summary>
        ///Finds the absolute value of a number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Result of |x|
        ///</returns>
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

        ///<summary>
        ///Finds the absolute value of a number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Result of |x|
        ///</returns>
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

        ///<summary>
        ///Finds the absolute value of a number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Result of |x|
        ///</returns>
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

        ///<summary>
        ///Finds the result of the number raised to the nth power
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The exponent.</param>
        ///<returns>
        ///Result of the formula x^y 
        ///</returns>
        public static int Power(int x, int y)
        {
            int result = 1;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            if (y < 0)
            {
                for (int i = -1; i >= y; i--)
                {
                    result /= x;
                }
            }
            return result;
        }

        ///<summary>
        ///Finds the result of the number raised to the nth power
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The exponent.</param>
        ///<returns>
        ///Result of the formula x^y 
        ///</returns>
        public static double Power(double x, double y)
        {
            double result = 1;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            if (y < 0)
            {
                for (int i = -1; i >= y; i--)
                {
                    result /= x;
                }
            }
            return result;

        }

        ///<summary>
        ///Finds the result of the number raised to the nth power
        ///</summary>
        ///<param name ="x">The first number.</param>
        ///<param name ="y">The exponent.</param>
        ///<returns>
        ///Result of the formula x^y 
        ///</returns>
        public static float Power(float x, float y)
        {
            float result = 1;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            if (y < 0)
            {
                for (int i = -1; i >= y; i--)
                {
                    result /= x;
                }
            }
            return result;
        }

        ///<summary>
        ///Finds whether to round up or down
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
        public static int Round(float x)
        {
            int roundeddown = (int)x;

            if (x - roundeddown >= 0.5)
            {
                roundeddown++;
            }
            return roundeddown;
        }

        ///<summary>
        ///Finds whether to round up or down
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
        public static int Round(double x)
        {
            int roundeddown = (int)x;

            if (x - roundeddown >= 0.5)
            {
                roundeddown++;
            }
            return roundeddown;
        }

        ///<summary>
        ///Finds whether to round up or down
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded number
        ///</returns>
        public static int Round(decimal x)
        {
            return (int)x;
        }

        ///<summary>
        ///Finds the square root of the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the root
        ///</returns>
        public static decimal Sqrt(decimal number)
        {
            decimal temp = 0;
            decimal sqrt = number / 2;

            while (sqrt != temp)
            {
                temp = sqrt;
                sqrt = (number / temp + temp) / 2;
            }
            return sqrt;
        }

        ///<summary>
        ///Finds the square root of the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the root
        ///</returns>
        public static double Sqrt(double number)
        {
            double temp = 0;
            double sqrt = number / 2;

            while (sqrt != temp)
            {
                temp = sqrt;
                sqrt = (number / temp + temp) / 2;
            }
            return sqrt;
        }

        // The following methods are the additional methods

        ///<summary>
        ///Finds the result of rounding down the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded down number
        ///</returns>
        public static int Floor(double number)
        {
            return (int)number;
        }

        ///<summary>
        ///Finds the result of rounding down the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded down number
        ///</returns>
        public static int Floor(float number)
        {
            return (int)number;
        }

        ///<summary>
        ///Finds the result of rounding down the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded down number
        ///</returns>
        public static int Floor(decimal number)
        {
            return (int)number;
        }

        ///<summary>
        ///Finds the result of rounding up the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded up number
        ///</returns>
        public static int Ceiling(double number)
        {
            double answer = number + 1;
            return (int)answer;
        }

        ///<summary>
        ///Finds the result of rounding up the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded up number
        ///</returns>
        public static int Ceiling(float number)
        {
            double answer = number + 1;
            return (int)answer;
        }

        ///<summary>
        ///Finds the result of rounding up the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the rounded up number
        ///</returns>
        public static int Ceiling(decimal number)
        {
            decimal answer = number + 1;
            return (int)answer;
        }

        ///<summary>
        ///Finds the result of squaring the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the squared number
        ///</returns>
        public static int Square(int x)
        {
            return x * x;
        }

        ///<summary>
        ///Finds the result of squaring the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the squared number
        ///</returns>
        public static double Square(double x)
        {
            return x * x;
        }

        ///<summary>
        ///Finds the result of squaring the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the squared number
        ///</returns>
        public static float Square(float x)
        {
            return x * x;
        }

        ///<summary>
        ///Finds the result of cubing the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the cubed number
        ///</returns>
        public static float Cube(float x)
        {
            return x * x * x;
        }

        ///<summary>
        ///Finds the result of cubing the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the cubed number
        ///</returns>
        public static double Cube(double x)
        {
            return x * x * x;
        }
        
        ///<summary>
        ///Finds the result of cubing the number
        ///</summary>
        ///<param name ="x">The input.</param>
        ///<returns>
        ///Returns the cubed number
        ///</returns>
        public static int Cube(int x)
        {
            return x * x * x;
        }

    }
}