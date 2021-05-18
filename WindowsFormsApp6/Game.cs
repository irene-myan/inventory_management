// Author: Irene Martirosyan
// File Name: Game.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: A more specific type of item housed in the inventory, games.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Game : Item
    {
        // The developer of the game as a string
        string developer;

        // The IGN rating of the game as a double 
        double ignRating;

        // Creates a new game item
        public Game(string title, double cost, string genre, string platform, int releaseYear, string developer, double ignRating) :
                        base(title, cost, genre, platform, releaseYear)
        {
            this.developer = developer;
            this.ignRating = ignRating;
        }

        // Sets the developer and IGN rating of the game
        public void SetDeveloper(string developer)
        {
            this.developer = developer;
        }
        public void SetIGNRating(double ignRating)
        {
            this.ignRating = ignRating;
        }

        // Pre: none
        // Post: Returns the item as a string; overrides the item class display method to include its item type, developer and IGN rating 
        // Description: Returns the item in a displayable format, as a string with each trait seperated by commas
        public override string Display()
        {
            // Returns the item as one string
            // The cost, IGN rating and release year are converted into strings
            return "Game," + title + "," + Convert.ToString(cost) + "," + genre + "," + platform + "," + Convert.ToString(releaseYear) + "," + developer + "," + Convert.ToString(ignRating);
        }
    }
}
