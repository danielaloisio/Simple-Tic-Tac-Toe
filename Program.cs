using System;

namespace TicTacToe
{
    class Program
    {
        static char[] positions = {'0','1','2','3','4','5','6','7','8','9'};
        static char player = 'O';
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TictTacToe, write a position to start.");
            Console.WriteLine("\n");
            PrintBoard();

            for(;;)
            {
                try{
                    
                    Console.WriteLine("\n");
                    int check = CheckStatus();
                    if(check == 1)
                    {
                        Console.WriteLine("Player {0} won", player);
                        break;
                    }
                    else if(check == 2)
                    {
                        Console.WriteLine("End game, nobody won");
                        break;
                    }

                    var position = int.Parse(Console.ReadLine());
                    
                    if(positions[position] != 'X' && positions[position] != 'O')
                    {
                        player = player == 'O' ? 'X' : 'O';
                        positions[position] = player;
                    }

                    Console.Clear();
                    PrintBoard();
                }
                catch
                {
                    Console.Clear();
                    PrintBoard();                    
                }
            }
        }

        private static void PrintBoard()
        {
           Console.WriteLine(" {0}  |  {1}  | {2} ",  positions[1], positions[2], positions[3] );
           Console.WriteLine("---         ---");
           Console.WriteLine(" {0}  |  {1}  | {2} ", positions[4], positions[5], positions[6] );
           Console.WriteLine("---         ---");
           Console.WriteLine(" {0}  |  {1}  | {2} ", positions[7], positions[8], positions[9]);
        }

        private static int CheckStatus()
        {
            #region ==Horizontal ==
            if(positions[1] == positions[2] && positions[2] == positions[3])
            {
               return 1;
            }
            else if(positions[4] == positions[5] && positions[5] == positions[6])
            {
                return 1;
            }
            else if(positions[7] == positions[8] && positions[8] == positions[9])
            {
                return 1;
            }
            #endregion

            #region == Vertical ==
            if(positions[1] == positions[4] && positions[4] == positions[7])
            {
               return 1;
            }
            else if(positions[2] == positions[5] && positions[5] == positions[8])
            {
                return 1;
            }
            else if(positions[3] == positions[6] && positions[6] == positions[9])
            {
                return 1;
            }
            #endregion

            #region == Diagonal ==
            if(positions[1] == positions[5] && positions[5] == positions[9])
            {
               return 1;
            }
            else if(positions[3] == positions[5] && positions[5] == positions[7])
            {
                return 1;
            }
            #endregion

            #region == Check final without a winner ==
            if(positions[1] != '1' && positions[2] != '2' && positions[3] != '3' && positions[4] != '4'
            && positions[5] != '5' && positions[6] != '6' && positions[7] != '7' & positions[8] != '8'
            & positions[9] != '9')
            {
                return 2;
            }
            #endregion

            return -1;
        }
    
    }
}
