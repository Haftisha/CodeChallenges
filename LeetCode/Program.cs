// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;

Console.WriteLine("# Of Iselands!");


char[][] grid = {
    new char[] { '1', '1', '1', '1', '0' },
    new char[] { '1', '1', '0', '1', '0' },
    new char[] { '1', '1', '0', '0', '0' },
    new char[] { '0', '0', '0', '0', '0' }
};

char[][] grid2 = {
    new char[] { '1','1','0','0','0' },
    new char[] { '1','1','0','0','0' },
    new char[] { '0','0','1','0','0' },
    new char[] { '0','0','0','1','1' }
};


int numberOfIselands = new NumberOfIselands().FindNumberOfIselands(grid);
Console.WriteLine(numberOfIselands);
numberOfIselands = new NumberOfIselands().FindNumberOfIselands(grid2);
Console.WriteLine(numberOfIselands);


Console.WriteLine("Pascals Traingle!");
var a = new PascalsTraingle().ConstructPascalsTraingle(5);


Console.WriteLine("Contains Duplicate!");
int[][] numsAarr = new int[][] {
    new int[] { 1, 2, 3, 1 },
    new int[] { 1, 2, 3, 4 },
    new int[] { 1, 1, 1, 3,3,4,3,2,4,2 },
};

foreach (int[] nums in numsAarr)
{
    Console.WriteLine(ContainsDuplicate.CheckIfArrayContainsDuplicate(nums));
}

Console.WriteLine("Reverse LinkedList!");

int[] vals = new int[] { 1, 2, 3, 4, 5 };
CustomLinkedList<int> linkedList = new CustomLinkedList<int>(vals);

Console.WriteLine("Orginal LinkedList!");
linkedList.Print();

Console.WriteLine("Reversed LinkedList!");
linkedList.Reverse();
linkedList.Print();


Console.WriteLine("Reversed LinkedList!");
int[] vals2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
CustomLinkedList<int> linkedList2 = new CustomLinkedList<int>(vals2);
var node = ReverseLinkedList<int>.Reverse(linkedList2.First);
ReverseLinkedList<int>.Print(node);

int[] arr = new int[] {1, 4, 7, 9, 11, 23, 45, 53 };
int[] indices = TwoSum.Solution(arr, 5);
int[] indices2 = TwoSum.Solution(arr, 8);
int[] indices3 = TwoSum.Solution(arr, 13);
Console.ReadLine();
