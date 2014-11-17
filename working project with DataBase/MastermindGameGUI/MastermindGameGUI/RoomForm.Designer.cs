namespace MastermindGameGUI
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.gbPlayersIngame = new System.Windows.Forms.GroupBox();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpGuess = new System.Windows.Forms.GroupBox();
            this.btnTryGuess = new System.Windows.Forms.Button();
            this.lbIguessTheNumber = new System.Windows.Forms.Label();
            this.lbNumberOfGuessNum = new System.Windows.Forms.Label();
            this.tbGuessInput = new System.Windows.Forms.TextBox();
            this.lbNumberOfGuesses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpFeedback = new System.Windows.Forms.GroupBox();
            this.lbFeedback = new System.Windows.Forms.ListBox();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnJoinNewRoom = new System.Windows.Forms.Button();
            this.btnLeaveRoom = new System.Windows.Forms.Button();
            this.gbPlayersIngame.SuspendLayout();
            this.gpGuess.SuspendLayout();
            this.gpFeedback.SuspendLayout();
            this.gbChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayersIngame
            // 
            this.gbPlayersIngame.Controls.Add(this.lbPlayers);
            this.gbPlayersIngame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPlayersIngame.Location = new System.Drawing.Point(346, 12);
            this.gbPlayersIngame.Name = "gbPlayersIngame";
            this.gbPlayersIngame.Size = new System.Drawing.Size(341, 172);
            this.gbPlayersIngame.TabIndex = 4;
            this.gbPlayersIngame.TabStop = false;
            this.gbPlayersIngame.Text = "Players in-game";
            // 
            // lbPlayers
            // 
            this.lbPlayers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(6, 28);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(323, 116);
            this.lbPlayers.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of guesses";
            // 
            // gpGuess
            // 
            this.gpGuess.Controls.Add(this.btnTryGuess);
            this.gpGuess.Controls.Add(this.lbIguessTheNumber);
            this.gpGuess.Controls.Add(this.lbNumberOfGuessNum);
            this.gpGuess.Controls.Add(this.tbGuessInput);
            this.gpGuess.Controls.Add(this.lbNumberOfGuesses);
            this.gpGuess.Controls.Add(this.label2);
            this.gpGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpGuess.Location = new System.Drawing.Point(12, 12);
            this.gpGuess.Name = "gpGuess";
            this.gpGuess.Size = new System.Drawing.Size(331, 275);
            this.gpGuess.TabIndex = 7;
            this.gpGuess.TabStop = false;
            this.gpGuess.Text = "Guess";
            // 
            // btnTryGuess
            // 
            this.btnTryGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTryGuess.Location = new System.Drawing.Point(124, 231);
            this.btnTryGuess.Name = "btnTryGuess";
            this.btnTryGuess.Size = new System.Drawing.Size(75, 35);
            this.btnTryGuess.TabIndex = 9;
            this.btnTryGuess.Text = "Try";
            this.btnTryGuess.UseVisualStyleBackColor = true;
            this.btnTryGuess.Click += new System.EventHandler(this.btnTryGuess_Click);
            // 
            // lbIguessTheNumber
            // 
            this.lbIguessTheNumber.AutoSize = true;
            this.lbIguessTheNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIguessTheNumber.Location = new System.Drawing.Point(106, 172);
            this.lbIguessTheNumber.Name = "lbIguessTheNumber";
            this.lbIguessTheNumber.Size = new System.Drawing.Size(133, 16);
            this.lbIguessTheNumber.TabIndex = 8;
            this.lbIguessTheNumber.Text = "I guess the number is";
            // 
            // lbNumberOfGuessNum
            // 
            this.lbNumberOfGuessNum.AutoSize = true;
            this.lbNumberOfGuessNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberOfGuessNum.Location = new System.Drawing.Point(153, 154);
            this.lbNumberOfGuessNum.Name = "lbNumberOfGuessNum";
            this.lbNumberOfGuessNum.Size = new System.Drawing.Size(16, 18);
            this.lbNumberOfGuessNum.TabIndex = 7;
            this.lbNumberOfGuessNum.Text = "0";
            // 
            // tbGuessInput
            // 
            this.tbGuessInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGuessInput.Location = new System.Drawing.Point(119, 192);
            this.tbGuessInput.MaxLength = 4;
            this.tbGuessInput.Name = "tbGuessInput";
            this.tbGuessInput.Size = new System.Drawing.Size(85, 29);
            this.tbGuessInput.TabIndex = 6;
            // 
            // lbNumberOfGuesses
            // 
            this.lbNumberOfGuesses.AutoSize = true;
            this.lbNumberOfGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberOfGuesses.Location = new System.Drawing.Point(106, 131);
            this.lbNumberOfGuesses.Name = "lbNumberOfGuesses";
            this.lbNumberOfGuesses.Size = new System.Drawing.Size(142, 18);
            this.lbNumberOfGuesses.TabIndex = 5;
            this.lbNumberOfGuesses.Text = "Number of Guesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 103);
            this.label2.TabIndex = 4;
            this.label2.Text = "? ? ? ?";
            // 
            // gpFeedback
            // 
            this.gpFeedback.Controls.Add(this.lbFeedback);
            this.gpFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpFeedback.Location = new System.Drawing.Point(12, 293);
            this.gpFeedback.Name = "gpFeedback";
            this.gpFeedback.Size = new System.Drawing.Size(331, 242);
            this.gpFeedback.TabIndex = 8;
            this.gpFeedback.TabStop = false;
            this.gpFeedback.Text = "Feedback";
            // 
            // lbFeedback
            // 
            this.lbFeedback.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFeedback.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbFeedback.FormattingEnabled = true;
            this.lbFeedback.ItemHeight = 24;
            this.lbFeedback.Location = new System.Drawing.Point(10, 26);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFeedback.Size = new System.Drawing.Size(311, 196);
            this.lbFeedback.TabIndex = 7;
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.button7);
            this.gbChat.Controls.Add(this.textBox2);
            this.gbChat.Controls.Add(this.lbChat);
            this.gbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChat.Location = new System.Drawing.Point(347, 189);
            this.gbChat.Name = "gbChat";
            this.gbChat.Size = new System.Drawing.Size(341, 194);
            this.gbChat.TabIndex = 5;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Send";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.Location = new System.Drawing.Point(6, 28);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(323, 116);
            this.lbChat.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(352, 391);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(335, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(352, 497);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 38);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnJoinNewRoom
            // 
            this.btnJoinNewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJoinNewRoom.Location = new System.Drawing.Point(464, 497);
            this.btnJoinNewRoom.Name = "btnJoinNewRoom";
            this.btnJoinNewRoom.Size = new System.Drawing.Size(105, 38);
            this.btnJoinNewRoom.TabIndex = 17;
            this.btnJoinNewRoom.Text = "Join new room";
            this.btnJoinNewRoom.UseVisualStyleBackColor = true;
            // 
            // btnLeaveRoom
            // 
            this.btnLeaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeaveRoom.Location = new System.Drawing.Point(597, 497);
            this.btnLeaveRoom.Name = "btnLeaveRoom";
            this.btnLeaveRoom.Size = new System.Drawing.Size(91, 38);
            this.btnLeaveRoom.TabIndex = 18;
            this.btnLeaveRoom.Text = "Leave room";
            this.btnLeaveRoom.UseVisualStyleBackColor = true;
            this.btnLeaveRoom.Click += new System.EventHandler(this.btnLeaveRoom_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 547);
            this.Controls.Add(this.btnLeaveRoom);
            this.Controls.Add(this.btnJoinNewRoom);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.gpFeedback);
            this.Controls.Add(this.gpGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbPlayersIngame);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.gbPlayersIngame.ResumeLayout(false);
            this.gpGuess.ResumeLayout(false);
            this.gpGuess.PerformLayout();
            this.gpFeedback.ResumeLayout(false);
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayersIngame;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpGuess;
        private System.Windows.Forms.Label lbIguessTheNumber;
        private System.Windows.Forms.Label lbNumberOfGuessNum;
        private System.Windows.Forms.TextBox tbGuessInput;
        private System.Windows.Forms.Label lbNumberOfGuesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpFeedback;
        private System.Windows.Forms.ListBox lbFeedback;
        private System.Windows.Forms.Button btnTryGuess;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnJoinNewRoom;
        private System.Windows.Forms.Button btnLeaveRoom;
    }
}