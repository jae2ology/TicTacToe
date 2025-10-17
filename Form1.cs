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
    
    public Form1()
    {
        InitializeComponent();
        RestartGame();
    }

    private void CPUmove(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void PlayerClickButton(object sender, EventArgs e)
    {
        
    }

    private void RestartGame(object sender, EventArgs e)
    {
        
    }

    private void CheckGame()
    {
        
    }

    private void RestartGame()
    {
        List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        foreach (Button b in buttons)
        {
            b.Enabled = true;
            b.Text = "?";
            b.BackColor = DefaultBackColor;
            
        }
    }
}