namespace CodingChallenges.LeetCode
{
    /// <summary>
    /// Problem 118: Pascal's Triangle
    /// Given an integer numRows, return the first numRows of Pascal's triangle.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    /// https://upload.wikimedia.org/wikipedia/commons/0/0d/PascalTriangleAnimated2.gif
    /// </summary>
    public class PascalsTraingle
    {
        public IList<IList<int>> ConstructPascalsTraingle(int numOfRows)
        {
            IList<IList<int>> triangle = new int[numOfRows][];

            triangle[0] = new int[1] { 1 };
            for (int row = 1; row < numOfRows; row++)
            {
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1;
                for (int col = 1; col < row; col++)
                {

                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
                triangle[row][row] = 1;
            }
            return triangle;
        }
    }
}
