using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PokerNeuralNetwork.Poker {
    public class Holdem {
        Random rng;

        public enum Turns {
            PreFlop,
            Flop,
            Turn,
            River
        }

        public enum Rankings {
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

        Turns turn;

        int dealer;
        int currentTurn;

        int bet;
        int pot;

        int playersPlayed;
        int smallBlind;

        public bool finished = false;

        int playerCount;
        Player[] players;
        Deck deck;

        bool draw = false;
        TableLayoutPanel[] panels;
        TableLayoutPanel middlePanel;

        Card[] middleCards = new Card[5];

        public Holdem(int playerCount, TableLayoutPanel[] panels = null) {
            this.playerCount = playerCount;
            this.panels = panels;

            //Generate a new seed
            int seed = new Random().Next();
            //int seed = 1;
            rng = new Random(seed);

            //Logging
            Console.WriteLine("NEW HOLDEM GAME");
            Console.WriteLine("SEED: " + seed);
            Console.WriteLine("PLAYERS: " + playerCount);

            if (panels != null && panels.Count() >= 0) {
                draw = true;
                middlePanel = panels[panels.Length - 1];
            }

            //Pick the dealer
            dealer = rng.Next(0, playerCount);

            //Initiate the players
            players = new Player[playerCount];
        }

        public void NewGame(int smallBlind, int startingMoney) {
            this.smallBlind = smallBlind;

            //Run through each player
            for (int i = 0; i < playerCount; i++) {

                //Create player
                players[i] = new Player(i, startingMoney);

                //If drawing, tell the player to draw
                if (draw) {
                    players[i].SetPanel(panels[i]);
                }
            }

            //Get new dealer
            dealer = (dealer + 1) % players.Length;
            int sb = (dealer + 1) % players.Length;
            int bb = (sb + 1) % players.Length;
            currentTurn = (bb + 1) % players.Length;

            players[dealer].SetBlind(Player.Blinds.dealer, 0);
            players[sb].SetBlind(Player.Blinds.smallblind, smallBlind);
            players[bb].SetBlind(Player.Blinds.bigblind, smallBlind * 2);

            bet = smallBlind * 2;
            pot = smallBlind * 3;

            turn = Turns.PreFlop;

            //Create the deck
            deck = new Deck(rng);

            for (int i = 0; i < 2; i++) {
                foreach (Player player in players) {
                    player.Deal(deck.NextCard(), i);
                }
            }

            playersPlayed = 0;

            PlayerMove();
        }

        private void NextTurn() {
            playersPlayed = 0;

            if (turn == Turns.PreFlop) {
                middleCards[0] = deck.NextCard();
                middleCards[1] = deck.NextCard();
                middleCards[2] = deck.NextCard();

                if (draw) {
                    TextBox flop1 = (TextBox)middlePanel.Controls.Find("Flop1", true)[0];
                    TextBox flop2 = (TextBox)middlePanel.Controls.Find("Flop2", true)[0];
                    TextBox flop3 = (TextBox)middlePanel.Controls.Find("Flop3", true)[0];

                    flop1.Text = middleCards[0].ToString();
                    flop2.Text = middleCards[1].ToString();
                    flop3.Text = middleCards[2].ToString();
                }

                currentTurn = (dealer + 1) % players.Length;

                turn = Turns.Flop;

                Console.WriteLine("Flop: " + middleCards[0] + middleCards[1] + middleCards[2]);

                PlayerMove();
            }

            //Flip the flop
            else if (turn == Turns.Flop) {
                middleCards[3] = deck.NextCard();

                if (draw) {
                    TextBox turnText = (TextBox)middlePanel.Controls.Find("Turn1", true)[0];

                    turnText.Text = middleCards[3].ToString();
                }

                currentTurn = (dealer + 1) % players.Length;

                turn = Turns.Turn;

                Console.WriteLine("Turn: " + middleCards[3]);

                PlayerMove();
            }

            //Flip the turn
            else if (turn == Turns.Turn) {
                middleCards[4] = deck.NextCard();

                if (draw) {
                    TextBox river = (TextBox)middlePanel.Controls.Find("River1", true)[0];

                    river.Text = middleCards[4].ToString();
                }

                currentTurn = (dealer + 1) % players.Length;

                turn = Turns.River;

                Console.WriteLine("River: " + middleCards[4]);

                PlayerMove();
            }

            //Round over
            else if (turn == Turns.River) {
                //Get rankings for each player
                int[] rankings = new int[players.Length];

                for (int i = 0; i < players.Length; i++) {
                    rankings[i] = players[i].GetHandRanking(middleCards);
                }

                int highestRank = -1;
                Stack<int> highestRankPlayers = new Stack<int>();

                for (int i = 0; i < rankings.Length; i++) {
                    if (rankings[i] == highestRank) {
                        highestRankPlayers.Push(i);
                    }

                    if (rankings[i] > highestRank) {
                        highestRank = rankings[i];
                        highestRankPlayers.Clear();
                        highestRankPlayers.Push(i);
                    }
                }

                //If there's a tie
                if (highestRankPlayers.Count > 1) {
                    RankTiebreaker(highestRankPlayers, highestRank);
                } else {
                    int winner = highestRankPlayers.Pop();
                    players[winner].AddMoney(pot);

                    Console.WriteLine(winner + " won the pot of " + pot);
                }

                pot = smallBlind * 3;
                bet = smallBlind * 2;
            }

        }

        private void RankTiebreaker(Stack<int> highestRankPlayers, int highestRank) {

            Dictionary<int, List<int>> highCards = new Dictionary<int, List<int>>();

            //Get the highCards of each player including the field
            foreach (int playerID in highestRankPlayers) {
                Player player = players[playerID];

                List<int> playerHighCards = player.highCards.OrderBy(card => card).ToList();

                Console.WriteLine("HERE");
                Console.WriteLine(string.Join(", ", playerHighCards));
                Console.WriteLine("HERE");

                highCards.Add(playerID, playerHighCards);
            }

            Stack<int> winners = new Stack<int>();

            //Royal Flush, split pot
            if (highestRank == 9) {

                //Run through each hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    //Everyone splits pot
                    winners.Push(playerID);

                }
            }

            //Straight/Straight Flush
            else if (highestRank == 4 || highestRank == 8) {
                int winnerHighCard = 0;

                //Run through every hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    //Highest card ties
                    if (hand[0] == winnerHighCard) {

                        //Split pot
                        winners.Push(playerID);
                    }

                    //Highest card beats
                    else if (hand[0] > winnerHighCard) {
                        winners.Clear();
                        winners.Push(playerID);
                        winnerHighCard = hand[0];
                    }
                }
            }

            //Four of a Kind
            else if (highestRank == 7) {
                List<int> winnerHighCards = new List<int>(5);

                //Run through every hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    //4 of a Kind ties
                    if (hand[0] == winnerHighCards[0]) {

                        //Kicker ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Split pot
                            winners.Push(playerID);
                        }

                        //Kicker beats
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(playerID);
                            winnerHighCards = hand;
                        }
                    }

                    //4 of a Kind beats
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(playerID);
                        winnerHighCards = hand;
                    }

                }
            }

            //Full House
            else if (highestRank == 6) {
                List<int> winnerHighCards = new List<int>(5);

                //Run through every hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    //3 of a Kind ties
                    if (hand[0] == winnerHighCards[0]) {

                        //Pair ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Split pot
                            winners.Push(playerID);
                        }

                        //Pair beats
                        else if (hand[0] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(playerID);
                            winnerHighCards = hand;
                        }
                    }

                    //2 of a Kind beats
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(playerID);
                        winnerHighCards = hand;
                    }

                }
            }

            //High Card/Flush
            else if (highestRank == 0 || highestRank == 5) {
                List<int> winnerHighCards = new List<int>(5);

                //Run through each hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    //Check the cards sequentially
                    for (int n = 0; n < 5; n++) {

                        Console.WriteLine("N: " + n);

                        //Card is beat
                        if (hand[n] < winnerHighCards[n]) {
                            break;
                        }

                        //Card beats
                        else if (hand[n] > winnerHighCards[n]) {
                            winners.Clear();
                            winners.Push(playerID);
                            winnerHighCards = hand;
                        }

                        //If all cards tie
                        else if (n == 4 && hand[n] == winnerHighCards[n]) {

                            //Split pot
                            winners.Push(playerID);
                        }
                    }
                }
            }

            //Three of a Kind/Two Pair
            else if (highestRank == 2 || highestRank == 3) {
                List<int> winnerHighCards = new List<int>(5);

                //Run through each hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    Console.WriteLine("3/2p: " + hand.Count()); 
                    foreach(int card in hand) {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine("\n");

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
                                winners.Push(playerID);
                            }

                            //2 Pair - kicker
                            //3 of a Kind - second kicker
                            //Beat
                            else if (hand[2] > winnerHighCards[2]) {
                                winners.Clear();
                                winners.Push(playerID);
                                winnerHighCards = hand;
                            }
                        }

                        //2 Pair - low pair
                        //3 of a Kind - first kicker
                        //Beat
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(playerID);
                            winnerHighCards = hand;
                        }
                    }

                    //2 Pair - high pair
                    //3 of a Kind - 3 of a kind
                    //Beat
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(playerID);
                        winnerHighCards = hand;
                    }
                }
            }

            //One Pair
            else if (highestRank == 1) {
                List<int> winnerHighCards = new List<int>(5);

                //Run through each hand
                foreach (KeyValuePair<int, List<int>> pair in highCards) {
                    int playerID = pair.Key;
                    List<int> hand = pair.Value;

                    Console.WriteLine("1p: " + hand.Count());
                    foreach (int card in hand) {
                        Console.WriteLine(card);
                    }

                    //Pair ties
                    if (hand[0] == winnerHighCards[0]) {

                        //First kicker ties
                        if (hand[1] == winnerHighCards[1]) {

                            //Second kicker ties
                            if (hand[2] == winnerHighCards[2]) {

                                //Third kicker ties
                                if (hand[3] == winnerHighCards[3]) {

                                    //Split pot
                                    winners.Push(playerID);
                                }

                                //Third kicker beats
                                else if (hand[3] > winnerHighCards[3]) {
                                    winners.Clear();
                                    winners.Push(playerID);
                                    winnerHighCards = hand;
                                }
                            }

                            //Second kicker beats
                            else if (hand[2] > winnerHighCards[2]) {
                                winners.Clear();
                                winners.Push(playerID);
                                winnerHighCards = hand;
                            }
                        }

                        //First kicker beats
                        else if (hand[1] > winnerHighCards[1]) {
                            winners.Clear();
                            winners.Push(playerID);
                            winnerHighCards = hand;
                        }
                    }

                    //Pair beats
                    else if (hand[0] > winnerHighCards[0]) {
                        winners.Clear();
                        winners.Push(playerID);
                        winnerHighCards = hand;
                    }
                }
            }

            if (winners.Count == 0) {
                throw new Exception("Tie hand shouldn't reach here when winners is 0");
            } else {
                int winnerCount = winners.Count;
                int winnings = pot / winnerCount;

                while (winners.Count > 0) {
                    int playerIndex = winners.Pop();
                    players[playerIndex].AddMoney(winnings);

                    Console.WriteLine(playerIndex + " won " + winnings + " and now has " + players[playerIndex].money);
                }

                if (winnerCount > 1) {
                    Console.WriteLine(winnerCount + " split a " + pot + " pot for " + winnings + " each.");
                }

            }

            return;
        }

        public void PlayerMove() {
            //Result is the amount that the player called/raised
            int result = players[currentTurn].Play(bet);

            //Call/Raise
            if (result > 0) {
                pot += result;

                if (players[currentTurn].currentBet > bet) {
                    bet = players[currentTurn].currentBet;
                }

                if (draw) {
                    middlePanel.Controls.Find("PotText", true)[0].Text = "Pot: $" + pot;
                    middlePanel.Controls.Find("BetText", true)[0].Text = "Bet: $" + bet;
                }
            }

            //Check
            if (result == 0) {
                //Do nothing
            }

            //Fold
            if (result == -1) {
                //Remove player
            }

            playersPlayed++;

            if (playersPlayed >= players.Length && CheckTurnOver()) {
                NextTurn();
            } else {
                currentTurn = (currentTurn + 1) % players.Length;

                PlayerMove();
            }
        }

        private bool CheckTurnOver() {
            foreach (Player player in players) {
                if (player.currentBet != bet) {
                    return false;
                }
            }

            return true;
        }
    }
}
