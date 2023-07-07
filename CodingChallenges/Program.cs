// See https://aka.ms/new-console-template for more information
using CodingChallenges.LeetCode;
using CodingChallenges.Personal;

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


Console.WriteLine("\n\nPascals Traingle!");
IList<IList<int>> a = new PascalsTraingle().ConstructPascalsTraingle(5);
foreach(IList<int> i in a)
{
    Console.WriteLine(string.Join(" ", i));
}


Console.WriteLine("\n\nContains Duplicate!");
int[][] numsAarr = new int[][] {
    new int[] { 1, 2, 3, 1 },
    new int[] { 1, 2, 3, 4 },
    new int[] { 1, 1, 1, 3,3,4,3,2,4,2 },
};

foreach (int[] nums in numsAarr)
{
    Console.WriteLine(ContainsDuplicate.CheckIfArrayContainsDuplicate(nums));
}

Console.WriteLine("\n\nReverse LinkedList!");

int[] vals = new int[] { 1, 2, 3, 4, 5 };
CustomLinkedList<int> linkedList = new CustomLinkedList<int>(vals);

Console.WriteLine("\n\nOrginal LinkedList!");
linkedList.Print();

Console.WriteLine("\n\nReversed LinkedList!");
linkedList.Reverse();
linkedList.Print();


Console.WriteLine("\n\nReversed LinkedList!");
int[] vals2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
CustomLinkedList<int> linkedList2 = new CustomLinkedList<int>(vals2);
var node = ReverseLinkedList<int>.Reverse(linkedList2.First);
ReverseLinkedList<int>.Print(node);

int[] arr = new int[] { 1, 4, 7, 9, 11, 23, 45, 53 };
int[] indices = TwoSum.Solution(arr, 5);
int[] indices2 = TwoSum.Solution(arr, 8);
int[] indices3 = TwoSum.Solution(arr, 13);


Console.WriteLine("\n\nPalindrom String!");

string[] testInputs = new string[] { "iTopiNonAvevanoNipoti", "iGattiNonAvevanoCugini", "B" };
foreach (string input in testInputs)
{
    Console.WriteLine($"- Is {input} palindrom ? {PalindromString.IsPalindrom(input)}");
}

Console.WriteLine("\n\nPalindrom String (Recursive version)!");
foreach (string input in testInputs)
{
    Console.WriteLine($"- Is {input} palindrom? {PalindromStringRecursive.IsPalindromRecursive(input)}");
}

Console.ReadLine();
