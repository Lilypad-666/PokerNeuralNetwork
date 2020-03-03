using PokerNeuralNetwork.Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerNeuralNetwork {
    public class Board {
        private double bet;
        public double Bet { 
            get { return Math.Round(bet, 2, MidpointRounding.AwayFromZero); }
            private set { bet = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
        }

        private double pot;
        public double Pot {
            get { return Math.Round(pot, 2, MidpointRounding.AwayFromZero); }
            private set { pot = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
        }

        public void MakeBet(double amount) {
            if (amount > Bet) {
                Bet = amount;
            }

            Pot += amount;
        }

        public void PotWinners(Stack<Player> winners) {
            double winnings = Pot / winners.Count;

            if (winners.Count == 0) {
                Console.WriteLine("No winners!", Console.LogTypes.ERROR);
            }

            while (winners.Count > 0) {
                Player winner = winners.Pop();
                winner.AddMoney(winnings);
            }
        }

        public void NewHand() {
            Bet = 0;
            Pot = 0;
        }
    }
}
