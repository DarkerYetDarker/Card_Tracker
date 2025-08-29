using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Tracker
{
    public partial class CardDetailsView : Form
    {
        private Card _storedCard;
        public CardDetailsView(Card card)
        {
            InitializeComponent();
            _storedCard = card;
            uxCardNameLabel.Text = _storedCard.Name;
            uxCardTypeLabel.Text = _storedCard.Type;
            //uxCardDescription.Text = _storedCard.Description;
            uxDescriptionTextBox.Text = _storedCard.Description;
            uxManaCostLabel.Text = _storedCard.Cost;


            if (!string.IsNullOrEmpty(_storedCard.Power) && !string.IsNullOrEmpty(_storedCard.Power))
            {
                uxCardStatsLabel.Text = _storedCard.Power + "/" + _storedCard.Toughness;
            }
            else if (!string.IsNullOrEmpty(_storedCard.Loyalty))
            {
                uxCardStatsLabel.Text = "{" + _storedCard.Loyalty + "}";
            }
            else
            {
                uxCardStatsLabel.Text = "";
            }
               

            
        }

        private void uxConfirmButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CardDetailsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void uxDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            uxDescriptionTextBox.Text = _storedCard.Description;
        }
    }
}
