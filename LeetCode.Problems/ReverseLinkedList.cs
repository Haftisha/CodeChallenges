namespace LeetCode.Problems
{
    /// <summary>
    /// 206. Reverse Linked List
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ReverseLinkedList<T>
    {
        public static ListNode<T> Reverse(ListNode<T> head)
        {
            ListNode<T> node = head;
            ListNode<T> prev = null;
            while (node != null)
            {
                ListNode<T> next = node.Next;
                node.Next = prev;
                prev = node;
                node = next;
            }
            return prev;
        }

        public static void Print(ListNode<T> node)
        {
            while (node != null)
            {
                node.Print();
                node = node.Next;
            }
        }
    }
}

// Definition for singly - linked list.
public class ListNode<T>
{
    public T Value;
    public ListNode<T> Next;
    public ListNode(T val = default(T), ListNode<T> next = null)
    {
        this.Value = val;
        this.Next = next;
    }

    public void Print()
    {
        Console.WriteLine(this.Value.ToString());
    }
}

