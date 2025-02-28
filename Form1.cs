using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string crossToken = "X";
        private string knotToken = "O";
        private string ? playerName;

        private int turnCount = 0;
        private int humanWins = 0;
        private int computerWins = 0;
        private int catWins = 0;

        private bool humanPlayerFirst = true;
        private bool humanPlayerTurn = true;
        private bool gameFinished = false;

        private Random random = new Random();
        List<Button> buttons = [];


        // Adds all TicTacToe buttons to an array for later use.
        public Form1()
        {
            InitializeComponent();
            buttons.Add(num1Button);
            buttons.Add(num2Button);
            buttons.Add(num3Button);
            buttons.Add(num4Button);
            buttons.Add(num5Button);
            buttons.Add(num6Button);
            buttons.Add(num7Button);
            buttons.Add(num8Button);
            buttons.Add(num9Button);
            display.Text = "Please set Player Name";
        }


        // Handles game logic for button presses.
        // Automatically calls the AI move after the player moves
        private void numButton_Click(object sender, EventArgs e)
        {
            // Buttons are set to "-" intially, and on new games. So only unpressed buttons will
            // have "-". Also skip when the game has ended. Cannot start without player name.
            if (((Button) sender).Text != "-" || gameFinished || playerName == null)
            {
                return;
            }

            // Since there are two tokens, we can see if the current turn is odd or not.
            string currentPlayer;
            if (turnCount % 2 == 0)
            {
                currentPlayer = crossToken;
            }
            else
            {
                currentPlayer = knotToken;
            }

            ((Button) sender).Text = currentPlayer;

            if (checkForWinner(currentPlayer))
            {

                // if the game has been won, marked as finished and congratulate the winner
                gameFinished = true;
                if (humanPlayerTurn)
                {
                    humanWins++;
                    display.Text = $"{playerName} WON!!!!";
                    playerWinDisplay.Text = $"{playerName} wins: {humanWins}";
                }
                else
                {
                    computerWins++;
                    display.Text = $"Computer WON!!!!";
                    computerWinDisplay.Text = $"Computer wins: {computerWins}";
                }
                return;
            }

            // There are only 9 available spaces, so if all of them are filled and no winner is found
            // then it is a tied game.
            turnCount++;
            if (turnCount == 9)
            {
                gameFinished = true;
                catWins++;
                display.Text = "CATS GAME";
                tieGamesDisplay.Text = $"Tied games: {catWins}";

                return;
            }

            // If the human player just went, then the computer needs to go.
            if (humanPlayerTurn)
            {
                humanPlayerTurn = false;
                ComputerMove(e);
            }


        }

        // Check for winning rows/columns/crosses seperately for cleaner logic
        private bool checkForWinner(string Player)
        {
            if (checkForWinnerColumn(Player))
            {
                return true;
            }
            if (checkForWinnerRow(Player))
            {
                return true;
            }
            if (checkForWinnerCross(Player))
            {
                return true;
            }
            return false;
        }

        private bool checkForWinnerRow(string Player)
        {
            // Bottom Row
            if (num1Button.Text == Player &&
                num1Button.Text == num2Button.Text &&
                num2Button.Text == num3Button.Text)
            {
                return true;
            }
            // Middle Row
            if (num4Button.Text == Player &&
                num4Button.Text == num5Button.Text &&
                num5Button.Text == num6Button.Text)
            {
                return true;
            }
            // Top Row
            if (num7Button.Text == Player &&
                num7Button.Text == num8Button.Text &&
                num8Button.Text == num9Button.Text)
            {
                return true;
            }
            return false;
        }
        private bool checkForWinnerColumn(string Player)
        {
            // Left Column
            if (num1Button.Text == Player &&
                num1Button.Text == num4Button.Text &&
                num4Button.Text == num7Button.Text)
            {
                return true;
            }
            // Middle Column
            if (num2Button.Text == Player &&
                num2Button.Text == num5Button.Text &&
                num5Button.Text == num8Button.Text)
            {
                return true;
            }
            // Right Column
            if (num3Button.Text == Player &&
                num3Button.Text == num6Button.Text &&
                num6Button.Text == num9Button.Text)
            {
                return true;
            }
            return false;
        }
        private bool checkForWinnerCross(string Player)
        {
            // Bottom Left Cross to top right
            if (num1Button.Text == Player &&
                num1Button.Text == num5Button.Text &&
                num5Button.Text == num9Button.Text)
            {
                return true;
            }
            // Bottom Right to top left
            if (num3Button.Text == Player &&
                num3Button.Text == num5Button.Text &&
                num5Button.Text == num7Button.Text)
            {
                return true;
            }
            return false;
        }

        // Resets the game state. 
        // Sets all buttons to "-"
        // Flips a coin for who goes first
        // If computer is selected, automatically let them move.
        // If restart is hit, it will tell the player if they are X's or O's
        // Prevents player from restarting before name is input.
        private void restartButton_Click(object sender, EventArgs e)
        {
            if (playerName == null)
            {
                return;
            }

            foreach (var button in buttons)
            {
                button.Text = "-";
            }

            turnCount = 0;
            humanPlayerFirst = random.NextDouble() < .5;
            humanPlayerTurn = humanPlayerFirst;
            gameFinished = false;

            display.Text = playerName + " is " + (humanPlayerFirst ? crossToken : knotToken);

            if (humanPlayerFirst == false)
            {
                ComputerMove(e);
            }
        }

        // Make a list of all available squares, and then pick one click.
        private void ComputerMove(EventArgs e)
        {
            List<Button> availableButtons = [];
            foreach (var button in buttons)
            {
                if (button.Text == "-")
                {
                    availableButtons.Add(button);
                }
            }
            numButton_Click(availableButtons[random.Next(availableButtons.Count)], e);
            humanPlayerTurn = true;
        }

        //On launch, user is prompted to click this button to enable name entering.
        // After pressing once, users need to enter a name and then select confirm.
        // After confirming a name, game stats are displayed and the user is welcomed.
        private void setNameButton_Click(object sender, EventArgs e)
        {
            if (playerName is not null)
            {
                return;
            }

            if (((Button) sender).Text == "Set Player Name")
            {
                ((Button) sender).Text = "Confirm";
                display.Text = "Name";
                return;
            }

            if (((Button) sender).Text == "Confirm")
            {
                ((Button) sender).Text = "Have fun!";
                playerName = display.Text;
                display.Text = $"Hello {playerName}!";

                playerWinDisplay.Text = $"{playerName} wins: 0";
                computerWinDisplay.Text = "Computer wins: 0";
                tieGamesDisplay.Text = "Tied games: 0";
                return;
            }
            return;
        }
        

       // Closes the window
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
