using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerNeuralNetwork.Poker {
    public class Deck {
        Random rng;
        Stack<Card> deck;

        public Deck(Random rng) {
            this.rng = rng;
            ResetDeck();
        }

        public Card NextCard() {
            return deck.Pop();
        }

        public void ResetDeck() {
            deck = new Stack<Card>();

            Card[] cards = new Card[52];

            int count = 0;

            for (int i = 0; i < 4; i++) {
                //Get the enum value of the suit
                Card.Suit suit = (Card.Suit)i;

                for (int value = 2; value < 15; value++) {
                    //Add the new card to the deck
                    cards[count] = new Card(suit, value);

                    count++;
                }
            }

            cards = ShuffleDeck(cards);

            foreach (Card card in cards) {
                deck.Push(card);
            }
        }

        private Card[] ShuffleDeck(Card[] cards) {
            return cards.OrderBy(x => rng.Next()).ToArray();
        }

        public override string ToString() {
            string output = "";

            foreach (Card card in deck) {
                output += card.ToString();
                output += " ";
            }

            return output;
        }
    }
}
