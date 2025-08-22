namespace Card_Tracker
{
    partial class MainView
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
            this.uxCardDataBaseList = new System.Windows.Forms.ListBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxAddCardButton = new System.Windows.Forms.Button();
            this.uxPlaysButton = new System.Windows.Forms.Button();
            this.uxCardSearchTextBox = new System.Windows.Forms.TextBox();
            this.uxPredictButton = new System.Windows.Forms.Button();
            this.uxPlayedCards = new System.Windows.Forms.ListBox();
            this.uxPlayedCardsLabel = new System.Windows.Forms.Label();
            this.uxCardDatabaseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxCardDataBaseList
            // 
            this.uxCardDataBaseList.FormattingEnabled = true;
            this.uxCardDataBaseList.ItemHeight = 16;
            this.uxCardDataBaseList.Location = new System.Drawing.Point(21, 50);
            this.uxCardDataBaseList.Name = "uxCardDataBaseList";
            this.uxCardDataBaseList.Size = new System.Drawing.Size(403, 468);
            this.uxCardDataBaseList.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSearchButton.Location = new System.Drawing.Point(659, 530);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(114, 39);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxAddCardButton
            // 
            this.uxAddCardButton.Enabled = false;
            this.uxAddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAddCardButton.Location = new System.Drawing.Point(12, 534);
            this.uxAddCardButton.Name = "uxAddCardButton";
            this.uxAddCardButton.Size = new System.Drawing.Size(114, 39);
            this.uxAddCardButton.TabIndex = 2;
            this.uxAddCardButton.Text = "Add Card";
            this.uxAddCardButton.UseVisualStyleBackColor = true;
            this.uxAddCardButton.Click += new System.EventHandler(this.uxAddCardButton_Click);
            // 
            // uxPlaysButton
            // 
            this.uxPlaysButton.Enabled = false;
            this.uxPlaysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxPlaysButton.Location = new System.Drawing.Point(132, 534);
            this.uxPlaysButton.Name = "uxPlaysButton";
            this.uxPlaysButton.Size = new System.Drawing.Size(114, 39);
            this.uxPlaysButton.TabIndex = 3;
            this.uxPlaysButton.Text = "Played Card";
            this.uxPlaysButton.UseVisualStyleBackColor = true;
            this.uxPlaysButton.Click += new System.EventHandler(this.uxRemoveButton_Click);
            // 
            // uxCardSearchTextBox
            // 
            this.uxCardSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxCardSearchTextBox.Location = new System.Drawing.Point(252, 533);
            this.uxCardSearchTextBox.Name = "uxCardSearchTextBox";
            this.uxCardSearchTextBox.Size = new System.Drawing.Size(401, 36);
            this.uxCardSearchTextBox.TabIndex = 4;
            // 
            // uxPredictButton
            // 
            this.uxPredictButton.Enabled = false;
            this.uxPredictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxPredictButton.Location = new System.Drawing.Point(779, 530);
            this.uxPredictButton.Name = "uxPredictButton";
            this.uxPredictButton.Size = new System.Drawing.Size(114, 39);
            this.uxPredictButton.TabIndex = 5;
            this.uxPredictButton.Text = "Predict";
            this.uxPredictButton.UseVisualStyleBackColor = true;
            this.uxPredictButton.Click += new System.EventHandler(this.uxPredictButton_Click);
            // 
            // uxPlayedCards
            // 
            this.uxPlayedCards.FormattingEnabled = true;
            this.uxPlayedCards.ItemHeight = 16;
            this.uxPlayedCards.Location = new System.Drawing.Point(447, 50);
            this.uxPlayedCards.Name = "uxPlayedCards";
            this.uxPlayedCards.Size = new System.Drawing.Size(437, 468);
            this.uxPlayedCards.TabIndex = 6;
            // 
            // uxPlayedCardsLabel
            // 
            this.uxPlayedCardsLabel.AutoSize = true;
            this.uxPlayedCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxPlayedCardsLabel.Location = new System.Drawing.Point(588, 9);
            this.uxPlayedCardsLabel.Name = "uxPlayedCardsLabel";
            this.uxPlayedCardsLabel.Size = new System.Drawing.Size(165, 29);
            this.uxPlayedCardsLabel.TabIndex = 7;
            this.uxPlayedCardsLabel.Text = "Played Cards";
            // 
            // uxCardDatabaseLabel
            // 
            this.uxCardDatabaseLabel.AutoSize = true;
            this.uxCardDatabaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxCardDatabaseLabel.Location = new System.Drawing.Point(110, 9);
            this.uxCardDatabaseLabel.Name = "uxCardDatabaseLabel";
            this.uxCardDatabaseLabel.Size = new System.Drawing.Size(182, 29);
            this.uxCardDatabaseLabel.TabIndex = 8;
            this.uxCardDatabaseLabel.Text = "Card Database";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 583);
            this.Controls.Add(this.uxCardDatabaseLabel);
            this.Controls.Add(this.uxPlayedCardsLabel);
            this.Controls.Add(this.uxPlayedCards);
            this.Controls.Add(this.uxPredictButton);
            this.Controls.Add(this.uxCardSearchTextBox);
            this.Controls.Add(this.uxPlaysButton);
            this.Controls.Add(this.uxAddCardButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxCardDataBaseList);
            this.Name = "MainView";
            this.Text = "Main View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxCardDataBaseList;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxAddCardButton;
        private System.Windows.Forms.Button uxPlaysButton;
        private System.Windows.Forms.TextBox uxCardSearchTextBox;
        private System.Windows.Forms.Button uxPredictButton;
        private System.Windows.Forms.ListBox uxPlayedCards;
        private System.Windows.Forms.Label uxPlayedCardsLabel;
        private System.Windows.Forms.Label uxCardDatabaseLabel;
    }
}

