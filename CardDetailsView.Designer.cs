namespace Card_Tracker
{
    partial class CardDetailsView
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
            this.uxConfirmButton = new System.Windows.Forms.Button();
            this.uxCardNameLabel = new System.Windows.Forms.Label();
            this.uxCardStatsLabel = new System.Windows.Forms.Label();
            this.uxCardDescription = new System.Windows.Forms.Label();
            this.uxCardTypeLabel = new System.Windows.Forms.Label();
            this.uxManaCostLabel = new System.Windows.Forms.Label();
            this.uxDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uxConfirmButton
            // 
            this.uxConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxConfirmButton.Location = new System.Drawing.Point(217, 487);
            this.uxConfirmButton.Name = "uxConfirmButton";
            this.uxConfirmButton.Size = new System.Drawing.Size(142, 57);
            this.uxConfirmButton.TabIndex = 0;
            this.uxConfirmButton.Text = "OK";
            this.uxConfirmButton.UseVisualStyleBackColor = true;
            this.uxConfirmButton.Click += new System.EventHandler(this.uxConfirmButton_Click);
            // 
            // uxCardNameLabel
            // 
            this.uxCardNameLabel.AutoSize = true;
            this.uxCardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardNameLabel.Location = new System.Drawing.Point(22, 18);
            this.uxCardNameLabel.Name = "uxCardNameLabel";
            this.uxCardNameLabel.Size = new System.Drawing.Size(191, 39);
            this.uxCardNameLabel.TabIndex = 1;
            this.uxCardNameLabel.Text = "Card Name";
            // 
            // uxCardStatsLabel
            // 
            this.uxCardStatsLabel.AutoSize = true;
            this.uxCardStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardStatsLabel.Location = new System.Drawing.Point(453, 444);
            this.uxCardStatsLabel.Name = "uxCardStatsLabel";
            this.uxCardStatsLabel.Size = new System.Drawing.Size(102, 39);
            this.uxCardStatsLabel.TabIndex = 2;
            this.uxCardStatsLabel.Text = "??/??";
            this.uxCardStatsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxCardDescription
            // 
            this.uxCardDescription.AutoSize = true;
            this.uxCardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxCardDescription.Location = new System.Drawing.Point(22, 142);
            this.uxCardDescription.Name = "uxCardDescription";
            this.uxCardDescription.Size = new System.Drawing.Size(140, 29);
            this.uxCardDescription.TabIndex = 3;
            this.uxCardDescription.Text = "Description";
            // 
            // uxCardTypeLabel
            // 
            this.uxCardTypeLabel.AutoSize = true;
            this.uxCardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardTypeLabel.Location = new System.Drawing.Point(22, 90);
            this.uxCardTypeLabel.Name = "uxCardTypeLabel";
            this.uxCardTypeLabel.Size = new System.Drawing.Size(93, 39);
            this.uxCardTypeLabel.TabIndex = 4;
            this.uxCardTypeLabel.Text = "Type";
            // 
            // uxManaCostLabel
            // 
            this.uxManaCostLabel.AutoSize = true;
            this.uxManaCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxManaCostLabel.Location = new System.Drawing.Point(408, 18);
            this.uxManaCostLabel.Name = "uxManaCostLabel";
            this.uxManaCostLabel.Size = new System.Drawing.Size(87, 39);
            this.uxManaCostLabel.TabIndex = 5;
            this.uxManaCostLabel.Text = "Cost";
            this.uxManaCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxDescriptionTextBox
            // 
            this.uxDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxDescriptionTextBox.Location = new System.Drawing.Point(27, 174);
            this.uxDescriptionTextBox.Name = "uxDescriptionTextBox";
            this.uxDescriptionTextBox.Size = new System.Drawing.Size(528, 267);
            this.uxDescriptionTextBox.TabIndex = 6;
            this.uxDescriptionTextBox.Text = "";
            this.uxDescriptionTextBox.TextChanged += new System.EventHandler(this.uxDescriptionTextBox_TextChanged);
            // 
            // CardDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 567);
            this.Controls.Add(this.uxDescriptionTextBox);
            this.Controls.Add(this.uxManaCostLabel);
            this.Controls.Add(this.uxCardTypeLabel);
            this.Controls.Add(this.uxCardDescription);
            this.Controls.Add(this.uxCardStatsLabel);
            this.Controls.Add(this.uxCardNameLabel);
            this.Controls.Add(this.uxConfirmButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 614);
            this.MinimumSize = new System.Drawing.Size(610, 614);
            this.Name = "CardDetailsView";
            this.Text = "AddEditView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardDetailsView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConfirmButton;
        private System.Windows.Forms.Label uxCardNameLabel;
        private System.Windows.Forms.Label uxCardStatsLabel;
        private System.Windows.Forms.Label uxCardDescription;
        private System.Windows.Forms.Label uxCardTypeLabel;
        private System.Windows.Forms.Label uxManaCostLabel;
        private System.Windows.Forms.RichTextBox uxDescriptionTextBox;
    }
}