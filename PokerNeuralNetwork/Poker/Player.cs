using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PokerNeuralNetwork.Poker {
    public class Player {

        /// <summary>
        /// Variables used for drawing on the screen
        /// </summary>
        private bool drawing = false;
        private Panel panel;
        private TextBox card1;
        private TextBox card2;
        private TextBox moneyText;
        private TextBox blindText;
        private TextBox betText;

        /// <summary>
        /// The current position in the board
        /// </summary>
        private Holdem.Blinds blind;

        /// <summary>
        /// Reference to the board
        /// </summary>
        private Board board;

        /// <summary>
        /// The ID for this player
        /// </summary>
        public byte ID { get; private set; }

        /// <summary>
        /// This player's current hand
        /// </summary>
        private List<Card> Hand { get; set; }

        /// <summary>
        /// This player's current balance
        /// </summary>
        private double balance;
        public double Balance {
            get { return Math.Round(balance, 2, MidpointRounding.AwayFromZero); }
            private set { balance = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
        }

        /// <summary>
        /// This player's current bet
        /// </summary>
        private double bet;
        public double Bet {
            get { return Math.Round(bet, 2, MidpointRounding.AwayFromZero); }
            private set { bet = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
        }

        /// <summary>
        /// Whether this player has folded this hand
        /// </summary>
        public bool Folded { get; private set; }

        /// <summary>
        /// Reference to the table's Random object
        /// </summary>
        private Random rng;

        /// <summary>
        /// Create a new player with given id and balance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="balance"></param>
        public Player(byte id, double balance, Board board, ref Random rng) {
            ID = id;
            Balance = balance;
            this.board = board;
            this.rng = rng;

            Hand = new List<Card>();

            UpdateText();
        }

        /// <summary>
        /// Set the panels for drawing or disables drawing
        /// </summary>
        /// <param name="panel"></param>
        public void SetPanel(TableLayoutPanel panel = null) {
            if (panel == null) {
                drawing = false;

                if (this.panel != null) {
                    this.panel.Visible = false;
                    this.panel = null;
                }
            } else {
                drawing = true;

                this.panel = panel;
                this.panel.Visible = true;

                card1 = (TextBox)panel.Controls.Find("Player" + ID + "Card1", true)[0];
                card2 = (TextBox)panel.Controls.Find("Player" + ID + "Card2", true)[0];
                moneyText = (TextBox)panel.Controls.Find("Player" + ID + "Money", true)[0];
                blindText = (TextBox)panel.Controls.Find("BlindDealerText" + ID, true)[0];
                betText = (TextBox)panel.Controls.Find("CurrentBet" + ID, true)[0];
            }
        }

        /// <summary>
        /// Pick what the player does on their turn
        /// </summary>
        /// <param name="targetBet"></param>
        public void MakeMove() {

            int play = rng.Next(0, 1);
            double raiseAmount = 0;

            if (rng.Next(0, 5) == 0) {
                raiseAmount = rng.Next(1, 101);
            } else {
                play = 0;
            }

            play = 0;

            //Check/Call
            if (play == 0) {
                Call();
            }
            
            else if (play > 0) {
                Raise(raiseAmount);
            }
            
            //Fold
            else {
                Folded = true;
            }
        }

        /// <summary>
        /// Gets the ranking of the hand including the potential high cards
        /// </summary>
        /// <param name="middleCards">5 field cards</param>
        /// <returns></returns>
        public Tuple<Holdem.Rankings, List<int>> GetHandRanking(Card[] middleCards) {
            //The 5 cards that are used to compare hands at the end of a round
            List<int> highCards = new List<int>( new int[5] );

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 2; i++) {
                cards.Add(Hand[i]);
            }

            for (int i = 0; i < 5; i++) {
                cards.Add(middleCards[i]);
            }

            //Sort the cards
            cards = cards.OrderBy(x => x.value).ToList();

            int[] cardValues = new int[7];
            Card.Suit[] cardSuits = new Card.Suit[7];

            //Set the cards and their suites
            for (int i = 0; i < 7; i++) {
                cardValues[i] = cards[i].value;
                cardSuits[i] = cards[i].suit;
            }

            ///Royal Flush
            int[] flushCards = new[] { Array.IndexOf(cardValues, 10), Array.IndexOf(cardValues, 11), Array.IndexOf(cardValues, 12), Array.IndexOf(cardValues, 13), Array.IndexOf(cardValues, 14) };

            //Check if the straight exists
            if (flushCards.All(x => x != -1)) {
                Card.Suit[] flushSuits = new[] { cardSuits[flushCards[0]], cardSuits[flushCards[1]], cardSuits[flushCards[2]], cardSuits[flushCards[3]], cardSuits[flushCards[4]] };
                Card.Suit suit = flushSuits[0];

                //Check suits
                if (flushSuits.All(x => x == suit)) {
                    //Royal Flush
                    return Tuple.Create(Holdem.Rankings.RoyalFlush, highCards.OrderBy(value => value).ToList());
                }
            }

            //Straight Flush
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
                return Tuple.Create(Holdem.Rankings.StraightFlush, highCards.OrderBy(value => value).ToList());
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

            //Four of a Kind
            if (quads.Count > 0) {
                highCards[0] = quads.Pop();

                //Get 1st high card
                for (int i = 6; i >= 0; i--) {
                    if (cardValues[i] != highCards[0]) {
                        highCards[1] = cardValues[i];
                    }
                }

                return Tuple.Create(Holdem.Rankings.FourOfAKind, highCards.OrderBy(value => value).ToList());
            }

            //Full House
            if (trips.Count > 0) {
                if (pairs.Count > 0) {
                    //If you have both a 3 of a kind and a 2 of a kind
                    highCards[0] = trips.Pop();
                    highCards[1] = pairs.Pop();

                    return Tuple.Create(Holdem.Rankings.FullHouse, highCards.OrderBy(value => value).ToList());
                }
            }

            //Flush
            List<int> flush = cards.GroupBy(card => card.suit).FirstOrDefault(card => card.Count() >= 5)?.Select(card => card.value).ToList();

            //Has flush
            if (flush?.Count > 0) {
                //Reverse the Flush array
                flush.Reverse();

                for (int i = 0; i < 5; i++) {
                    highCards[i] = flush[i];
                }

                return Tuple.Create(Holdem.Rankings.Flush, highCards.OrderBy(value => value).ToList());
            }

            //Straight, checked previously
            if (straight) {
                return Tuple.Create(Holdem.Rankings.Flush, highCards.OrderBy(value => value).ToList());
            }

            //Three of a Kind
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

                return Tuple.Create(Holdem.Rankings.ThreeOfAKind, highCards.OrderBy(value => value).ToList());
            }

            //Two Pair
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

                return Tuple.Create(Holdem.Rankings.TwoPair, highCards.OrderBy(value => value).ToList());
            }

            //One Pair
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

                return Tuple.Create(Holdem.Rankings.Pair, highCards.OrderBy(value => value).ToList());
            }

            //High Card
            highCards[0] = cardValues[6];
            highCards[1] = cardValues[5];
            highCards[2] = cardValues[4];
            highCards[3] = cardValues[3];
            highCards[4] = cardValues[2];

            return Tuple.Create(Holdem.Rankings.HighCard, highCards.OrderBy(value => value).ToList());
        }

        private void Raise(double raiseAmount) {
            Call();
            PlaceBet(raiseAmount);
        }

        private void Call() {
            if (Bet < board.Bet) {
                PlaceBet(board.Bet - Bet);
            }
        }

        public void SetBlind(Holdem.Blinds blind) {
            this.blind = blind;

            UpdateText();

        }

        public void PlaceBet(double amount) {
            if (amount <= 0) {
                Console.WriteLine("Bet amount <= 0!", Console.LogTypes.ERROR);
                return;
            }

            if (amount > Balance) {
                amount = Balance;
            }

            Bet += amount;
            RemoveMoney(amount);

            board.MakeBet(amount);

            UpdateText();
        }

        /// <summary>
        /// Clears all info for a new hand
        /// </summary>
        public void NewHand() {
            Hand = new List<Card>();
            Folded = false;
            blind = Holdem.Blinds.None;
            Bet = 0;
        }

        /// <summary>
        /// Adds money to the player
        /// </summary>
        /// <param name="amount"></param>
        public void AddMoney(double amount) {
            if (amount <= 0) {
                Console.WriteLine("Attempted to add $" + amount + " money to " + ID + ".", Console.LogTypes.ERROR);
                return;
            }

            Balance += amount;

            UpdateText();
        }

        /// <summary>
        /// Removes money from the player
        /// </summary>
        /// <param name="amount"></param>
        public void RemoveMoney(double amount) {
            if (amount < 0) {
                Console.WriteLine("Attempted to remove $" + amount + " money from " + ID + ".", Console.LogTypes.ERROR);
                return;
            }

            Balance -= amount;

            if (Balance < 0) {
                Balance = 0;
            }

            UpdateText();
        }

        private void UpdateText() {
            if (drawing) {
                moneyText.Text = "$" + Balance;
                betText.Text = "$" + Bet;

                card1.Text = Hand[0]?.ToString();
                card2.Text = Hand[1]?.ToString();

                switch (blind) {
                    case Holdem.Blinds.None:
                        blindText.Text = "None";
                        break;
                    case Holdem.Blinds.Dealer:
                        blindText.Text = "Dealer";
                        break;
                    case Holdem.Blinds.BigBlind:
                        blindText.Text = "BB";
                        break;
                    case Holdem.Blinds.SmallBlind:
                        blindText.Text = "SB";
                        break;
                }
            }
        }

        public void Deal(Card card) {
            Hand.Add(card);
            UpdateText();
        }

        public override string ToString() {
            string output = ID + ":";

            output += Balance + ":";

            foreach (Card card in Hand) {
                output += card.ToString();
                output += " ";
            }

            return output;
        }
    }
}
