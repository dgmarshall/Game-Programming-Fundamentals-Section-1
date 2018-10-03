using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////
            //
            //  SESSION 2 : GUESS THE MARBLES
            //
            ////////////////////////////////////////////

            //Random rng = new Random();
            //int numberOfMarbles = rng.Next(1, 101);
            //int computerGuess = rng.Next(1, 101);
            //Console.WriteLine("Guess the number of marbles, from 1 to 100.");
            //int playerGuess = Convert.ToInt32(Console.ReadLine());
            //int computerDifference = Math.Abs(computerGuess - numberOfMarbles);
            //int playerDifference = Math.Abs(playerGuess - numberOfMarbles);
            //Console.WriteLine("Computer guessed " + computerGuess);
            //Console.WriteLine("Actual number of marbles: " + numberOfMarbles);
            //if (computerDifference > playerDifference)
            //    Console.WriteLine("You win!");
            //else if (computerDifference < playerDifference)
            //    Console.WriteLine("You lose!");
            //else
            //    Console.WriteLine("It's a draw.");
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 2 : ODDS AND EVENS
            //
            ////////////////////////////////////////////

            //Console.WriteLine("Choose 1 or 2 fingers.");
            //int fingers = Convert.ToInt32(Console.ReadLine());
            //Random rng = new Random();
            //fingers += rng.Next(1, 3);
            //bool even = false;
            //if (fingers % 2 == 0) even = true;
            //Console.WriteLine("Select ODD or EVEN?");
            //string choice = Console.ReadLine();
            //if ((choice == "ODD" && !even)
            //    || (choice == "EVEN" && even))
            //    Console.WriteLine("You win!");
            //else
            //    Console.WriteLine("You lose");
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 2 EXERCISE: MORRA
            //
            ////////////////////////////////////////////

            //Console.WriteLine("Choose a number of fingers, 1 to 5.");
            //int fingers = Convert.ToInt32(Console.ReadLine());
            //Random rng = new Random();
            //fingers += rng.Next(1, 5);  // computer chooses

            //Console.WriteLine("Now guess how many fingers in total:");
            //int guess = Convert.ToInt32(Console.ReadLine());
            //int computerGuess = rng.Next(2, 10);
            //Console.WriteLine("Computer guessed:" + computerGuess);
            //Console.WriteLine("Total fingers: " + fingers);
            //if (guess == fingers)
            //{
            //    if (computerGuess != fingers)
            //        Console.WriteLine("You guess correctly, you win!");
            //    else
            //        Console.WriteLine("You both guessed correctly, its a draw!");
            //}
            //else if (computerGuess == fingers)
            //    Console.WriteLine("The computer guess correctly, you lose.");
            //else
            //    Console.WriteLine("Nobody guessed the number, its a draw.");
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 2 EXERCISE: ROCK PAPER SCISSORS
            //
            ////////////////////////////////////////////

            //Console.WriteLine("Welcome to ROCK PAPER SCISSORS ULTIMATE EXTREME ALPHA DELUXE (Early access)");
            //Console.WriteLine("Choose '1' for Rock, '2' for Paper, or '3' for Scissors");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Random rng = new Random();
            //int computerChoice = rng.Next(1, 4);
            //if (choice == computerChoice)
            //{
            //    Console.WriteLine("Computer chose that too!  It's a draw. YAWN.");
            //}
            //else if (choice == 1)
            //{
            //    if (computerChoice == 2)
            //        Console.WriteLine("Computer chose paper.  YOU LOSE.");
            //    else
            //        Console.WriteLine("Computer chose scissors.  A WINNER IS YOU.");
            //}
            //else if (choice == 2)
            //{
            //    if (computerChoice == 3)
            //        Console.WriteLine("Computer chose scissors.  YOU LOSE.");
            //    else
            //        Console.WriteLine("Computer chose rock.  A WINNER IS YOU.");
            //}
            //else
            //{
            //    if (computerChoice == 1)
            //        Console.WriteLine("Computer chose rock.  YOU LOSE.");
            //    else
            //        Console.WriteLine("Computer chose paper.  A WINNER IS YOU.");
            //}



            ////////////////////////////////////////////
            //
            //  SESSION 3 EXERCISE: FIBONACCI SEQUENCE
            //
            ////////////////////////////////////////////

            //int currentNum = 1;
            //int previousNum = 1;
            //int nextNum;

            //Console.WriteLine(previousNum);
            //Console.WriteLine(currentNum);

            //for(int i=0; i<18; i++)
            //{
            //    nextNum = currentNum + previousNum;
            //    Console.WriteLine(nextNum);
            //    previousNum = currentNum;
            //    currentNum = nextNum;
            //}
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 3 EXERCISE: FIZZBUZZ
            //
            ////////////////////////////////////////////

            //for(int i=1; i<101; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        if(i % 5 == 0)
            //            Console.Write("FizzBuz\t");
            //        else
            //            Console.Write("Fizz\t");
            //    }
            //    else if (i % 5 == 0)
            //        Console.Write("Buzz\t");
            //    else
            //        Console.Write(i + "\t");
            //}
            //Console.ReadKey();



            ////////////////////////////////////////////
            //
            //  SESSION 3 EXERCISE: JOTTO (WITHOUT ARRAYS)
            //
            ////////////////////////////////////////////

            //bool WonGame = false;
            //char a1 = 'f', a2 = 'u', a3 = 'n', a4 = 'n', a5 = 'y';

            //do
            //{
            //    Console.WriteLine("Enter your guess:");
            //    int correctLetters = 0;

            //    for (int letter = 0; letter < 5; letter++)
            //    {
            //        char key = Console.ReadKey().KeyChar;
            //        switch (letter)
            //        {
            //            case 0: if (key == a1) correctLetters++;
            //                break;
            //            case 1: if (key == a2) correctLetters++;
            //                break;
            //            case 2: if (key == a3) correctLetters++;
            //                break;
            //            case 3: if (key == a4) correctLetters++;
            //                break;
            //            case 4: if (key == a5) correctLetters++;
            //                break;
            //        }
            //    }

            //    Console.WriteLine("\nYou got " + correctLetters +
            //        " letters right.\n");
            //    if (correctLetters == 5)
            //    {
            //        WonGame = true;
            //    }
            //} while (WonGame == false);

            //Console.WriteLine("Conglaturation! A winner is you!");
            //Console.ReadKey();




            ////////////////////////////////////////////
            //
            //  SESSION 3 EXERCISE: BLACKJACK
            //
            ////////////////////////////////////////////

            //Console.WriteLine("Simplified Blackjack.");
            //Random rng = new Random();
            //int hand = rng.Next(2, 11); // deal one card
            //int nextCard = rng.Next(2, 11); // deal next card
            //if (nextCard == 11 && (hand + nextCard) > 21)
            //    hand = hand + 1;    // ace treated as a one.
            //else
            //    hand = hand + nextCard;

            //string input;
            //do
            //{
            //    Console.WriteLine("Your hand is worth: " + hand);
            //    Console.WriteLine("(D)eal or (S)tick?");
            //    input = Console.ReadLine();
            //    if (input == "D")
            //    {
            //        nextCard = rng.Next(2, 11); // deal next card
            //        if (nextCard == 11 && (hand + nextCard) > 21)
            //            hand = hand + 1;    // ace treated as a one.
            //        else
            //            hand = hand + nextCard;
            //    }
            //    if (hand > 21)
            //        Console.WriteLine("You went bust!");
            //} while (hand <= 21 && input != "S");

            //if (hand == 21)
            //    Console.WriteLine("You got 21! You win.");
            //else
            //    Console.WriteLine("Your final hand was worth: " + hand);
            //Console.ReadKey();


            ////////////////////////////////////////////
            //
            //  SESSION 4: PLAY YOUR CARDS RIGHT
            //
            ////////////////////////////////////////////

            //Random rng = new Random();
            //int[] cards = new int[5];
            //for (int i = 0; i < cards.Length; i++)
            //    cards[i] = rng.Next(1, 14); // choose ace to 10, J, Q, or K
            //int currentCard = 0;
            //char choice;
            //do
            //{
            //    Console.WriteLine("You are on card number " + (currentCard + 1));
            //    Console.WriteLine("That card has the value " + cards[currentCard]);
            //    Console.WriteLine("(H)igher, (L)ower or (Q)uit?");
            //    string input = Console.ReadLine();
            //    choice = input[0]; // take first letter of input
            //    currentCard++;
            //    Console.WriteLine("The next card is a " + cards[currentCard]);
            //    if (choice == 'H' && cards[currentCard] <= cards[currentCard - 1])
            //    {
            //        Console.WriteLine("That card is not higher, you lose.");
            //        choice = 'Q'; // time to quit
            //    }
            //    else if (choice == 'L' && cards[currentCard] >= cards[currentCard - 1])
            //    {
            //        Console.WriteLine("That card is not lower, you lose.");
            //        choice = 'Q'; // time to quit
            //    }
            //    if (currentCard + 1 >= cards.Length) // is there a next card?
            //    {
            //        Console.WriteLine("You have reached the end!");
            //        choice = 'Q'; // time to quit
            //    }
            //} while (choice != 'Q');
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 4 EXERCISE: LEADERBOARD
            //
            ////////////////////////////////////////////

            //int[] scores = { 0, 1, 4, 0, 3, 2, 1, 0, 7, 2, 5, 2, 1, 0, 5, 3 };
            //int currentHighest = -1;
            //int topPlayer = -1;

            //for(int currentPlayer=0; currentPlayer<16; currentPlayer++)
            //{
            //    if(scores[currentPlayer] > currentHighest)
            //    {
            //        currentHighest = scores[currentPlayer];
            //        topPlayer = currentPlayer;
            //    }
            //}
            //Console.WriteLine("Top player is player: " + (topPlayer+1));
            //Console.WriteLine("With a score of " + currentHighest);
            //Console.ReadKey();

            ////////////////////////////////////////////
            //
            //  SESSION 4 EXERCISE: PVP MATCHMAKING
            //
            ////////////////////////////////////////////

            //int[] ratings = { 500, 750, 850, 1200, 900, 650, 300, 1050 };
            //int total = 0;
            //for (int player = 0; player < ratings.Length; player++)
            //{
            //    total += ratings[player];
            //}
            //int average = total / ratings.Length;
            //Console.WriteLine("The average PVP rating is: " + average);
            //Console.ReadKey();


            ////////////////////////////////////////////
            //
            //  BONUS STAGE: ROGUELIKE MOVING CHARACTER CODE
            //
            ////////////////////////////////////////////
            //int Xcoord = 3;

            //do
            //{
            //    char inputKey = Console.ReadKey(true).KeyChar;
            //    if (inputKey == 'd')
            //        Xcoord++;
            //    if (inputKey == 'a')
            //        Xcoord--;
            //    Console.Clear();

            //    for (int i = 0; i < Xcoord; i++)
            //    {
            //        Console.Write(' ');   // loop body
            //    }
            //    Console.Write('@');
            //} while (true);
            //Console.ReadKey();

        }
    }
}