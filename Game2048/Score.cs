using System;

namespace Game2048
{
    public class Score
    {
        ///<summary>Prints the best score and Ended the program returning a bool true or false</summary>
        public static bool ScoreGameOver(double[,] cards)
        {
            int countZero = 0;
            double score = 0;
            bool gameOn = true;

            for (int riga = 0; riga <= cards.GetLength(0) - 1; riga++)
            {
                for (int col = 0; col <= cards.GetLength(1) - 1; col++)
                {
                    if (cards[riga, col] == 0) countZero++;
                    if (cards[riga, col] > score) score = cards[riga, col];
                }
            }

            if (countZero < 1)
            {
                gameOn = false;
                Console.Write(@" 
                   _____                         ____                 _ 
                  / ____|                       / __ \               | |
                 | |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __| |
                 | | |_ |/ _` | '_ ` _ \ / _ \ | |  | \ \ / / _ \ '__| |
                 | |__| | (_| | | | | | |  __/ | |__| |\ V /  __/ |  |_|
                  \_____|\__,_|_| |_| |_|\___|  \____/  \_/ \___|_|  (_)
                                                                        
                                                                        
                ");
                Console.WriteLine($"\n\nYour Score is: {score}");
                return gameOn;

            }
            else if (score == 2048)
            {
                gameOn = false;
                Console.WriteLine(@" 
                __   __            _    _ _       _ 
                \ \ / /           | |  | (_)     | |
                 \ V /___  _   _  | |  | |_ _ __ | |
                  \ // _ \| | | | | |/\| | | '_ \| |
                  | | (_) | |_| | \  /\  / | | | |_|
                  \_/\___/ \__,_|  \/  \/|_|_| |_(_)
                                                    
                                                    
                ");
                Console.WriteLine($"\n\nYour Score is: {score}");
                return gameOn;
            }

            return gameOn;
        }
    }
}
