// Author: Irene Martirosyan
// File Name: Movie.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: A more specific type of item housed in the inventory, movies.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Movie : Item
    {
        // The director of the movie as a string
        string director;

        // The duration of the movie as an integer
        int duration;

        // Creates a new movie item
        public Movie(string title, double cost, string genre, string platform, int releaseYear, string director, int duration) : 
                        base(title, cost, genre, platform, releaseYear)
        {
            this.director = director;
            this.duration = duration;
        }
        
        // Sets the director and duration of the movie item
        public void SetDirector(string director)
        {
            this.director = director;
        }
        public void SetDuration(int duration)
        {
            this.duration = duration;
        }
        
        // Pre: none
        // Post: Returns the item as a string; overrides the item class display method to include its item type, director and duration 
        // Description: Returns the item in a displayable format, as a string with each trait seperated by commas
        public override string Display()
        {
            // Returns the item as one string
            // The cost, duration and release year are converted into strings
            return "Movie," + title + "," + Convert.ToString(cost) + "," + genre + "," + platform + "," + Convert.ToString(releaseYear) + "," + director + "," + Convert.ToString(duration);
        }
    }
}
