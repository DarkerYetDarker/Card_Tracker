using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Tracker
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Colorless
    }

    public class Card
    {
        public int Id;

        public string Name;

        public string Type;

        public string Description;

        public string Stats;

        public List<string> Colors = new List<string>();

        public string Cost;

        #region public Constructors
        /// <summary>
        /// Generic constructor
        /// </summary>
        public Card()
        {
            Id = 0;
            Name = string.Empty;
            Type = string.Empty;
            Description = string.Empty;
            Stats = string.Empty;
            Colors.Add("Colorless");
        }

        /// <summary>
        /// card constructor
        /// </summary>
        /// <param name="id">The id number of the card</param>
        /// <param name="name">The name of the card</param>
        /// <param name="type">The game this card belongs to</param>
        /// <param name="description">A short description of the card or its rules text</param>
        public Card(int id, string name, string type, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Stats = string.Empty;
            Colors.Add("Colorless");
        }

        /// <summary>
        /// card constructor
        /// </summary>
        /// <param name="id">The id number of the card</param>
        /// <param name="name">The name of the card</param>
        /// <param name="type">The game this card belongs to</param>
        /// <param name="description">A short description of the card or its rules text</param>
        /// <param name="stats">The Statline of this card</param>
        public Card(int id, string name, string type, string description, string stats, List<string> color)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Stats = stats;
            Colors = color;
        }
        #endregion


    }
}
