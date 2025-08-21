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
            this.uxCardList = new System.Windows.Forms.ListBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxAddCardButton = new System.Windows.Forms.Button();
            this.uxRemoveButton = new System.Windows.Forms.Button();
            this.uxCardSearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxCardList
            // 
            this.uxCardList.FormattingEnabled = true;
            this.uxCardList.ItemHeight = 16;
            this.uxCardList.Location = new System.Drawing.Point(19, 18);
            this.uxCardList.Name = "uxCardList";
            this.uxCardList.Size = new System.Drawing.Size(761, 356);
            this.uxCardList.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Enabled = false;
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSearchButton.Location = new System.Drawing.Point(666, 399);
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
            this.uxAddCardButton.Location = new System.Drawing.Point(19, 399);
            this.uxAddCardButton.Name = "uxAddCardButton";
            this.uxAddCardButton.Size = new System.Drawing.Size(114, 39);
            this.uxAddCardButton.TabIndex = 2;
            this.uxAddCardButton.Text = "Add Card";
            this.uxAddCardButton.UseVisualStyleBackColor = true;
            this.uxAddCardButton.Click += new System.EventHandler(this.uxAddCardButton_Click);
            // 
            // uxRemoveButton
            // 
            this.uxRemoveButton.Enabled = false;
            this.uxRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxRemoveButton.Location = new System.Drawing.Point(139, 399);
            this.uxRemoveButton.Name = "uxRemoveButton";
            this.uxRemoveButton.Size = new System.Drawing.Size(114, 39);
            this.uxRemoveButton.TabIndex = 3;
            this.uxRemoveButton.Text = "Remove Card";
            this.uxRemoveButton.UseVisualStyleBackColor = true;
            this.uxRemoveButton.Click += new System.EventHandler(this.uxRemoveButton_Click);
            // 
            // uxCardSearchTextBox
            // 
            this.uxCardSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxCardSearchTextBox.Location = new System.Drawing.Point(259, 402);
            this.uxCardSearchTextBox.Name = "uxCardSearchTextBox";
            this.uxCardSearchTextBox.Size = new System.Drawing.Size(401, 36);
            this.uxCardSearchTextBox.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxCardSearchTextBox);
            this.Controls.Add(this.uxRemoveButton);
            this.Controls.Add(this.uxAddCardButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxCardList);
            this.Name = "MainView";
            this.Text = "Main View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxCardList;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxAddCardButton;
        private System.Windows.Forms.Button uxRemoveButton;
        private System.Windows.Forms.TextBox uxCardSearchTextBox;
    }
}

