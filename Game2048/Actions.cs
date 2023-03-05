using System;

namespace Game2048
{
    public class Actions
    {
        
        ///<summary>Creates a matrix of numbers set to 0, with two starting random numbers</summary>
        public static double[,] StartGame()
        {
            double[,] cards = new double[4, 4];

            for (int riga = 0; riga < cards.GetLength(0); riga++)
            {
                for (int col = 0; col < cards.GetLength(1); col++)
                {
                    cards[riga, col] = 0;
                }
            }


            for (int i = 0; i < 2; i++) 
            {
                AddNewNum(cards);
            }
            return cards;
        }
        ///<summary>Adds a new random number </summary>
        public static void AddNewNum(double[,] cards)
        {
            Random rnd = new Random();
            double[] rndCard = { 2, 2, 2, 4 };


            int r;
            int c;
            do
            {
                r = rnd.Next(0, 4);
                c = rnd.Next(0, 4);

            } while (cards[r, c] != 0);
            cards[r, c] = rndCard[rnd.Next(rndCard.Length)];
        }
        public static void SortCardsUp(double[,] cards)
        {
            int saveIndexRiga;
            for (int col = 0; col < cards.GetLength(1); col++)
            {
                for (int riga = 0; riga < cards.GetLength(0); riga++)
                {
                    saveIndexRiga = riga;
                    while (cards[saveIndexRiga, col] == 0 && saveIndexRiga < 3)
                    {
                        saveIndexRiga++; 
                    }

                    if (saveIndexRiga != riga)
                    {
                        cards[riga, col] = cards[saveIndexRiga, col];
                        cards[saveIndexRiga, col] = 0;
                    }
                }
            }
        }
        public static void SortCardsLeft(double[,] cards)
        {
            int saveIndexCol;
            for (int riga = 0; riga <= cards.GetLength(0) - 1; riga++)
            {
                for (int col = 0; col <= cards.GetLength(1) - 1; col++)
                {
                    saveIndexCol = col;
                    while (cards[riga, saveIndexCol] == 0 && saveIndexCol < 3)
                    {
                        saveIndexCol++; 
                    }

                    if (saveIndexCol != col)
                    {
                        cards[riga, col] = cards[riga, saveIndexCol];
                        cards[riga, saveIndexCol] = 0;
                    }
                }
            }
        }
        public static void SortCardsRight(double[,] cards)
        {
            int saveIndexCol;

            for (int riga = cards.GetLength(0) - 1; riga >= 0; riga--)
            {
                for (int col = cards.GetLength(1) - 1; col >= 0; col--)
                {
                    saveIndexCol = col;
                    while (cards[riga, saveIndexCol] == 0 && saveIndexCol > 0)
                    {
                        saveIndexCol--;
                    }

                    if (saveIndexCol != col)
                    {
                        cards[riga, col] = cards[riga, saveIndexCol];
                        cards[riga, saveIndexCol] = 0;
                    }
                }
            }
        }
        public static void SortCardsDown(double[,] cards)
        {
            int saveIndexRiga;
            for (int col = cards.GetLength(1) - 1; col >= 0; col--)
            {
                for (int riga = cards.GetLength(0) - 1; riga >= 0; riga--)
                {
                    saveIndexRiga = riga;
                    while (cards[saveIndexRiga, col] == 0 && saveIndexRiga > 0)
                    {
                        saveIndexRiga--;
                    }

                    if (saveIndexRiga != riga)
                    {
                        cards[riga, col] = cards[saveIndexRiga, col];
                        cards[saveIndexRiga, col] = 0;
                    }
                }
            }
        }
        public static void SumCardsUp(double[,] cards)
        {
            for (int riga = 0; riga < cards.GetLength(0) - 1; riga++)
            {
                for (int col = 0; col <= cards.GetLength(1) - 1; col++)
                {
                    if (cards[riga, col] != 0 && cards[riga, col] == cards[riga + 1, col])
                    {
                        cards[riga, col] += cards[riga + 1, col];
                        cards[riga + 1, col] = 0;

                    }
                }
            }
        }
        public static void SumCardsDown(double[,] cards)
        {
            for (int riga = cards.GetLength(0) - 1; riga > 0; riga--)
            {
                for (int col = cards.GetLength(1) - 1; col >= 0; col--)
                {

                    if (cards[riga, col] != 0 && cards[riga, col] == cards[riga - 1, col])
                    {
                        cards[riga - 1, col] += cards[riga, col];
                        cards[riga, col] = 0;
                    }

                }
            }
        }
        public static void SumCardsRight(double[,] cards)
        {
            for (int riga = cards.GetLength(0) - 1; riga >= 0; riga--)
            {
                for (int col = cards.GetLength(1) - 1; col > 0; col--)
                {
                    if (cards[riga, col] != 0 && cards[riga, col] == cards[riga, col - 1])
                    {
                        cards[riga, col] += cards[riga, col - 1];
                        cards[riga, col - 1] = 0;
                    }
                }
            }
        }
        public static void SumCardsLeft(double[,] cards)
        {
            for (int riga = 0; riga <= cards.GetLength(0) - 1; riga++)
            {
                for (int col = 0; col < cards.GetLength(1) - 1; col++)
                {

                    if (cards[riga, col] != 0 && cards[riga, col] == cards[riga, col + 1])
                    {
                        cards[riga, col] += cards[riga, col + 1];
                        cards[riga, col + 1] = 0;
                    }
                }
            }
        }
    }
}
