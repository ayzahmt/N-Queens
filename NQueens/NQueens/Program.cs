using System;

namespace NQueens
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ins = new Program();

            Console.Write("Enter Queen Count: ");
            var nQueen = Convert.ToInt32(Console.ReadLine());                        
            int[,] boardMatrix = new int[nQueen, nQueen];

            if (ins.ProcessNQueen(0, nQueen, boardMatrix))
            {
                Console.WriteLine("Solution: ");
                for (var i = 0; i < nQueen; i++)
                {
                    for (var j = 0; j < nQueen; j++)
                    {
                        Console.Write(boardMatrix[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            Console.Read();
        }

        public bool IsFieldAvaliable(int row, int col, int[,] boardMatrix)
        {
            #region ControlRow
            for (int i = 0; i < col; i++)
            {
                if (boardMatrix[row, i] == 1) return false;
            }
            #endregion

            #region ControlDiagonalRight           
            for (int i = row, j = col; i < boardMatrix.GetLength(0) && j < boardMatrix.GetLength(1); i++, j++)
            {
                if (boardMatrix[i, j] == 1) return false;
            }
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (boardMatrix[i, j] == 1) return false;
            }
            #endregion

            #region ControlDiagonalLeft
            for (int i = row, j = col; i < boardMatrix.GetLength(0) && j >= 0; i++, j--)
            {
                if (boardMatrix[i, j] == 1) return false;
            }
            for (int i = row, j = col; i >= 0 && j < boardMatrix.GetLength(1); i--, j++)
            {
                if (boardMatrix[i, j] == 1) return false;
            }
            #endregion

            return true;        
        }
        
        public bool ProcessNQueen(int col, int nQueen, int[,] boardMatrix)
        {
            if (col >= nQueen) return true;

            for (int i = 0; i < boardMatrix.GetLength(0); i++)
            {
                if (IsFieldAvaliable(i, col, boardMatrix))
                {
                    boardMatrix[i, col] = 1;

                    if (ProcessNQueen(col + 1, nQueen, boardMatrix))
                    {
                        return true; // col >= NQueen   
                    }
                    boardMatrix[i, col] = 0;
                }               
            }

            return false;
        }
    }
}
