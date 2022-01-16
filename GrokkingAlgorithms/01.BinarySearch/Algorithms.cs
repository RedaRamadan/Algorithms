namespace _01.BinarySearch
{
    public class Algorithms
    {

        // BinarySearch algorithm implemented using while loop.
        public static int BinarySearch(int[] numbers, int key)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (end >= start)
            {
                int mid = (start + end) / 2;

                if (numbers[mid] == key)
                {
                    return mid;
                }
                else if (numbers[mid] > key)
                {
                    end = mid - 1;
                }
                else if (numbers[mid] < key)
                {
                    start = mid + 1;
                }
            }

            return -1;
        }


        // BinarySearch algorithm implemented using recursion.
        public static int BinarySearchRecursive(int[] numbers, int key)
        {
            int InternalBinarySearchRecursive(int[] numbers, int key, int start, int end)
            {
                if (start > end)
                    return -1;

                int mid = (start + end) / 2;

                if (numbers[mid] == key)
                {
                    return mid;
                }
                else if (numbers[mid] > key)
                {
                    return InternalBinarySearchRecursive(numbers, key, start, mid - 1);
                }
                else
                {
                    return InternalBinarySearchRecursive(numbers, key, mid + 1, end);
                }
            }

            return InternalBinarySearchRecursive(numbers, key, 0, numbers.Length - 1);
        }



        // =========================================================
        // ==== LeetCode Applications on BinarySearch algorithm ==== 
        // =========================================================
        // https://leetcode.com/problems/sqrtx/
        // Sqrt(x):
        //      Given a non-negative integer x, compute and return the square root of x.
        //      Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
        //      Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.
        //      Example 1:              Input: x = 4,   Output: 2
        //      Example 1:              Input: x = 8,   Output: 2,  Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
        //      Hint #1:                Try exploring all integers.
        //      Hint #2:                Use the sorted property of integers to reduced the search space.

        public static int Sqrt(int key)
        {
            long start = 0;
            long end = key;
            long answer = -1;

            while (end >= start)
            {
                long mid = (start + end) / 2;

                if ((mid * mid) == key)
                {
                    answer = mid;
                    break;
                }
                else if ((mid * mid) < key)
                {
                    answer = mid;
                    start = mid + 1;
                }
                else if ((mid * mid) > key)
                {
                    end = mid - 1;
                }
            }

            return (int)answer;
        }
    }
}