// Author: Irene Martirosyan
// File Name: Inventory.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: A class used to add, delete, find, create, and modify the inventory.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryManagement
{
    class Inventory
    { 

        // The file path of the file with the inventory 
        private string filePath;
        
        // The stream reader and writer used to read and save to the file
        private StreamReader inFile;
        private StreamWriter outFile;

        // the list that houses the items kept in the inventory
        private List<Item> items = new List<Item> { };


        // A string array holding the information given in each line; used to create the item of the current line
        string[] currLine;

        // the new item as an array of its traits
        string[] newItemAr;

        // The previously found index of an item
        private int previousIndex;


        // Creates a new instance of the inventory using the file path
        public Inventory(string filePath)
        {
            this.filePath = filePath;
        }

        // Returns the list of items as a list of strings
        public List<string> GetItems()
        {
            return items.ConvertAll<string>(new Converter<Item, string>(ItemToString));
        }

        // Sets the previous index to a new entered one
        public void SetPreviousIndex(int previousIndex)
        {
            this.previousIndex = previousIndex;
        }


        // Pre: The item to be converted into a string
        // Post: A string of the item containing its traits seperated by commas
        // Description: The item is returned as a string to be able to be displayed
        private string ItemToString(Item item)
        {
            // Returns the item as one string
            return item.Display();
        }
        
        // Pre: The title of the item being searched for as a string
        // Post: Returns the item that contains the title
        // Description: A delegate used in the FindItem method that searches through the list of
        // items and returns the one that contains the entered title
        private Predicate<Item> ByTitle(string title)
        {
            return delegate (Item item)
            {
                return item.GetTitle().Contains(title);
            };
        }

        // Pre: The genre of the item being searched for as a string
        // Post: Returns the item that contains the genre
        // Description: A delegate used in the FindItem method that searches through the list of
        // items and returns the one that contains the entered genre
        private Predicate<Item> ByGenre(string genre)
        {
            return delegate (Item item)
            {
                return item.GetGenre().Contains(genre);
            };
        }

        // Pre: The platform of the item being searched for as a string
        // Post: Returns the item that contains the platform
        // Description: A delegate used in the FindItem method that searches through the list of
        // items and returns the one that contains the entered platform
        private Predicate<Item> ByPlatform(string platform)
        {
            return delegate (Item item)
            {
                return item.GetPlatform().Contains(platform);
            };
        }
        

        // Pre: The file path as a string obtained once the inventory was imported
        // Post: Creates the inital items list that is displayed on the form. Returns said list as a list of strings, so it can be displayed
        // on the forms app. If an error occurs, the error message is returned instead.
        // Description: Reads the chosen file and converts each string to a new item that is added to the items list
        public List<string> ReadFile()
        {
            // Try catch block to catch any possible errors
            try
            {
                // Open the file from the found file path
                inFile = File.OpenText(filePath);

                // Read each line from the file and create a new item based on the item type until there are no more lines
                while ((currLine = inFile.ReadLine().Split(',')) != null && (inFile.Peek() > -1))                        
                {
                    // Based on the item type given at the begining of the current line, the coresponding item type is added to the items list
                    if (currLine[0].Equals("Movie"))
                    {
                        items.Add(new Movie(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                            Convert.ToInt32(currLine[5]), currLine[6], Convert.ToInt32(currLine[7])));
                    }
                    else if (currLine[0].Equals("Book"))
                    {
                        items.Add(new Book(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                            Convert.ToInt32(currLine[5]), currLine[6], currLine[7]));
                    }
                    else if (currLine[0].Equals("Game"))
                    {
                        items.Add(new Game(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                            Convert.ToInt32(currLine[5]), currLine[6], Convert.ToDouble(currLine[7])));
                    }
                }

                // This is a repetition of the block above, done to get the very last line of the file
                // Based on the item type given at the begining of the current line, the coresponding item type is added to the items list
                if (currLine[0].Equals("Movie"))
                {
                    items.Add(new Movie(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                        Convert.ToInt32(currLine[5]), currLine[6], Convert.ToInt32(currLine[7])));
                }
                else if (currLine[0].Equals("Book"))
                {
                    items.Add(new Book(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                        Convert.ToInt32(currLine[5]), currLine[6], currLine[7]));
                }
                else if (currLine[0].Equals("Game"))
                {
                    items.Add(new Game(currLine[1], Convert.ToDouble(currLine[2]), currLine[3], currLine[4],
                        Convert.ToInt32(currLine[5]), currLine[6], Convert.ToDouble(currLine[7])));
                }

                // Close the file after reading it
                inFile.Close();

                // Returns the list of items as a list of strings to be used when displaying
                return items.ConvertAll<string>(new Converter<Item, string>(ItemToString));
            }
            catch (FileNotFoundException)
            {
                List<string> fnfMessage = new List<string> { "Error: the file was not found" };
                return fnfMessage;
            }
            catch (FormatException)
            {
                List<string> feMessage = new List<string> { "Error: the file was not inputed in the correct format"};
                return feMessage;
            }
            catch (Exception e)
            {
                List<string> eMessage = new List<string> { "Error: " + e.Message };
                return eMessage;
            }
        }

        // Pre: Enter the item to be added to the list of items
        // Post: Adds the item to the items list
        // Description: Adds the new item to the items list
        public void AddItem(Item newItem)
        {
            // The item is added to the items list
            items.Add(newItem);
        }
        
        // Pre: The item to search for and the trait to search by inputed as strings
        // Post: Returns the index of the found item and changes the previous index to the newfound one.
        // Description: Used as the find and find next button, this method returns the index of the item being searched
        // for, keeping track of its previously returned index as to return the next occurance of the trait.
        public int FindItem(string searchItem, string searchBy)
        {
            // Based on which trait they are searching by, the previous found item index is updated to the next occurance of
            // the search item.
            if (searchBy.Equals("Title"))
            {
                previousIndex = items.FindIndex(previousIndex + 1, ByTitle(searchItem));
            }
            else if (searchBy.Equals("Genre"))
            {
                previousIndex = items.FindIndex(previousIndex + 1, ByGenre(searchItem));
            }
            else if (searchBy.Equals("Platform"))
            {
                previousIndex = items.FindIndex(previousIndex + 1, ByPlatform(searchItem));
            }

            // The previous index is returned, as it is the newest occurance.
            return previousIndex;
        }

        // Pre: The index of the selected item as an integer
        // Post: The selected item is removed from the items list
        // Description: Deletes the selected item from the inventory
        public void DeleteItem(int selectedItem)
        {
            // The selected item is removed from its index in the items list
            items.RemoveAt(selectedItem);
        }

        // Pre: An item is selected from the list, a trait is selected from the drop down list, and the new trait to replace it
        // is typed into the text box. The method takes in the index of the selected item, and the item trait and its replacement
        // as strings.
        // Post: The selected trait of the selected item is modified, or the entire item is changed.
        // Description: Modifies the selected items trait(s).
        public void ModifyItem(int selectedItem, string newItem, string itemTrait)
        {
            // Using the combobox options with a list of each item trait and the option to modify the entire item, the selected
            // items trait is edited.
            if( itemTrait.Equals("Modify Entire Item"))
            {
                // If the entire item is edited, the user input is in an array format.
                // The new item is split into its different traits and kept in a string array.
                newItemAr = newItem.Split(',');

                // Based on the selected items type, a new item of the same type replaces it. 
                if (items[selectedItem] is Movie)
                {
                    items[selectedItem] = new Movie(newItemAr[0], Convert.ToDouble(newItemAr[1]), newItemAr[2], newItemAr[3],
                                Convert.ToInt32(newItemAr[4]), newItemAr[5], Convert.ToInt32(newItemAr[6]));
                }
                else if (items[selectedItem] is Book)
                {
                    items[selectedItem] = new Movie(newItemAr[0], Convert.ToDouble(newItemAr[1]), newItemAr[2], newItemAr[3],
                                Convert.ToInt32(newItemAr[4]), newItemAr[5], Convert.ToInt32(newItemAr[6]));
                }
                else if (items[selectedItem] is Game)
                {
                    items[selectedItem] = new Game(newItemAr[0], Convert.ToDouble(newItemAr[1]), newItemAr[2], newItemAr[3],
                                Convert.ToInt32(newItemAr[4]), newItemAr[5], Convert.ToDouble(newItemAr[6]));
                }
            }
            else if (itemTrait.Equals("Title"))
            {
                items[selectedItem].SetTitle(newItem);
            }
            else if (itemTrait.Equals("Cost"))
            {
                items[selectedItem].SetCost(Convert.ToDouble(newItem));
            }
            else if (itemTrait.Equals("Genre"))
            {
                items[selectedItem].SetGenre(newItem);
            }
            else if (itemTrait.Equals("Platform"))
            {
                items[selectedItem].SetPlatform(newItem);
            }
            else if (itemTrait.Equals("Release Year"))
            {
                items[selectedItem].SetReleaseYear(Convert.ToInt32(newItem));
            }
            else if (items[selectedItem] is Movie)
            {
                if (itemTrait.Equals("Director"))
                {
                    (items[selectedItem] as Movie).SetDirector(newItem);
                }
                else if (itemTrait.Equals("Duration"))
                {
                    (items[selectedItem] as Movie).SetDuration(Convert.ToInt32(newItem));
                }
            }
            else if (items[selectedItem] is Book)
            {
                if (itemTrait.Equals("Author"))
                {
                    (items[selectedItem] as Book).SetAuthor(newItem);
                }
                else if (itemTrait.Equals("Publisher"))
                {
                    (items[selectedItem] as Book).SetPublisher(newItem);
                }
            }
            else if (items[selectedItem] is Game)
            {
                if (itemTrait.Equals("Developer"))
                {
                    (items[selectedItem] as Game).SetDeveloper(newItem);
                }
                else if (itemTrait.Equals("Duration"))
                {
                    (items[selectedItem] as Game).SetIGNRating(Convert.ToDouble(newItem));
                }
            }
        }

        // Pre: The file path for the txt file, recieved when the inventory was imported
        // Post: Rewrites the txt file as the new updated items list
        // Description: Used to save the newly made inventory to the inventory txt file
        public void WriteToFile()
        {
            // Begins rewriting the text file to the file path
            outFile = File.CreateText(filePath);

            // For each item in the items list, a new line is written of each item as a string
            for (int i = 0; i < items.Count; i++)
            {
                outFile.WriteLine(ItemToString(items[i]));
            }

            // The file is closed
            outFile.Close();
        }
    }
}
