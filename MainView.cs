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
        private List<Card> DBcards;

        private List<Card> PlayedPile;

        public MainView()
        {
            InitializeComponent();
            DBcards = new List<Card>();
            PlayedPile = new List<Card>();
            Card s = new Card(0, "Test Card", "MTG", "First Strike", "12/12");
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.name);
            s = new Card(0, "Text Card", "MTG", "First Strike", "12/12");
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.name);
            s = new Card(0, "Temp Card", "MTG", "First Strike", "12/12");
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.name);
            s = new Card(0, "Target Card", "MTG", "First Strike", "12/12");
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.name);
            s = new Card(0, "Tron Card", "MTG", "First Strike", "12/12");
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.name);
        }

        /// <summary>
        /// Searches for a card
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Event Args</param>
        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            string search_text = uxCardSearchTextBox.Text;
            search_text = search_text.ToLower();
            //search_text
            if (search_text.Equals(""))
            {
                //no value entered return back to form
                //display all
                uxCardDataBaseList.Items.Clear();
                foreach (Card item in DBcards)
                {
                    uxCardDataBaseList.Items.Add(item.name);
                }

                return;
            }

            List<string> hits = new List<string>();

            foreach (Card item in DBcards)
            {
                string temp = item.name;
                if (temp.ToLower().Contains(search_text))
                {
                    hits.Add(temp);
                }
            }

            uxCardDataBaseList.Items.Clear();
            foreach (string hit in hits)
            {
                uxCardDataBaseList.Items.Add(hit);
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

        private void uxPredictButton_Click(object sender, EventArgs e)
        {

        }
    }
}
