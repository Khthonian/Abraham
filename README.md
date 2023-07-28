# Abraham - The Lincoln Card Game

**Abraham** is a console-based card game written in C#. The game is inspired by Abraham Lincoln and involves players competing against each other with a deck of cards. The objective is to win hands and have the highest number of hand wins to become the overall winner.

## Getting Started

To run the program, follow these steps:

1. Clone the repository to your local machine.
2. Make sure you have the latest version of the .NET SDK installed on your system.
3. Open the project in your favourite C# development environment (e.g., Visual Studio, Visual Studio Code).
4. Build and run the application.

Upon running the program, you will be greeted with a welcome message from Abraham, the Lincoln Card Game.

## Rules

The game follows these basic rules:

1. Each player is dealt 10 cards.
2. Players play 2 cards from their hand in each round.
3. The player with the highest total value of the played cards wins the hand and plays first in the next round.
4. Card values are as follows: 2, 3, 4, 5, 6, 7, 8, 9, 10, J(11), Q(12), K(13), A(14).
5. In case of a tie, continue to the next hand. The winning player gets both hands.
6. The player with the highest number of hand wins wins the game.
7. If the number of hand wins is the same, draw a random card from the remaining cards, and the highest value wins.
8. If the final hands are of the same value, draw a random card from the remaining cards, and the highest value wins the hand.

## Usage

1. When prompted, press **ENTER** to begin the game with a fresh deck of cards.
2. During the game, follow the instructions provided to play the rounds and determine the winner.
3. To exit the game, input **E** followed by **ENTER**.

## Note

The application does not include any user interface (UI) and is meant to be run in a console environment.

## Support

For any issues or questions regarding the Abraham game application, please open an issue on the GitHub repository.
