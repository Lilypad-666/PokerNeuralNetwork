
namespace PokerNeuralNetwork.Poker {
    class Card {
        public enum Suit {
            Heart,
            Diamond,
            Club,
            Spade
        }

        public Suit suit;
        public int value;

        public Card(Suit suit, int value) {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString() {
            string output = "";

            switch (value) {
                case 2:
                    output += "2";
                    break;
                case 3:
                    output += "3";
                    break;
                case 4:
                    output += "4";
                    break;
                case 5:
                    output += "5";
                    break;
                case 6:
                    output += "6";
                    break;
                case 7:
                    output += "7";
                    break;
                case 8:
                    output += "8";
                    break;
                case 9:
                    output += "9";
                    break;
                case 10:
                    output += "10";
                    break;
                case 11:
                    output += "J";
                    break;
                case 12:
                    output += "Q";
                    break;
                case 13:
                    output += "K";
                    break;
                case 14:
                    output += "A";
                    break;
            }

            switch (suit) {
                case Suit.Club:
                    output += '♣';
                    break;
                case Suit.Spade:
                    output += '♠';
                    break;
                case Suit.Diamond:
                    output += '♦';
                    break;
                case Suit.Heart:
                    output += '♥';
                    break;
            }

            return output;
        }
    }
}
