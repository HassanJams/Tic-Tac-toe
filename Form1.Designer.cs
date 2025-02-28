namespace TicTacToe
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            computerWinDisplay = new TextBox();
            tieGamesDisplay = new TextBox();
            playerWinDisplay = new TextBox();
            setNameButton = new Button();
            num3Button = new Button();
            num2Button = new Button();
            num1Button = new Button();
            num6Button = new Button();
            num5Button = new Button();
            num4Button = new Button();
            num9Button = new Button();
            num8Button = new Button();
            num7Button = new Button();
            exitButton = new Button();
            restartButton = new Button();
            display = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(computerWinDisplay, 2, 0);
            tableLayoutPanel1.Controls.Add(tieGamesDisplay, 1, 0);
            tableLayoutPanel1.Controls.Add(playerWinDisplay, 0, 0);
            tableLayoutPanel1.Controls.Add(setNameButton, 1, 2);
            tableLayoutPanel1.Controls.Add(num3Button, 2, 5);
            tableLayoutPanel1.Controls.Add(num2Button, 1, 5);
            tableLayoutPanel1.Controls.Add(num1Button, 0, 5);
            tableLayoutPanel1.Controls.Add(num6Button, 2, 4);
            tableLayoutPanel1.Controls.Add(num5Button, 1, 4);
            tableLayoutPanel1.Controls.Add(num4Button, 0, 4);
            tableLayoutPanel1.Controls.Add(num9Button, 2, 3);
            tableLayoutPanel1.Controls.Add(num8Button, 1, 3);
            tableLayoutPanel1.Controls.Add(num7Button, 0, 3);
            tableLayoutPanel1.Controls.Add(exitButton, 2, 2);
            tableLayoutPanel1.Controls.Add(restartButton, 0, 2);
            tableLayoutPanel1.Controls.Add(display, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(504, 521);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // computerWinDisplay
            // 
            computerWinDisplay.Dock = DockStyle.Fill;
            computerWinDisplay.Font = new Font("Segoe UI", 14F);
            computerWinDisplay.Location = new Point(343, 10);
            computerWinDisplay.Margin = new Padding(8, 10, 8, 3);
            computerWinDisplay.Name = "computerWinDisplay";
            computerWinDisplay.ReadOnly = true;
            computerWinDisplay.Size = new Size(153, 39);
            computerWinDisplay.TabIndex = 19;
            computerWinDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // tieGamesDisplay
            // 
            tieGamesDisplay.Dock = DockStyle.Fill;
            tieGamesDisplay.Font = new Font("Segoe UI", 14F);
            tieGamesDisplay.Location = new Point(175, 10);
            tieGamesDisplay.Margin = new Padding(8, 10, 8, 3);
            tieGamesDisplay.Name = "tieGamesDisplay";
            tieGamesDisplay.ReadOnly = true;
            tieGamesDisplay.Size = new Size(152, 39);
            tieGamesDisplay.TabIndex = 18;
            tieGamesDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // playerWinDisplay
            // 
            playerWinDisplay.Dock = DockStyle.Fill;
            playerWinDisplay.Font = new Font("Segoe UI", 14F);
            playerWinDisplay.Location = new Point(8, 10);
            playerWinDisplay.Margin = new Padding(8, 10, 8, 3);
            playerWinDisplay.Name = "playerWinDisplay";
            playerWinDisplay.ReadOnly = true;
            playerWinDisplay.Size = new Size(151, 39);
            playerWinDisplay.TabIndex = 17;
            playerWinDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // setNameButton
            // 
            setNameButton.Dock = DockStyle.Fill;
            setNameButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            setNameButton.Location = new Point(170, 139);
            setNameButton.Name = "setNameButton";
            setNameButton.Size = new Size(162, 90);
            setNameButton.TabIndex = 16;
            setNameButton.Text = "Set Player Name";
            setNameButton.UseVisualStyleBackColor = true;
            setNameButton.Click += setNameButton_Click;
            // 
            // num3Button
            // 
            num3Button.Dock = DockStyle.Fill;
            num3Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3Button.Location = new Point(338, 427);
            num3Button.Name = "num3Button";
            num3Button.Size = new Size(163, 91);
            num3Button.TabIndex = 15;
            num3Button.Text = "-";
            num3Button.UseVisualStyleBackColor = true;
            num3Button.Click += numButton_Click;
            // 
            // num2Button
            // 
            num2Button.Dock = DockStyle.Fill;
            num2Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2Button.Location = new Point(170, 427);
            num2Button.Name = "num2Button";
            num2Button.Size = new Size(162, 91);
            num2Button.TabIndex = 14;
            num2Button.Text = "-";
            num2Button.UseVisualStyleBackColor = true;
            num2Button.Click += numButton_Click;
            // 
            // num1Button
            // 
            num1Button.Dock = DockStyle.Fill;
            num1Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1Button.Location = new Point(3, 427);
            num1Button.Name = "num1Button";
            num1Button.Size = new Size(161, 91);
            num1Button.TabIndex = 13;
            num1Button.Text = "-";
            num1Button.UseVisualStyleBackColor = true;
            num1Button.Click += numButton_Click;
            // 
            // num6Button
            // 
            num6Button.Dock = DockStyle.Fill;
            num6Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num6Button.Location = new Point(338, 331);
            num6Button.Name = "num6Button";
            num6Button.Size = new Size(163, 90);
            num6Button.TabIndex = 11;
            num6Button.Text = "-";
            num6Button.UseVisualStyleBackColor = true;
            num6Button.Click += numButton_Click;
            // 
            // num5Button
            // 
            num5Button.Dock = DockStyle.Fill;
            num5Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num5Button.Location = new Point(170, 331);
            num5Button.Name = "num5Button";
            num5Button.Size = new Size(162, 90);
            num5Button.TabIndex = 10;
            num5Button.Text = "-";
            num5Button.UseVisualStyleBackColor = true;
            num5Button.Click += numButton_Click;
            // 
            // num4Button
            // 
            num4Button.Dock = DockStyle.Fill;
            num4Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num4Button.Location = new Point(3, 331);
            num4Button.Name = "num4Button";
            num4Button.Size = new Size(161, 90);
            num4Button.TabIndex = 9;
            num4Button.Text = "-";
            num4Button.UseVisualStyleBackColor = true;
            num4Button.Click += numButton_Click;
            // 
            // num9Button
            // 
            num9Button.Dock = DockStyle.Fill;
            num9Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num9Button.Location = new Point(338, 235);
            num9Button.Name = "num9Button";
            num9Button.Size = new Size(163, 90);
            num9Button.TabIndex = 7;
            num9Button.Text = "-";
            num9Button.UseVisualStyleBackColor = true;
            num9Button.Click += numButton_Click;
            // 
            // num8Button
            // 
            num8Button.Dock = DockStyle.Fill;
            num8Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num8Button.Location = new Point(170, 235);
            num8Button.Name = "num8Button";
            num8Button.Size = new Size(162, 90);
            num8Button.TabIndex = 6;
            num8Button.Text = "-";
            num8Button.UseVisualStyleBackColor = true;
            num8Button.Click += numButton_Click;
            // 
            // num7Button
            // 
            num7Button.Dock = DockStyle.Fill;
            num7Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num7Button.Location = new Point(3, 235);
            num7Button.Name = "num7Button";
            num7Button.Size = new Size(161, 90);
            num7Button.TabIndex = 5;
            num7Button.Text = "-";
            num7Button.UseVisualStyleBackColor = true;
            num7Button.Click += numButton_Click;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Fill;
            exitButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            exitButton.Location = new Point(338, 139);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(163, 90);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restartButton
            // 
            restartButton.Dock = DockStyle.Fill;
            restartButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restartButton.Location = new Point(3, 139);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(161, 90);
            restartButton.TabIndex = 0;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // display
            // 
            tableLayoutPanel1.SetColumnSpan(display, 3);
            display.Dock = DockStyle.Fill;
            display.Font = new Font("Segoe UI", 28F);
            display.Location = new Point(10, 50);
            display.Margin = new Padding(10);
            display.Name = "display";
            display.Size = new Size(484, 70);
            display.TabIndex = 1;
            display.Text = "0";
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 521);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(520, 560);
            Name = "Form1";
            ShowIcon = false;
            Text = "TINFO-200 TicTacToe";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button restartButton;
        private TextBox display;
        private Button num3Button;
        private Button num2Button;
        private Button num1Button;
        private Button num6Button;
        private Button num5Button;
        private Button num4Button;
        private Button num9Button;
        private Button num8Button;
        private Button num7Button;
        private Button exitButton;
        private Button setNameButton;
        private TextBox computerWinDisplay;
        private TextBox tieGamesDisplay;
        private TextBox playerWinDisplay;
    }
}
