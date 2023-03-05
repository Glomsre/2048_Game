using System;

namespace Game2048
{
    public class Graphics
    {
        ///<summary>Print the Grid</summary>
        public static void GraphicGrid(double[,] doubleArray)
        {
            double[,] cards = doubleArray;

            string[] grid =
                {
                    "_____________________________",
                    "|                            ",
                    $"|  {cards[0, 0]}     {cards[0, 1]}     {cards[0, 2]}     {cards[0, 3]}  ",
                    "|____________________________",
                    "|                            ",
                    $"|  {cards[1, 0]}     {cards[1, 1]}     {cards[1, 2]}     {cards[1, 3]}  ",
                    "|____________________________",
                    "|                        ",
                    $"|  {cards[2, 0]}     {cards[2, 1]}     {cards[2, 2]}     {cards[2, 3]}  ",
                    "|____________________________",
                    "|                        ",
                    $"|  {cards[3, 0]}     {cards[3, 1]}     {cards[3, 2]}     {cards[3, 3]}  ",
                    "|____________________________",

                };

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string ele in grid) Console.WriteLine(ele);
        }
    }
}
