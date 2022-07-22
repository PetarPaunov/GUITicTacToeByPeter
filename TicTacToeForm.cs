namespace TicTacToe
{
    public partial class formTicTacToe : Form
    {
        public formTicTacToe()
        {
            InitializeComponent();
            GenerateButtons();
        }

        Button[,] buttons = new Button[3, 3];

        private void GenerateButtons()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    buttons[row, col] = new Button();
                    buttons[row, col].Size = new Size(175, 175);
                    buttons[row, col].Location = new Point(row * 175, col * 175);
                    buttons[row, col].FlatStyle = FlatStyle.Flat;
                    buttons[row, col].Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    // Define button click event
                    buttons[row, col].Click += new EventHandler(OnButtonClick);

                    // Add button to the panel

                    this.panelButtons.Controls.Add(buttons[row, col]);
                }
            }
        }
        void OnButtonClick(object sender, EventArgs e)
        {
            // Load the clicked button into a local variable
            Button button = sender as Button;

            // Don't do anything if the block is already marked
            if (button.Text != "")
            {
                return;
            }

            // Mark the block with current players icon
            button.Text = this.buttonPlayer.Text;

            TogglePlayer();
        }

        private void TogglePlayer()
        {
            CheckIfGameEnds();

            if (this.buttonPlayer.Text == "X")
            {
                this.buttonPlayer.Text = "O";
            }
            else
            {
                this.buttonPlayer.Text = "X";
            }
        }

        private void CheckIfGameEnds()
        {
            List<Button> winnerButtons = new List<Button>();
            // vertically
            CheckVerticalForWin(winnerButtons);

            //horizontally
            CheckHorizontalForWin(winnerButtons);

            //diagonally 1 (top-left to bottom-right)
            CheckFirstDiagonalForWin(winnerButtons);

            //diagonally 2 (bottom-left to top-right)
            CheckSecondDiagonalForWin(winnerButtons);

            // check if all the blocks are marked
            CheckForDraw();
        }

        private void CheckVerticalForWin(List<Button> winnerButtons)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttons[row, col].Text != this.buttonPlayer.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[row, col]);
                    if (col == 2)
                    {

                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
        }

        private void CheckHorizontalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttons[col, row].Text != this.buttonPlayer.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[col, row]);
                    if (col == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }
        }

        private void CheckFirstDiagonalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();
            for (int row = 0, col = 0; row < 3; row++, col++)
            {
                if (buttons[row, col].Text != this.buttonPlayer.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[row, col]);
                if (col == 2)
                {
                    ShowWinner(winnerButtons);
                    return; 
                }
            }
        }

        private void CheckSecondDiagonalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();
            for (int row = 2, col = 0; col < 3; row--, col++)
            {
                if (buttons[row, col].Text != this.buttonPlayer.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[row, col]);
                if (col == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }
        }

        private void CheckForDraw()
        {
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }

            MessageBox.Show("Game Draw");
            Application.Restart();
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            // color all the winner blocks
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.LightGreen;
            }

            MessageBox.Show("Player " + this.buttonPlayer.Text + " wins");
            Application.Restart();
        }
    }
}