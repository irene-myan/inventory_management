// Author: Irene Martirosyan
// File Name: Book.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: A more specific type of item housed in the inventory, books.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Book : Item
    {
        // The author and publisher of the book as a string
        string author;
        string publisher;

        // Creates a new book item
        public Book(string title, double cost, string genre, string platform, int releaseYear, string author, string publisher) :
                        base(title, cost, genre, platform, releaseYear)
        {
            this.author = author;
            this.publisher = publisher;
        }
        
        // Sets the author and publisher of the book
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        // Pre: none
        // Post: Returns the item as a string; overrides the item class display method to include its item type, author and publisher 
        // Description: Returns the item in a displayable format, as a string with each trait seperated by commas
        public override string Display()
        {
            // Returns the item as one string
            // The cost and release year are converted into strings
            return "Book," + title + "," + Convert.ToString(cost) + "," + genre + "," + platform + "," + Convert.ToString(releaseYear) + "," + author + "," + publisher;
        }
    }
}
