namespace PongGame
{
    partial class MainMenuForm
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
            picLogo = new PictureBox();
            btnStart = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = Properties.Resources.pong_game;
            picLogo.InitialImage = Properties.Resources.pong_game;
            picLogo.Location = new Point(338, 69);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 62);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.BackColor = SystemColors.Highlight;
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(180, 216);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(435, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = SystemColors.Highlight;
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(180, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(435, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(picLogo);
            Name = "MainMenuForm";
            Text = "Pong Game";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Button btnStart;
        private Button btnExit;
    }
}
