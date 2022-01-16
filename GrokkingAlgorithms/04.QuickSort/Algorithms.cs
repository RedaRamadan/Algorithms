namespace _04.QuickSort
{
    public class Algorithms
    {
        public static void Quicksort(int[] array)
        {
            void Swap(int[] array, int a, int b)
            {
                int temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }

            void Quicksort(int[] array, int start, int end)
            {
                if (start >= end)
                {
                    return;
                }
                else
                {
                    int pivot = Partition(array, start, end);
                    Quicksort(array, start, pivot - 1);
                    Quicksort(array, pivot + 1, end);

                }
            }

            int Partition(int[] array, int start, int end)
            {
                // [https://www.youtube.com/watch?v=MZaf_9IZCrc]
                // Excellent youtube video, explains how the Partition function should work, very helpful.

                // 1. Pick pivot (last element in the array slice, array[end])
                // 2. Create variable i, with initially, (i = start -1), outside the array slice range.
                //    (usage of i): to mark the last item less than the chosen pivot.
                // 3. Iterate over the array from [start] till [end - 1], with variable (j)
                //        Compare, each element with the pivot value,
                //            If found element less than the pivot,
                //                Increase (i) by 1,
                //                Swap element at (i) and element at (j)
                //                Keep doing that till the end of the loop.
                // 4. After the loop ends, (i) points to the last element less than the pivot, 
                //    Swap (i++) with the (end: original pivot position in the array) 
                // 5. Return (i) the new position of the pivot.

                int pivot = array[end];
                int i = start - 1;

                for (int j = start; j < end; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }

                i++;
                Swap(array, i, end);
                return i;
            }

            Quicksort(array, 0, array.Length - 1);
        }
    }
}