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
    public partial class MainView : Form
    {
        private List<Card> cards;

        public MainView()
        {
            InitializeComponent();
            cards = new List<Card>();
            Card s = new Card(0, "Test Card", "MTG", "First Strike", "12/12");
            cards.Add(s);
            uxCardList.Items.Add(s.name);
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            string search_text = uxCardSearchTextBox.Text;
            //search_text
            if (search_text.Equals(""))
            {
                //no value entered return back to form
                return;
            }


            foreach (object item in uxCardList.Items)
            {

            }
        }

        private void uxAddCardButton_Click(object sender, EventArgs e)
        {
            //switch to AddEditView
            Card card = new Card();

            if (uxCardSearchTextBox.Text.Equals(""))
            {
                //switch to AddEditView
            }
            else
            {
                card.name = uxCardSearchTextBox.Text;
            }
        }

        private void uxRemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
