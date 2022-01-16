namespace _04.DivideAndConquer
{
    public class Algorithms
    {
        public static int SquarePlots(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                return SquarePlots(Math.Min(a, b), Math.Abs(a - b));
            }
        }

        public static int SumArrayByLoops(int[] array)
        {
            int total = 0;

            foreach (var n in array)
            {
                total += n;
            }

            return total;
        }

        public static int SumArrayByRecursive(int[] array)
        {
            int SumRecursive(int[] array, int start, int end)
            {
                if (start == end)
                {
                    return array[start];
                }
                else if (end > start)
                {
                    int mid = (start + end) / 2;
                    return SumRecursive(array, start, mid) + SumRecursive(array, mid + 1, end);
                }
                else
                {
                    return 0;
                }
            }

            return SumRecursive(array, 0, array.Length - 1);
        }

        public static int CountItemsByRecursive(int[] array)
        {
            int CountRecursive(int[] array, int start, int end)
            {
                if (start == end)
                {
                    return 1;
                }
                else if (end > start)
                {
                    int mid = (start + end) / 2;
                    return CountRecursive(array, start, mid) + CountRecursive(array, mid + 1, end);
                }
                else
                {
                    return 0;
                }
            }

            return CountRecursive(array, 0, array.Length - 1);
        }

        public static int FindMaxByRecursive(int[] array)
        {
            int FindMaxRecursive(int[] array, int start, int end)
            {
                if (start == end)
                {
                    return array[start];
                }
                else if (end > start)
                {
                    int mid = (start + end) / 2;
                    return Math.Max(FindMaxRecursive(array, start, mid), FindMaxRecursive(array, mid + 1, end));
                }
                else
                {
                    return int.MinValue;
                }
            }

            return FindMaxRecursive(array, 0, array.Length - 1);
        }

        public static int BinarySearchByRecursive(int[] array, int target)
        {
            int BinarySearchRecursive(int[] array, int start, int end, int target)
            {
                if (end >= start)
                {
                    int mid = (start + end) / 2;
                    if (array[mid] == target)
                    {
                        return mid;
                    }
                    else if (array[mid] > target)
                    {
                        return BinarySearchRecursive(array, start, mid - 1, target);
                    }
                    else if (array[mid] < target)
                    {
                        return BinarySearchRecursive(array, mid + 1, end, target);
                    }
                }

                return -1;
            }

            return BinarySearchRecursive(array, 0, array.Length - 1, target);
        }

        
    }
}