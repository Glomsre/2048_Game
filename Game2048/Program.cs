using System;

namespace Game2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Logo.PrintLogo();
            Commands.PrintCommands();
            
            double[,] cards = Actions.StartGame();

            Graphics.GraphicGrid(cards);

            do
            {

                Commands.Command(cards);

                Graphics.GraphicGrid(cards);


            } while (Score.ScoreGameOver(cards));


            
        }
    }
}
