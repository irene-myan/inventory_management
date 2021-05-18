// Author: Irene Martirosyan
// File Name: Item.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: A parent class to more specific types of items.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Item
    {
        // The various traits of the item
        protected string title;
        protected double cost;
        protected string genre;
        protected string platform;
        protected int releaseYear;

        // Creates a new item
        public Item(string title, double cost, string genre, string platform, int releaseYear)
        {
            this.title = title;
            this.cost = cost;
            this.genre = genre;
            this.platform = platform;
            this.releaseYear = releaseYear;
        }

        // Retrieves the title, genre and platform of the item
        public string GetTitle()
        {
            return title;
        }
        public string GetGenre()
        {
            return genre;
        }
        public string GetPlatform()
        {
            return platform;
        }

        // Sets the title, cost, genre, platform and release year of the item
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void SetCost(double cost)
        {
            this.cost = cost;
        }
        public void SetGenre(string genre)
        {
            this.genre = genre;
        }
        public void SetPlatform(string platform)
        {
            this.platform = platform;
        }
        public void SetReleaseYear(int releaseYear)
        {
            this.releaseYear = releaseYear;
        }

        // Pre: none
        // Post: Returns the item as a string; can be overriden by more specific classes (Movie,Book,Game) 
        // Description: Returns the item in a displayable format, as a string with each trait seperated by commas
        public virtual string Display()
        {
            // Returns the item as one string
            // The cost and release year are converted into strings
            return title + "," + Convert.ToString(cost) + "," + genre + "," + platform + "," + Convert.ToString(releaseYear);
        }

    }
}
