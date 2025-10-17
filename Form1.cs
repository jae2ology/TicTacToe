namespace TicTacToe;

public partial class Form1 : Form
{

    public enum Player
    {
        X, O
    }

    private Player currentPlayer;
    private Random random = new Random();
    private int playerWinCount = 0;
    private int CPUWinCount = 0;

    private List<Button> buttons;
    
    public Form1()
    {
        InitializeComponent();
        RestartGame();
    }

    private void CPUmove(object sender, EventArgs e)
    {
        if (buttons.Count > 0)
        {
            int index = random.Next(buttons.Count); // select a random number between the buttons in the list
            buttons[index].Enabled = false;
            currentPlayer = Player.O; // the CPU can only use Os
            buttons[index].Text = currentPlayer.ToString(); 
            buttons[index].BackColor = Color.DarkOliveGreen;
            buttons.RemoveAt(index); // remove the current button the CPU used
            
            CheckGame(); // check who won
            timer1.Stop(); // stop the timer
        }
    }

    private void PlayerClickButton(object sender, EventArgs e)
    {
        var button = (Button)sender;

        currentPlayer = Player.X;
        button.Text = currentPlayer.ToString();
        button.Enabled = false; // disables the button after the first press
        button.BackColor = Color.IndianRed; // changes the pressed button's color to red
        buttons.Remove(button); // remove the player's chosen button from the list
        CheckGame();
        
        timer1.Start(); // timer for the CPU

    }

    private void RestartGame(object sender, EventArgs e)
    {
        RestartGame();
    }

    private void CheckGame()
    {
        // goal is to check every winning combination between Xs and Os 
        // O as in O not zero (0)......

        if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"|| button1.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
            button9.Text == "X" && button8.Text == "X" && button7.Text == "X" || button3.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
            button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button1.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
            button9.Text == "X" && button5.Text == "X" && button3.Text == "X" || button6.Text == "X" && button5.Text == "X" && button4.Text == "X"
            
            )
        {
            timer1.Stop();
            MessageBox.Show("Player Wins!!!");
            playerWinCount++;
            label2.Text = "Player Wins: " + playerWinCount;
            RestartGame();
        }

        else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"|| button1.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                 button9.Text == "O" && button8.Text == "O" && button7.Text == "O" || button3.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                 button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button1.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
                 button9.Text == "O" && button5.Text == "O" && button3.Text == "O" || button6.Text == "O" && button5.Text == "O" && button4.Text == "O")
        {
            timer1.Stop();
            CPUWinCount++;
            MessageBox.Show("CPU Wins!");
            label3.Text = "CPU Wins: " + CPUWinCount;
            RestartGame();
        }
}

    private void RestartGame()
    {
        buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        foreach (Button b in buttons) // makes sure that the buttons look good every time. (after game is restarted, go back to regular)
        {
            b.Enabled = true;
            b.Text = "?";
            b.BackColor = Color.White;
            
        }
    }
}