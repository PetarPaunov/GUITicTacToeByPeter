namespace TicTacToe
{
    partial class formTicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(35, 31);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(600, 554);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlayer.Location = new System.Drawing.Point(664, 100);
            this.buttonPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(133, 123);
            this.buttonPlayer.TabIndex = 1;
            this.buttonPlayer.Text = "X";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer.Location = new System.Drawing.Point(664, 65);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(97, 31);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Player";
            // 
            // formTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 617);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.buttonPlayer);
            this.Controls.Add(this.panelButtons);
            this.Name = "formTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelButtons;
        private Button buttonPlayer;
        private Label labelPlayer;
    }
}