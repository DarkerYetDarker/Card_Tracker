using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Tracker
{
    public class Card
    {
        public int id;

        public string name;

        public string type;

        public string description;

        public string stats;

        #region public Constructors
        /// <summary>
        /// Generic constructor
        /// </summary>
        public Card()
        {
            id = 0;
            name = string.Empty;
            type = string.Empty;
            description = string.Empty;
            stats = string.Empty;
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
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
            this.stats = string.Empty;
        }

        /// <summary>
        /// card constructor
        /// </summary>
        /// <param name="id">The id number of the card</param>
        /// <param name="name">The name of the card</param>
        /// <param name="type">The game this card belongs to</param>
        /// <param name="description">A short description of the card or its rules text</param>
        /// <param name="stats">The Statline of this card</param>
        public Card(int id, string name, string type, string description, string stats)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
            this.stats = stats;
        }
        #endregion


    }
}
