using System.Diagnostics.Metrics;

namespace LeetCode.Problems
{
    /// <summary>
    /// 200. Number of Islands
    /// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
    /// You may assume all four edges of the grid are all surrounded by water.
    /// 
    /// Best Solutions using: BFS, DFS, Union Find...
    /// </summary>
    public class NumberOfIselands
    {
        public int FindNumberOfIselands(char[][] grid)
        {
            if (grid is null || grid.Length == 0) return 0;
            int count = 0;

            for (int row = 0; row < grid.Length; ++row)
            {
                for (int col = 0; col < grid[row].Length; ++col)
                {
                    if (grid[row][col] == '1')
                    {
                        count++;

                        //BFS
                        MarkVisitedNodes(grid, row, col);
                    }
                }
            }

            return count;
        }

        public void MarkVisitedNodes(char[][] grid, int row, int col)
        {
            if (row < 0 || col < 0 || row >= grid.Length || col >= grid[row].Length || grid[row][col] == '0') return;
            grid[row][col] = '0';
            MarkVisitedNodes(grid, row - 1, col); // Vertical Adjacent: check bottom
            MarkVisitedNodes(grid, row + 1, col); // Vertical Adjacent: check top
            MarkVisitedNodes(grid, row, col - 1); // Horizontal Adjacent: check to the left
            MarkVisitedNodes(grid, row, col + 1); // Horizontal Adjacent: check to the right
        }
    }
}
