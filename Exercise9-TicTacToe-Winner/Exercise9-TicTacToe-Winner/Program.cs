namespace Exercise9_TicTacToe_Winner
{
    internal class Program
    {
        public static bool Checker(string[,] board)
        {
            // Check Rows
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] != "" && board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                    return true;
            }
            
            // Check Columns 
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] != "" && board[0, i] == board[1, i] && board[0, i] == board[2, i])
                    return true;
            }

            // Check Diagonals
            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                return true;
            if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                return true;
            
            return false;
        }
        static void Main(string[] args)
        {
            string[,] board = {
                {"","",""},
                {"","",""},
                {"","",""}
            };
            string[,] board1 = {
                {"","",""},
                {"X","X","X"},
                {"","",""}
            };
            string[,] board2 = {
                {"","O",""},
                {"","O",""},
                {"","O",""}
            };
            string[,] board3 = {
                {"","","X"},
                {"","X",""},
                {"X","",""}
            };

            Console.WriteLine(Checker(board));
            Console.WriteLine(Checker(board1));
            Console.WriteLine(Checker(board2));
            Console.WriteLine(Checker(board3));
        }
    }
}