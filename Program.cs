using System.Drawing;

namespace _1476._Subrectangle_Queries
{
    internal class Program
    {
        public class SubrectangleQueries
        {

            private int[,] matrix;

            public SubrectangleQueries(int[][] rectangle)
            {
                var row = rectangle.Length;
                var col = rectangle[0].Length;
                matrix = new int[row, col];
                for (var i = 0; i < row; i++)
                {
                    for (var j = 0; j < col; j++)
                    {
                        matrix[i, j] = rectangle[i][j];
                    }
                }
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (var i = row1; i <= row2; i++)
                {
                    for (var j = col1; j <= col2; j++)
                    {
                        matrix[i, j] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return matrix[row, col];
            }
        }
        static void Main(string[] args)
        {
            int[][] rectangle = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6, 6 },
                new int[] { 11, 22,12,13,14 }
            };
            SubrectangleQueries obj = new SubrectangleQueries(rectangle);
            obj.UpdateSubrectangle(2, 2, 4, 4, 25);
            int param_2 = obj.GetValue(1, 2);
        }
    }
}
                
            
        
    
