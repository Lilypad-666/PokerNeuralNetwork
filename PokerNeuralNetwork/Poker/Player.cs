using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PokerNeuralNetwork.Poker {
    class Player {
        public enum Blinds {
            dealer,
            bigblind,
            smallblind
        }

        bool draw = false;
        TextBox card1;
        TextBox card2;
        TextBox moneyText;
        TextBox blindText;
        TextBox betText;

        int id;
        public Card[] hand = new Card[4];
        public int money;
        public int currentBet;

        public int[] highCards;


        public Player(int id, int money) {
            this.id = id;
            this.money = money;

            highCards = new int[5];

            UpdateText();
        }

        public void SetPanel(TableLayoutPanel panel) {
            draw = true;

            panel.Visible = true;

            card1 = (TextBox)panel.Controls.Find("Player" + id + "Card1", true)[0];
            card2 = (TextBox)panel.Controls.Find("Player" + id + "Card2", true)[0];
            moneyText = (TextBox)panel.Controls.Find("Player" + id + "Money", true)[0];
            blindText = (TextBox)panel.Controls.Find("BlindDealerText" + id, true)[0];
            betText = (TextBox)panel.Controls.Find("CurrentBet" + id, true)[0];
        }

        public int Play(int targetBet) {
            //-1 fold
            // 0 check/call
            // >1 raise

            int play = 0;

            //Check/Call
            if (play == 0) {
                return Call(targetBet);
            }

            //Raise
            if (play > 0) {
                return Raise(targetBet, 1);
            }

            //Fold
            if (play == -1) {
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// Gets the ranking of the hand including the potential high cards
        /// </summary>
        /// <param name="middleCards">5 field cards</param>
        /// <returns></returns>
        public int GetHandRanking(Card[] middleCards) {
            Card[] cards = new Card[7];

            for (int i = 0; i < 2; i++) {
                cards[i] = hand[i];
            }

            for (int i = 0; i < 5; i++) {
                cards[i + 2] = middleCards[i];
            }

            //Sort the cards
            cards = cards.OrderBy(x => x.value).ToArray();

            //Print the hand
            string handText = "(" + id + ") Hand: ";
            foreach (Card card in cards) {
                handText += card;
            }
            Console.WriteLine(handText);

            int[] cardValues = new int[7];
            Card.Suit[] cardSuits = new Card.Suit[7];

            //Set the cards and their suites
            for (int i = 0; i < 7; i++) {
                cardValues[i] = cards[i].value;
                cardSuits[i] = cards[i].suit;
            }

            ///Royal Flush - 9
            int[] flushCards = new[] { Array.IndexOf(cardValues, 10), Array.IndexOf(cardValues, 11), Array.IndexOf(cardValues, 12), Array.IndexOf(cardValues, 13), Array.IndexOf(cardValues, 14) };

            //Check if the straight exists
            if (flushCards.All(x => x != -1)) {
                Card.Suit[] flushSuits = new[] { cardSuits[flushCards[0]], cardSuits[flushCards[1]], cardSuits[flushCards[2]], cardSuits[flushCards[3]], cardSuits[flushCards[4]] };
                Card.Suit suit = flushSuits[0];

                //Check suits
                if (flushSuits.All(x => x == suit)) {
                    //Royal Flush
                    Console.WriteLine("Royal Flush");
                    return 9;
                }
            }

            //Straight Flush - 8
            bool straightFlush = false;
            bool straight = false;
            //Check the entire hand
            for (int i = 0; i < 7; i++) {
                int value = cardValues[i];

                int[] straightCards = new[] { i, Array.IndexOf(cardValues, value + 1), Array.IndexOf(cardValues, value + 1), Array.IndexOf(cardValues, value + 2), Array.IndexOf(cardValues, value + 3), Array.IndexOf(cardValues, value + 4) };

                //Check all 5 cards
                if (straightCards.All(x => x != -1)) {
                    Card.Suit[] straightSuits = new[] { cardSuits[straightCards[0]], cardSuits[straightCards[1]], cardSuits[straightCards[2]], cardSuits[straightCards[3]], cardSuits[straightCards[4]] };
                    Card.Suit suit = straightSuits[0];

                    //Check suits for straight flush
                    if (straightSuits.All(x => x == suit)) {
                        //Better straight flush
                        if (!straightFlush || straightCards[4] > highCards[0]) {
                            highCards[0] = straightCards[4];
                            straightFlush = true;
                        }
                    } else if (!straightFlush) {
                        //Check fro a better straight
                        if (!straight || straightCards[4] > highCards[0]) {
                            highCards[0] = straightCards[4];
                            straight = true;
                        }
                    }
                }
            }

            //Check for Ace low straight flush
            if (!straightFlush) {
                //Check if A-5 exists
                if (cardValues.Contains(14) && cardValues.Contains(2) && cardValues.Contains(3) && cardValues.Contains(4) && cardValues.Contains(5)) {
                    int[] aceStraightCards = new[] { Array.IndexOf(cardValues, 14), Array.IndexOf(cardValues, 2), Array.IndexOf(cardValues, 3), Array.IndexOf(cardValues, 4), Array.IndexOf(cardValues, 5) };
                    Card.Suit[] aceStraightSuits = new[] { cardSuits[aceStraightCards[0]], cardSuits[aceStraightCards[1]], cardSuits[aceStraightCards[2]], cardSuits[aceStraightCards[3]], cardSuits[aceStraightCards[4]] };
                    Card.Suit suit = aceStraightSuits[0];

                    //Check suits for straight flush
                    if (aceStraightSuits.All(x => x == suit)) {
                        //Check for better straight
                        if (!straightFlush || aceStraightCards[4] > highCards[0]) {
                            highCards[0] = aceStraightCards[4];
                            straightFlush = true;
                        } else if (!straightFlush) {
                            //Check for a better straight
                            if (!straight || aceStraightCards[4] > highCards[0]) {
                                highCards[0] = aceStraightCards[4];
                                straight = true;
                            }
                        }
                    }
                }
            }

            //If there's a straight flush
            if (straightFlush) {
                Console.WriteLine("Straight Flush");
                return 8;
            }

            //All Pairs/Trips/Quads
            Dictionary<int, int> duplicates = cardValues.GroupBy(item => item).ToDictionary(item => item.Key, item => item.Count());

            Stack<int> pairs = new Stack<int>(2);
            Stack<int> trips = new Stack<int>(1);
            Stack<int> quads = new Stack<int>(1);

            //Run through the groups
            foreach (KeyValuePair<int, int> entry in duplicates) {
                if (entry.Value == 4) {
                    quads.Push(entry.Key);
                }

                if (entry.Value == 3) {
                    trips.Push(entry.Key);
                }

                if (entry.Value == 2) {
                    pairs.Push(entry.Key);
                }
            }

            //Four of a Kind - 7
            if (quads.Count > 0) {
                highCards[0] = quads.Pop();

                //Get 1st high card
                for (int i = 6; i >= 0; i--) {
                    if (cardValues[i] != highCards[0]) {
                        highCards[1] = cardValues[i];
                    }
                }

                Console.WriteLine("Four of a Kind");
                return 7;
            }

            //Full House - 6
            if (trips.Count > 0) {
                if (pairs.Count > 0) {
                    //If you have both a 3 of a kind and a 2 of a kind
                    highCards[0] = trips.Pop();
                    highCards[1] = pairs.Pop();

                    Console.WriteLine("Full House");
                    return 6;
                }
            }

            //Flush - 5
            List<int> flush = cards.GroupBy(card => card.suit).FirstOrDefault(card => card.Count() >= 5)?.Select(card => card.value).ToList();

            //Has flush
            if (flush?.Count > 0) {
                //Go through each card
                int cardCount = flush.Count() - 1;

                //Get the 5 highest cards of the flush
                for (int i = cardCount; i >= 0; i--) {
                    highCards[cardCount - i] = flush[i];
                }

                Console.WriteLine("Flush");
                return 5;
            }

            //Straight, checked previously
            if (straight) {
                Console.WriteLine("Straight");
                return 4;
            }

            //Three of a Kind - 3
            if (trips.Count > 0) {
                highCards[0] = trips.Pop();

                //Get high cards
                for (int i = 6; i >= 0; i--) {

                    //Get 1st highest card
                    if (cardValues[i] != highCards[0]) {
                        highCards[1] = cardValues[i];
                        continue;
                    }

                    //Get 2nd highest card
                    if (highCards[1] != 0) {
                        if (cardValues[i] != highCards[0] && cardValues[i] != highCards[1]) {
                            highCards[2] = cardValues[i];
                            break;
                        }
                    }
                }

                Console.WriteLine("Three of a Kind");
                return 3;
            }

            //Two Pair - 2
            if (pairs.Count > 1) {
                highCards[0] = pairs.Pop();
                highCards[1] = pairs.Pop();

                //Get high cards
                for (int i = 6; i >= 0; i--) {

                    //Get 1st highest card
                    if (cardValues[i] != highCards[0] && cardValues[i] != highCards[1]) {
                        highCards[2] = cardValues[i];
                        break;
                    }
                }

                Console.WriteLine("Two Pair");
                return 2;
            }

            //One Pair - 1
            if (pairs.Count > 0) {
                highCards[0] = pairs.Pop();

                //Get high cards
                for (int i = 6; i >= 0; i--) {

                    //Get 1st highest card
                    if (cardValues[i] < highCards[0]) {
                        highCards[1] = cardValues[i];
                        continue;
                    }

                    //Get 2nd highest card
                    if (highCards[1] != 0 && cardValues[i] < highCards[1]) {
                        highCards[2] = cardValues[i];
                        continue;

                    }

                    //Get 3rd highest card
                    if (highCards[2] != 0 && cardValues[i] < highCards[2]) {
                        highCards[3] = cardValues[i];
                        break;
                    }
                }

                Console.WriteLine("One Pair");
                return 1;
            }

            //High Card - 0
            highCards[0] = cardValues[6];
            highCards[1] = cardValues[5];
            highCards[2] = cardValues[4];
            highCards[3] = cardValues[3];
            highCards[4] = cardValues[2];

            Console.WriteLine("High Card");
            return 0;
        }

        private int Raise(int targetBet, int raiseAmount) {
            return Call(targetBet) + Bet(raiseAmount);
        }

        private int Call(int targetBet) {
            if (currentBet < targetBet) {
                return Bet(targetBet - currentBet);
            }

            return 0;
        }

        public void SetBlind(Blinds blind, int amount) {
            switch (blind) {
                case Blinds.dealer:
                    if (draw) {
                        blindText.Text = "Dealer";
                    }
                    break;
                case Blinds.bigblind:
                    if (draw) {
                        blindText.Text = "BB";
                    }
                    Bet(amount);
                    break;
                case Blinds.smallblind:
                    if (draw) {
                        blindText.Text = "SB";
                    }
                    Bet(amount);
                    break;
            }
        }

        public int Bet(int amount) {
            if (amount <= 0) {
                return 0;
            }

            if (amount > money) {
                amount = money;
            }

            currentBet += amount;
            RemoveMoney(amount);

            UpdateText();

            return amount;
        }

        public void AddMoney(int amount) {
            if (amount < 0) {
                return;
            }

            money += amount;

            UpdateText();
        }

        public void RemoveMoney(int amount) {
            if (amount < 0) {
                return;
            }

            money -= amount;

            if (money < 0) {
                money = 0;
            }

            UpdateText();

        }

        public void UpdateText() {
            if (draw) {
                moneyText.Text = "$" + money;
                betText.Text = "$" + currentBet;

                card1.Text = hand[0]?.ToString();
                card2.Text = hand[1]?.ToString();
            }
        }

        public void Deal(Card card, int num) {
            hand[num] = card;
            UpdateText();
        }

        public override string ToString() {
            string output = "";

            foreach (Card card in hand) {
                output += card.ToString();
                output += " ";
            }

            return output;
        }
    }
}
