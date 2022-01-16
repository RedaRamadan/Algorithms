namespace _04.MergeSort
{
    public class Algorithms
    {
        public static void MergeSort_Inplace(int[] array)
        {
            static void Merge(int[] array, int start, int mid, int end)
            {
                int start2 = mid + 1;

                // Check if the direct merge is already sorted
                if (array[mid] <= array[start2])
                {
                    return;
                }

                while (start <= mid && start2 <= end)
                {
                    // If element 1 is in right place.
                    if (array[start] <= array[start2])
                    {
                        start++;
                    }
                    else
                    {
                        int value = array[start2];
                        int index = start2;

                        // Shift all the elements between element1 and element2, right by 1.
                        while (index != start)
                        {
                            array[index] = array[index - 1];
                            index--;
                        }
                        array[start] = value;

                        // update all the pointers
                        start++;
                        //mid++;
                        start2++;
                    }
                }
            }

            static void SplitArray(int[] array, int start, int end)
            {
                if (end > start)
                {
                    int mid = (start + end) / 2;
                    SplitArray(array, start, mid);
                    SplitArray(array, mid + 1, end);
                    Merge(array, start, mid, end);
                }
            }

            SplitArray(array, 0, array.Length - 1);
        }


        public static void MergeSort(int[] nums)
        {
            static void Merge(int[] nums, int start, int mid, int end)
            {
                int start2 = mid + 1;

                int size = (mid - start + 1) + (end - start2 + 1);
                int[] temp = new int[size];

                int i = start;
                int j = start2;
                int x = 0;
                while (x < size)
                {
                    if (i >= start && i <= mid && j >= start2 && j <= end)        // both i and j are OK
                    {
                        if (nums[i] < nums[j])
                        {
                            temp[x++] = nums[i];
                            i++;
                        }
                        else if (nums[i] > nums[j])
                        {
                            temp[x++] = nums[j];
                            j++;
                        }
                        else
                        {
                            temp[x++] = nums[i];
                            i++;

                            temp[x++] = nums[j];
                            j++;
                        }
                    }
                    else if (i >= start && i <= mid)                           // i is OK
                    {
                        temp[x++] = nums[i];
                        i++;
                    }
                    else if (j >= start2 && j <= end)                           // j is OK
                    {
                        temp[x++] = nums[j];
                        j++;
                    }
                }

                for (int t = 0; t < size; t++)
                {
                    nums[start + t] = temp[t];
                }
            }

            static void SplitArray(int[] nums, int start, int end)
            {
                if (start == end)
                    return;

                int mid = (start + end) / 2;
                SplitArray(nums, start, mid);
                SplitArray(nums, mid + 1, end);
                Merge(nums, start, mid, end);
            }

            if (nums.Length <= 1)
                return;

            SplitArray(nums, 0, nums.Length - 1);
        }
    }
}