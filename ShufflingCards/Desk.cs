﻿namespace ShufflingCards
{
    public class Deck
    {
        enum CardSuit { HEARTS, DIAMONDS, SPADES, CLUBS }

        public List<string> cards;

        public Deck()
        {
            cards = new List<string>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int y = 2; y < 11; y++)
                {
                    cards.Add($"{y.ToString()} of {suit}");
                }

                cards.Add($"A of {suit}");
                cards.Add($"J of {suit}");
                cards.Add($"Q of {suit}");
                cards.Add($"K of {suit}");
            }
        }
    }
}
