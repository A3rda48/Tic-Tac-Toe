using System;
class Program
{
    static void Main()
    {
        int[,] board = new int[3, 3];
        int Player = 1;
        int location = 0;
        bool gameRunning = true;
        Console.WriteLine("Welcome to tic-tac-toe!");

        while (gameRunning)
        {
            Game(board);

            string PlayerSymbol;
            if (Player == 1) { PlayerSymbol = "X"; }
            else { PlayerSymbol = "O"; }

            Console.Write($"{PlayerSymbol}`s move > ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
            {
                int row = (position - 1) / 3;
                int col = (position - 1) % 3;

                if (board[row, col] == 0)
                {
                    board[row, col] = Player;
                    location++;

                    if (Player == 1) { Player = 2; }
                    else { Player = 1; }
                }

                else
                {
                    Console.WriteLine("Illegal move! Try Again.");
                }

                if (location == 9)
                {
                    Game(board);
                    Console.WriteLine("Game Over!");
                    gameRunning = false;
                }    
            }
            else { Console.WriteLine("Illegal Move! Try Again."); }
        }
    }
    static void Game(int[,] board)
    {
        
        for (int i = 0; i<3;  i++)
        {
            for (int j = 0; j < 3; j++)
            {
                string cell;
                if (board[i, j] == 0)
                {
                    cell = " ";
                }
                else if (board[i, j] == 1)
                {
                    cell = "X";
                }
                else if (board[i, j] == 2)
                {
                    cell = "O";
                }
                else { cell = "?"; }

                Console.Write($" {cell} ");
                if (j < 2) { Console.Write("|"); }
            }
            if (i<2)
            {
                Console.WriteLine();
                Console.WriteLine("---+---+---");
            }
        }
        Console.WriteLine();
    }
}
