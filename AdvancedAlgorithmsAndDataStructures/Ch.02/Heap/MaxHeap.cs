namespace Heap
{
    public class MaxHeap
    {
        private readonly List<Pair> heap;
        private int realSize = 0;

        public MaxHeap()
        {
            heap = new List<Pair>();
            heap.Add(Pair.Empty);                // skip index 0
        }

        public void Add(string element, int priority)
        {
            realSize++;
            heap.Insert(realSize, new Pair(element, priority));
            BubbleUp(realSize);
        }

        public Pair Top()
        {
            if (realSize < 1)
            {
                throw new InvalidOperationException("Heap is empty!");
            }

            if (realSize == 1)
            {
                Pair top = heap[1];
                realSize--;
                return top;
            }
            else
            {
                Pair top = heap[1];
                heap[1] = heap[realSize];
                realSize--;
                PushDown(1);
                return top;
            }
        }

        public int Size()
        {
            return realSize;
        }

        public void Update(string element, int newPriority)
        {
            int index = heap.FindIndex(x => x.Element == element);
            if (index > 0)
            {
                int oldPriority = heap[index].Priority;
                heap[index] = new Pair(element, newPriority);

                if (newPriority < oldPriority)
                {
                    PushDown(index);
                }
                else if (newPriority > oldPriority)
                {
                    BubbleUp(index);
                }
            }
        }



        private void BubbleUp(int index)
        {
            var current = heap[index];

            while (index > 1)
            {
                int parentIndex = index / 2;
                if (current.Priority > heap[parentIndex].Priority)
                {
                    heap[index] = heap[parentIndex];
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }

            heap[index] = current;
        }

        private void PushDown(int index)
        {
            var current = heap[index];

            while (index <= realSize / 2)
            {
                int left = index * 2;
                int right = (index * 2) + 1;

                if (right > realSize && heap[left].Priority > current.Priority)
                {
                    heap[index] = heap[left];
                    index = left;
                }
                else if (heap[left].Priority > current.Priority || heap[right].Priority > current.Priority)
                {
                    if (heap[left].Priority > heap[right].Priority)
                    {
                        heap[index] = heap[left];
                        index = left;
                    }
                    else
                    {
                        heap[index] = heap[right];
                        index = right;
                    }
                }
                else
                {
                    break;
                }
            }
            heap[index] = current;
        }
    }

    public class Pair
    {
        public Pair(string element, int priority)
        {
            Element = element;
            Priority = priority;
        }

        public string Element { get; set; }
        public int Priority { get; set; }

        public override string ToString()
        {
            return $"#{Priority,2}: {Element}";
        }

        public static Pair Empty => new("<Empty>", 0);
    }
}