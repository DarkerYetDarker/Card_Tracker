using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


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
            /*
            List<string> color = new List<string>();
            Card s = new Card(0, "Test Card", "MTG", "First Strike", "12/12", color);
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.Name);
            s = new Card(0, "Text Card", "MTG", "First Strike", "12/12", color);
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.Name);
            s = new Card(0, "Temp Card", "MTG", "First Strike", "12/12", color);
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.Name);
            s = new Card(0, "Target Card", "MTG", "First Strike", "12/12", color);
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.Name);
            s = new Card(0, "Tron Card", "MTG", "First Strike", "12/12", color);
            DBcards.Add(s);
            uxCardDataBaseList.Items.Add(s.Name);
            */
            OpenReadJsonFile();
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
                    uxCardDataBaseList.Items.Add(item.Name);
                }

                return;
            }

            List<string> hits = new List<string>();

            foreach (Card item in DBcards)
            {
                string temp = item.Name;
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
            uxCardDataBaseList.SelectedItem = null;
            uxPlaysButton.Enabled = false;
        }

        private void uxPredictButton_Click(object sender, EventArgs e)
        {

        }

        private void uxViewCardButton_Click(object sender, EventArgs e)
        {
            //switch to AddEditView
            Card card = new Card();

            if (uxCardSearchTextBox.Text.Equals(""))
            {
                //switch to AddEditView
            }
            else
            {
                card.Name = uxCardSearchTextBox.Text;
            }
        }

        private void uxPlayedCardButton_Click(object sender, EventArgs e)
        {
            //GRAB selected item
            //uxCardDataBaseList.Items
            string name = uxCardDataBaseList.SelectedItem.ToString();
            foreach (Card card in DBcards)
            {
                if(card.Name.Equals(name))
                {
                    PlayedPile.Add(card);
                    break;
                }
            }
            UpdateView();
            uxPlaysButton.Enabled = false;
        }

        /// <summary>
        /// handles when the database cards are selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCardDataBaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (uxCardDataBaseList.SelectedItem != null)
            {
                uxPlaysButton.Enabled = true;
                uxPlayedCards.SelectedItem = null;
            }
            else
            {
                uxPlaysButton.Enabled = false;
            }
        }

        /// <summary>
        /// handles when a selected cards index is changed from either selecting one or deselecting one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPlayedCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxPlayedCards.SelectedItem != null)
            {
                uxCardDataBaseList.SelectedItem = null;
                uxPlaysButton.Enabled = false;
            }
            
        }
        
        /// <summary>
        /// updates the view
        /// </summary>
        private void UpdateView()
        {
            uxCardDataBaseList.Items.Clear();
            uxPlayedCards.Items.Clear();
            foreach (Card card in DBcards)
            {
                uxCardDataBaseList.Items.Add(card.Name);
            }
            foreach (Card card in PlayedPile)
            {
                uxPlayedCards.Items.Add(card.Name);
            }
        }

        public void SaveDatabaseToFile()
        {

        }
        
        /// <summary>
        /// opens one test file
        /// </summary>
        public void OpenReadJsonFile()
        {
            /*
             * EOE has 266 cards
             * 
             * 
             * 
             */
            string filePath = "";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Root root = JsonSerializer.Deserialize<Root>(jsonString, options);

            foreach (var card in root.Data.Cards)
            {
                //THIS isn't perfect but it is the best i could come up with concurrently
                if (DBcards.Count < 266)
                {
                    DBcards.Add(card);
                }
                
            }
            UpdateView();
        }

        
    }
}
