class minHeap
{
    private List<int> heap;

    public minHeap()
    {
        heap = new List<int>();
    }

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }

    // Insert x into the heap
    public void push(int x)
    {
        heap.Add(x);
        int current = heap.Count - 1;

        while (current > 0)
        {
            int parent = (current - 1) / 2;
            if (heap[parent] > heap[current])
            {
                Swap(parent, current);
                current = parent;
            }
            else
                break;
        }
    }

    // Remove the top (minimum) element
    public void pop()
    {
        if (heap.Count == 0) return;

        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);

        int current = 0;
        while (true)
        {
            int left = 2 * current + 1;
            int right = 2 * current + 2;
            int smallest = current;

            if (left < heap.Count && heap[left] < heap[smallest])
                smallest = left;

            if (right < heap.Count && heap[right] < heap[smallest])
                smallest = right;

            if (smallest != current)
            {
                Swap(current, smallest);
                current = smallest;
            }
            else
                break;
        }
    }

    // Return the top element or -1 if empty
    public int peek()
    {
        return heap.Count == 0 ? -1 : heap[0];
    }

    // Return the number of elements in the heap
    public int size()
    {
        return heap.Count;
    }
}
