namespace _02.SelectionSort
{
    public class Algorithms
    {
        public static void SeletionSort(int[] array)
        {
            void Swap(int a, int b)
            {
                int temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }


            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                Swap(min, i);
            }
        }
    }
}