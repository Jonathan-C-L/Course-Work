/* CMPE 1666 - Intermediate Programming ICA8
 * 
 * Author: Jonathan Le
 * 
 * Date: Feb. 24, 2025
 * 
 * Purpose: program with create a deck of cards, shuffle them using the Fischer-Yates algorithm,
 * deal the cards to 10 players, then determines the winners based on the sum of points their
 * cards are worth (suit * rank)
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA8_Jonathan_Le
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// initialization of arrays for use later in the program
        /// </summary>
        Card[] deck = new Card[52];
        Card[,] playerHands = new Card[10, 5];
        int[] playerPoints = new int[10];
        Card[] shuffleDeck = new Card[52];

        /// <summary>
        /// storage for card information
        /// </summary>
        private struct Card
        {
            public Suits _suit;
            public int _rank;
            public int _points;
            public Symbol _symbol;
        }
        /// <summary>
        /// enum of suits and their respective weights
        /// </summary>
        private enum Suits
        {
            Heart = 4,
            Diamond = 3,
            Club = 2,
            Spade = 1
        }
        /// <summary>
        /// enum for Jacks, Queens, King, and Ace
        /// </summary>
        private enum Symbol
        {
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        }
        public Form1()
        {
            InitializeComponent();
            int card = 0;

            //to iterate through suits
            for (int suit = 1; suit <= 4; suit++)
            {
                //to iterate through ranks
                for (int rank = 2; rank <= 14; rank++)
                {
                    deck[card] = CreateCard(suit, rank);
                    //ensuring new card is added for each iteration
                    card++;
                }
            }
        }

        private void Button_Clicks(object sender, EventArgs e)
        {
            //creating a clone of the deck to shuffle

            if (sender == UI_Load_Btn)
            {
                UI_Starting_Lbx.Items.Clear();
                //displaying into starting deck lbx
                foreach(Card c in deck)
                {
                    UI_Starting_Lbx.Items.Add(CardToString(c));
                }

                //display into Starting Deck lbx
            }
            if (sender == UI_Shuffle_Btn)
            {
                shuffleDeck = (Card[])deck.Clone();
                UI_Shuffled_Lbx.Items.Clear();
                //call ShuffleCards()
                ShuffleCards(shuffleDeck);
                //display into Shuffled Deck lbx
                foreach (Card c in shuffleDeck)
                {
                    UI_Shuffled_Lbx.Items.Add(CardToString(c));
                }

            }
            if (sender == UI_Deal_Btn)
            {
                UI_Hands_Lbx.Items.Clear();
                DealHands(shuffleDeck, playerHands);
                //call DealHands()
                //display into Player Hands lbx
            }
            if(sender == UI_Winner_Btn)
            {
                DetermineWinner();
                //iterate over playerPoints array - identify the greatest number of points
                //display the individual winner within the Winner tbx
            }
        }
        /// <summary>
        /// CreateCard() takes the suit and rank to create a new Card struct object to be returned.
        /// Also assigns points and symbol based on the info provided.
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        /// <returns></returns>
        private Card CreateCard(int suit, int rank)
        {
            Card createdCard = new Card();
            createdCard._suit = (Suits)suit;
            createdCard._rank = rank;
            createdCard._points = suit * rank;
            createdCard._symbol = (Symbol)rank;

            return createdCard;
        }
        /// <summary>
        /// CardToString() converts the info in the Card object into a string format for display in the application
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private string CardToString(Card card)
        {
            return $"Card: {card._suit} {card._symbol} \tPoints: {card._points}";
        }
        /// <summary>
        /// ShuffleCards() uses the Fischer-Yates algorithm to randomly shuffle the cards within the array
        /// that is passed as a parameter
        /// </summary>
        /// <param name="shuffleDeck"></param>
        private void ShuffleCards(Card[] shuffleDeck)
        {
            Shuffling(shuffleDeck);
        }
        /// <summary>
        /// DealHands() takes a shuffledDeck array and distributes each Card object into the 2D array
        /// for the player's hands
        /// </summary>
        /// <param name="shuffledDeck"></param>
        /// <param name="playerHands"></param>
        private void DealHands(Card[] shuffledDeck, Card[,] playerHands)
        {
            //variable for tracking the number of cards distributed
            int cardCount = 0;
            //iterates over all 10 players
            for(int player = 0; player < 10; player++)
            {
                //variable for tracking total points from each player
                int totalPoints = 0;
                UI_Hands_Lbx.Items.Add($"Player {player+1}");
                UI_Hands_Lbx.Items.Add("-----------------------");
                //iterates over 5 times to give each player 5 cards
                for (int hand = 0; hand < 5; hand++)
                {
                    playerHands[player, hand] = shuffledDeck[cardCount];
                    UI_Hands_Lbx.Items.Add(CardToString(playerHands[player, hand]));
                    cardCount++;
                    totalPoints += playerHands[player, hand]._points;
                }
                playerPoints[player] = totalPoints;
                UI_Hands_Lbx.Items.Add($"Total: {totalPoints}");
                UI_Hands_Lbx.Items.Add("");
            }
        }
        /// <summary>
        /// DetermineWinner() iterates over the array of storing the total points for a player
        /// and will display the player with the highest point total
        /// </summary>
        private void DetermineWinner()
        {
            int highestPoints = 0, playerNo = 0;
            for(int player = 0; player < playerPoints.Length; player++)
            {
                if (playerPoints[player] > highestPoints)
                {
                    highestPoints = playerPoints[player];
                    playerNo = player;
                }
            }
            UI_Winner_Tbx.Text = $"Player {playerNo+1} Points: {highestPoints}";
        }
        /// <summary>
        /// Uses the Fisher-Yates algorithm to shuffle a list of integers
        /// </summary>
        /// <param name="list1"></param>
        private void Shuffling(Card[] list1)
        {
            Random rand = new Random();

            int n = list1.Length;
            //Fischer-Yates
            for (int i = (n - 1); i > 0; i--)
            {
                //Generate a random number in the range of 0 to i-1
                int randPosn = rand.Next(i);
                Swap(list1, i, randPosn);
            }
        }
        /// <summary>
        /// Swap() is a helper method for the Fischer-Yates algorithm to swap 
        /// objects between 2 arrays
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="posn1"></param>
        /// <param name="posn2"></param>
        private void Swap(Card[] list1, int posn1, int posn2)
        {
            Card temp = list1[posn1];
            list1[posn1] = list1[posn2];
            list1[posn2] = temp;
        }
    }
}
