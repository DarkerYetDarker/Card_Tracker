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
            // 
            // uxCardNameLabel
            // 
            this.uxCardNameLabel.AutoSize = true;
            this.uxCardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardNameLabel.Location = new System.Drawing.Point(189, 28);
            this.uxCardNameLabel.Name = "uxCardNameLabel";
            this.uxCardNameLabel.Size = new System.Drawing.Size(191, 39);
            this.uxCardNameLabel.TabIndex = 1;
            this.uxCardNameLabel.Text = "Card Name";
            // 
            // uxCardStatsLabel
            // 
            this.uxCardStatsLabel.AutoSize = true;
            this.uxCardStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardStatsLabel.Location = new System.Drawing.Point(411, 415);
            this.uxCardStatsLabel.Name = "uxCardStatsLabel";
            this.uxCardStatsLabel.Size = new System.Drawing.Size(102, 39);
            this.uxCardStatsLabel.TabIndex = 2;
            this.uxCardStatsLabel.Text = "??/??";
            // 
            // uxCardDescription
            // 
            this.uxCardDescription.AutoSize = true;
            this.uxCardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardDescription.Location = new System.Drawing.Point(171, 255);
            this.uxCardDescription.Name = "uxCardDescription";
            this.uxCardDescription.Size = new System.Drawing.Size(188, 39);
            this.uxCardDescription.TabIndex = 3;
            this.uxCardDescription.Text = "Description";
            // 
            // uxCardTypeLabel
            // 
            this.uxCardTypeLabel.AutoSize = true;
            this.uxCardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxCardTypeLabel.Location = new System.Drawing.Point(189, 145);
            this.uxCardTypeLabel.Name = "uxCardTypeLabel";
            this.uxCardTypeLabel.Size = new System.Drawing.Size(93, 39);
            this.uxCardTypeLabel.TabIndex = 4;
            this.uxCardTypeLabel.Text = "Type";
            // 
            // CardDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 567);
            this.Controls.Add(this.uxCardTypeLabel);
            this.Controls.Add(this.uxCardDescription);
            this.Controls.Add(this.uxCardStatsLabel);
            this.Controls.Add(this.uxCardNameLabel);
            this.Controls.Add(this.uxConfirmButton);
            this.Name = "CardDetailsView";
            this.Text = "AddEditView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConfirmButton;
        private System.Windows.Forms.Label uxCardNameLabel;
        private System.Windows.Forms.Label uxCardStatsLabel;
        private System.Windows.Forms.Label uxCardDescription;
        private System.Windows.Forms.Label uxCardTypeLabel;
    }
}