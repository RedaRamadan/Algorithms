namespace _02.InsertionSort
{
    public class Algorithms
    {
        public static void InsertionSort(int[] array)
        {
            void Swap(int a, int b)
            {
                var temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }

            for (int i = 1; i < array.Length; i++)
            {
                int index = i;
                while (index >= 1 && array[index - 1] > array[index])
                {
                    Swap(index, index - 1);
                    index--;
                }
            }
        }
    }
}