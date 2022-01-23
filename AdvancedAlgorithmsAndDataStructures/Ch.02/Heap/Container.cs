namespace Heap
{
    public class Container
    {
        private readonly int[] array;
        private int realSize = 0;

        public Container(int[] numbers)
        {
            realSize = numbers.Length;

            array = new int[realSize + 1];

            for (int i = 0; i < realSize; i++)
            {
                array[i + 1] = numbers[i];
            }
        }

        public void Heapify()
        {
            for (int i = realSize / 2; i >= 1; i--)
            {
                PushDown(i);
            }
        }

        public int Top()
        {
            if (realSize < 1)
            {
                throw new InvalidOperationException("Heap is empty!");
            }

            if (realSize == 1)
            {
                var top = array[1];
                realSize--;
                return top;
            }
            else
            {
                var top = array[1];
                array[1] = array[realSize];
                realSize--;
                PushDown(1);
                return top;
            }
        }

        public int Size()
        {
            return realSize;
        }

        private void PushDown(int index)
        {
            var current = array[index];

            while (index <= realSize / 2)
            {
                int left = index * 2;
                int right = (index * 2) + 1;

                if (right > realSize && array[left] > current)
                {
                    array[index] = array[left];
                    index = left;
                }
                else if (array[left] > current || array[right] > current)
                {
                    if (array[left] > array[right])
                    {
                        array[index] = array[left];
                        index = left;
                    }
                    else
                    {
                        array[index] = array[right];
                        index = right;
                    }
                }
                else
                {
                    break;
                }
            }
            array[index] = current;
        }
    }
}