namespace LeetCode.Problems
{
    public class CustomLinkedList<T>
    {
        public ListNode<T> First { get; private set; }
        public int Size { get; set; } = 0;

        public CustomLinkedList(T[] values)
        {
            this.First = new ListNode<T>(values[0], null);
            ListNode<T> prev = this.First;
            this.Size++;
            for (int i = 1; i < values.Length; ++i)
            {
                ListNode<T> next = new ListNode<T>(values[i], null);
                prev.Next = next;
                prev = next;
                this.Size++;
            }
        }

        public void Reverse()
        {
            ListNode<T> node = First;
            ListNode<T> prev = null;
            while (node != null)
            {
                ListNode<T> next = node.Next;
                node.Next = prev;
                prev = node;
                node = next;
            }
            First = prev;
        }


        public void Print()
        {
            ListNode<T> node = this.First;
            while (node != null)
            {
                node.Print();
                node = node.Next;
            }
        }
    }

    public class CustomNode<T>
    {
        public T Value { get; set; }
        public CustomNode<T> Next { get; set; }

        public CustomNode(T value, CustomNode<T> next)
        {
            this.Value = value;
            this.Next = next;
        }
        public void Print()
        {
            CustomNode<T> node = this;
            T val = this.Value;
            while (node != null)
            {
                Console.WriteLine(node.Value.ToString());
                node = node.Next;
            }
        }
    }
}
