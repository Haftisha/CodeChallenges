namespace CodingChallenges.LeetCode
{
    /// <summary>
    /// 234. Palindrom LinkedList
    /// Given the head of a singly linked list, return true if it is a palindrome  or false otherwise.
    /// https://assets.leetcode.com/uploads/2021/03/03/pal1linked-list.jpg
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class PalindromLinkedList
    {
        public static bool IsPalindrom(ListNode<int> head)
        {
            if (head == null || head.Next == null) return true;

            List<int> list = new List<int>();
            while (head!=null)
            {
                list.Add(head.Value); 

                head = head.Next;
            }

            for(int i=0; i < list.Count; ++i)
            {
                if (list[i] == list[list.Count-1-i]) continue;
                return false;
            }

            return true;
        }
    }
}
