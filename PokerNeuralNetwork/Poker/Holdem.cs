using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PokerNeuralNetwork.Poker {
    public class Holdem {

        /// <summary>
        /// List of the turns
        /// </summary>
        public enum Turns {
            PreFlop,
            Flop,
            Turn,
            River
        }

        /// <summary>
        /// List of the possible hand rankings
        /// </summary>
        public enum Rankings {
            None,
            HighCard,
            Pair,
            TwoPair,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }

        /// <summary>
        /// List of all the different blind positions
        /// </summary>
        public enum Blinds {
            None,
            Dealer,
            SmallBlind,
            BigBlind
        }

        private Turns turn;

        private int dealer;
        private int currentTurn;

        private int playersPlayed;
        private int smallBlind;

        private int playersNotFolded;
        private List<Player> players;
        private Deck deck;

        private bool drawing = false;
        private TableLayoutPanel[] panels;
        private TableLayoutPanel middlePanel;

        private Card[] middleCards = new Card[5];

        /// <summary>
        /// The board that keeps track of the pot, bet, flipped cards, etc
        /// </summary>
        private Board board;

        /// <summary>
        /// Random object for seeding
        /// </summary>
        public Random rng;

        /// <summary>
        /// An ID for the table/thread
        /// </summary>
        public int TableID { get; private set; }

        /// <summary>
        /// Whether this table is finished or not
        /// </summary>
        public bool Finished { get; set; }

        /// <summary>
        /// Count of the total number of hands for this table
        /// </summary>
        public int HandCount { get; private set; }

        public Holdem(int tableID, int seed, TableLayoutPanel[] panels = null) {
            this.TableID = tableID;
            this.panels = panels;

            Finished = false;

            this.rng = new Random(seed);

            //Logging
            Console.WriteLine("New Table | TableID: '" + TableID + "' | Seed: '" + seed + "'");

            if (panels != null && panels.Count() >= 0) {
                drawing = true;
                middlePanel = panels[panels.Length - 1];
            }
        }

        public void NewGame(int playerCount, int smallBlind, int startingMoney) {

            this.smallBlind = smallBlind;

            board = new Board();

            players = new List<Player>();

            //Run through each player
            for (byte i = 0; i < playerCount; i++) {

                //Create player
                players.Add(new Player(i, startingMoney, board, ref rng));

                //If drawinging, tell the player to drawing
                if (drawing) {
                    players[i].SetPanel(panels[i]);
                }
            }

            //Pick the dealer
            dealer = rng.Next(0, playerCount);

            while (players.Count > 1) {

                //Set up a new hand
                NewHand();

                //Start new hand
                board.PotWinners(StartHand());

                //Remove players who have 0 balance
                List<Player> removals = new List<Player>();
                foreach (Player player in players) {
                    player.NewHand();

                    if (player.Balance == 0) {
                        removals.Add(player);
                    }
                }

                foreach (Player player in removals) {
                    players.Remove(player);
                }
            }

            Console.WriteLine("Table " + TableID + " finished in " + HandCount + " hands.");
            Finished = true;
        }

        private void NewHand() {
            board.NewHand();

            HandCount++;

            //Get new dealer
            dealer = (dealer + 1) % players.Count;
            int sb = (dealer + 1) % players.Count;
            int bb = (sb + 1) % players.Count;
            currentTurn = (bb + 1) % players.Count;

            players[dealer].SetBlind(Blinds.Dealer);

            players[sb].SetBlind(Blinds.SmallBlind);
            players[sb].PlaceBet(smallBlind);

            players[bb].SetBlind(Blinds.BigBlind);
            players[bb].PlaceBet(smallBlind * 2);

            turn = Turns.PreFlop;

            //Create the deck
            deck = new Deck(rng);

            playersNotFolded = players.Count;

            for (int i = 0; i < 2; i++) {
                foreach (Player player in players) {
                    player.Deal(deck.NextCard());
                }
            }

            playersPlayed = 0;
        }

        private Stack<Player> StartHand() {
            //Pre-Flop betting
            PlayersMove();

            while (playersNotFolded > 1 && turn != Turns.River) {
                NextTurn();

                PlayersMove();
            }

            //If only one player hasn't folded
            if (playersNotFolded == 1) {
                //Get the player who hasn't folded
                Stack<Player> winners = new Stack<Player>();
                winners.Push(players.Where(player => !player.Folded).First());

                return winners;
            }

            //If we've done all betting, compare hands
            if (turn == Turns.River) {
                //Get rankings for each player
                List<Tuple<Holdem.Rankings, List<int>>> rankings = new List<Tuple<Rankings, List<int>>>();

                foreach (Player player in players) {
                    if (!player.Folded) {
                        rankings.Add(player.GetHandRanking(middleCards));
                    }
                }

                //Keep track of the best rank
                Rankings highestRank = Rankings.None;

                //Item1 - Player object
                //Item2 - HighCards list object
                List<Tuple<Player, List<int>>> highestRankPlayers = new List<Tuple<Player, List<int>>>();

                //Get the highest ranking and all players who have it
                for (int i = 0; i < rankings.Count; i++) {
                    if (rankings[i].Item1 == highestRank) {
                        highestRankPlayers.Add(Tuple.Create(players[i], rankings[i].Item2));
                    }

                    if (rankings[i].Item1 > highestRank) {
                        highestRank = rankings[i].Item1;
                        highestRankPlayers.Clear();
                        highestRankPlayers.Add(Tuple.Create(players[i], rankings[i].Item2));
                    }
                }

                //If there's a tie
                if (highestRankPlayers.Count > 1) {
                    return RankTiebreaker(highestRankPlayers, highestRank);
                } else if (highestRankPlayers.Count == 1) {
                    //Get the winner
                    Stack<Player> winners = new Stack<Player>();
                    winners.Push(highestRankPlayers[0].Item1);

                    return winners;
                } else {
                    Console.WriteLine("No Winners!", Console.LogTypes.ERROR);
                }
            }

            return new Stack<Player>();
        }

        private void NextTurn() {
            playersPlayed = 0;
            //currentTurn = (dealer + 1) % players.Count;

            //Flip the flop
            if (turn == Turns.PreFlop) {
                middleCards[0] = deck.NextCard();
                middleCards[1] = deck.NextCard();
                middleCards[2] = deck.NextCard();

                if (drawing) {
                    TextBox flop1 = (TextBox)middlePanel.Controls.Find("Flop1", true)[0];
                    TextBox flop2 = (TextBox)middlePanel.Controls.Find("Flop2", true)[0];
                    TextBox flop3 = (TextBox)middlePanel.Controls.Find("Flop3", true)[0];

                    flop1.Text = middleCards[0].ToString();
                    flop2.Text = middleCards[1].ToString();
                    flop3.Text = middleCards[2].ToString();
                }

                turn = Turns.Flop;
            }

            //Flip the turn
            else if (turn == Turns.Flop) {
                middleCards[3] = deck.NextCard();

                if (drawing) {
                    TextBox turnText = (TextBox)middlePanel.Controls.Find("Turn1", true)[0];

                    turnText.Text = middleCards[3].ToString();
                }

                turn = Turns.Turn;
            }

            //Flip the river
            else if (turn == Turns.Turn) {
                middleCards[4] = deck.NextCard();

                if (drawing) {
                    TextBox river = (TextBox)middlePanel.Controls.Find("River1", true)[0];

                    river.Text = middleCards[4].ToString();
                }

                turn = Turns.River;
            }
        }

        private void PlayersMove() {
            while (playersNotFolded > 1) {
                if (playersPlayed >= players.Count && CheckTurnOver()) {
                    break;
                }

                PlayerMove(players[currentTurn]);
                playersPlayed++;
                currentTurn = (currentTurn + 1) % players.Count;
            }
        }

        private void PlayerMove(Player player) {
            if (!player.Folded) {
                player.MakeMove();

                if (player.Folded) {
                    playersNotFolded--;
                }

                if (drawing) {
                    middlePanel.Controls.Find("PotText", true)[0].Text = "Pot: $" + board.Pot;
                    middlePanel.Controls.Find("BetText", true)[0].Text = "Bet: $" + board.Pot;
                }
            }
        }

        private Stack<Player> RankTiebreaker(List<Tuple<Player, List<int>>> players, Rankings highestRank) {

            Stack<Player> winners = new Stack<Player>();

            //Royal Flush, split pot
            if (highestRank == Rankings.RoyalFlush) {

                //Run through each hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    //Everyone splits pot
                    winners.Push(tuple.Item1);
                }
            }

            //Straight/Straight Flush
            else if (highestRank == Rankings.Straight || highestRank == Rankings.StraightFlush) {
                int winnerHighCard = 0;

                //Run through every hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;

                    //Highest card ties
                    if (hand[0] == winnerHighCard) {

                        //Split pot
                        winners.Push(player);
                    }

                    //Highest card beats
                    else if (hand[0] > winnerHighCard) {
                        winners.Clear();
                        winners.Push(player);
                        winnerHighCard = hand[0];
                    }
                }
            }

            //Four of a Kind
            else if (highestRank == Rankings.FourOfAKind) {
                List<int> winnerHighCards = new List<int>(new int[5]);

                //Run through every hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;


                    //4 of a Kind ties
                    if (hand[0] == winnerHighCards[0]) {

                        //Kicker ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Split pot
                            winners.Push(player);
                        }

                        //Kicker beats
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(player);
                            winnerHighCards = hand;
                        }
                    }

                        //4 of a Kind beats
                        else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(player);
                        winnerHighCards = hand;
                    }

                }
            }

            //Full House
            else if (highestRank == Rankings.FullHouse) {
                List<int> winnerHighCards = new List<int>(new int[5]);

                //Run through every hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;

                    //3 of a Kind ties
                    if (hand[0] == winnerHighCards[0]) {

                        //Pair ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Split pot
                            winners.Push(player);
                        }

                        //Pair beats
                        else if (hand[0] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(player);
                            winnerHighCards = hand;
                        }
                    }

                    //2 of a Kind beats
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(player);
                        winnerHighCards = hand;
                    }

                }
            }

            //High Card/Flush
            else if (highestRank == Rankings.HighCard || highestRank == Rankings.Flush) {
                List<int> winnerHighCards = new List<int>(new int[5]);

                //Run through each hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;

                    //Check the cards sequentially
                    for (int n = 0; n < 5; n++) {

                        //Card is beat
                        if (hand[n] < winnerHighCards[n]) {
                            break;
                        }

                        //Card beats
                        else if (hand[n] > winnerHighCards[n]) {
                            winners.Clear();
                            winners.Push(player);
                            winnerHighCards = hand;
                        }

                        //If all cards tie
                        else if (n == 4 && hand[n] == winnerHighCards[n]) {

                            //Split pot
                            winners.Push(player);
                        }
                    }
                }
            }

            //Three of a Kind/Two Pair
            else if (highestRank == Rankings.ThreeOfAKind || highestRank == Rankings.TwoPair) {
                List<int> winnerHighCards = new List<int>(new int[5]);

                //Run through each hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;

                    //2 Pair - high pair
                    //3 of a Kind - 3 of a kind
                    //Tie
                    if (hand[0] == winnerHighCards[0]) {
                        //2 Pair - low pair
                        //3 of a Kind - first kicker
                        //Tie
                        if (hand[1] == winnerHighCards[1]) {
                            //2 Pair - kicker
                            //3 of a Kind - second kicker
                            //Tie
                            if (hand[2] == winnerHighCards[2]) {

                                //Split pot
                                winners.Push(player);
                            }

                            //2 Pair - kicker
                            //3 of a Kind - second kicker
                            //Beat
                            else if (hand[2] > winnerHighCards[2]) {
                                winners.Clear();
                                winners.Push(player);
                                winnerHighCards = hand;
                            }
                        }

                        //2 Pair - low pair
                        //3 of a Kind - first kicker
                        //Beat
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(player);
                            winnerHighCards = hand;
                        }
                    }

                    //2 Pair - high pair
                    //3 of a Kind - 3 of a kind
                    //Beat
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(player);
                        winnerHighCards = hand;
                    }
                }
            }

            //One Pair
            else if (highestRank == Rankings.Pair) {
                List<int> winnerHighCards = new List<int>(new int[5]);

                //Run through each hand
                foreach (Tuple<Player, List<int>> tuple in players) {
                    Player player = tuple.Item1;
                    List<int> hand = tuple.Item2;

                    //Pair ties
                    if (hand[0] == winnerHighCards[0]) {

                        //First kicker ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Second kicker ties
                            if (hand[2] == winnerHighCards[2]) {

                                //Third kicker ties
                                if (hand[3] == winnerHighCards[3]) {

                                    //Split pot
                                    winners.Push(player);
                                }

                                //Third kicker beats
                                else if (hand[3] > winnerHighCards[3]) {
                                    winners.Clear();
                                    winners.Push(player);
                                    winnerHighCards = hand;
                                }
                            }

                            //Second kicker beats
                            else if (hand[2] > winnerHighCards[2]) {
                                winners.Clear();
                                winners.Push(player);
                                winnerHighCards = hand;
                            }
                        }

                        //First kicker beats
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(player);
                            winnerHighCards = hand;
                        }
                    }

                    //Pair beats
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(player);
                        winnerHighCards = hand;
                    }
                }
            }

            if (winners.Count == 0) {
                Console.WriteLine("No winners found!", Console.LogTypes.ERROR);
            }

            return winners;
        }

        private bool CheckTurnOver() {
            foreach (Player player in players) {
                if (player.Balance != 0 && player.Bet != board.Bet) {
                    return false;
                }
            }

            return true;
        }

        public Player GetWinner() {
            if (Finished) {
                return players[0];
            }

            return null;
        }
    }
}
