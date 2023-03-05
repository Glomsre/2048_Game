using System;

namespace Game2048
{
    public class Commands
    {
        public static void PrintCommands()
        {
            Console.WriteLine("2 -> Down ; 8 -> Up ; 4 -> Left ; 6 -> Right\n\n");
        }
        ///<summary>Moves the numbers Up, Down, Left, Right</summary>
        public static void Command(double[,] cards)
        {
            Console.Write("Inserisci direzione : ");
            string direzione = Console.ReadLine();

            if (direzione == "8")// su
            {
                Actions.SortCardsUp(cards);

                Actions.SumCardsUp(cards);

                Actions.SortCardsUp(cards);

                Actions.AddNewNum(cards);

            }
            else if (direzione == "2")//giu
            {
                Actions.SortCardsDown(cards);

                Actions.SumCardsDown(cards);

                Actions.SortCardsDown(cards);

                Actions.AddNewNum(cards);

            }
            else if (direzione == "6")//destra
            {
                Actions.SortCardsRight(cards);

                Actions.SumCardsRight(cards);

                Actions.SortCardsRight(cards);

                Actions.AddNewNum(cards);

            }
            else if (direzione == "4")//sinistra
            {
                Actions.SortCardsLeft(cards);

                Actions.SumCardsLeft(cards);

                Actions.SortCardsLeft(cards);

                Actions.AddNewNum(cards);

            }

        }
    }
}
