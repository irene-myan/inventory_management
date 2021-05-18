// Author: Irene Martirosyan
// File Name: InventoryManagement.cs
// Project Name: InventoryManagement
// Creation Date: March 10, 2020
// Modified Date: April 28, 2020
// Description: This program aids in managing large inventories using a forms program.
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

namespace InventoryManagement
{
    public partial class InventoryManagement : Form
    {
        // The file path for the inventory
        string filePath;

        // The inventory that is displayed on the form
        Inventory inventory;

        // The users input as an array of strings, holding the different traits of the item
        string[] userInput;

        public InventoryManagement()
        {
            InitializeComponent();

            // Set the begining index to the first item in the list, which details the function of the drop down list
            cmbxItemType.SelectedIndex = 0;
            cmbxSearchBy.SelectedIndex = 0;
            cmbxItemTrait.SelectedIndex = 0;

            
            try
            {
                // Retrieves the file path of inventory.txt from the program files
                filePath = Application.StartupPath + "/inventory.txt";

                // Creates the new inventory based on the file path
                inventory = new Inventory(filePath);

                // The contents of the file are read and assigned to the list box to be displayed as a string
                listInventory.DataSource = inventory.ReadFile();
                
            }
            catch (FileNotFoundException)
            {
                lblMessage.Text = "The file was not found";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        //Pre: The file path leads to a txt file detailing each items traits,seperated by commas
        //Post: Return the resulting area as a real
        //Description: Calculate the area of a rectangle given a specific length and width
        private void bttnImportInventory_Click(object sender, EventArgs e)
        {
            try
            {
                // Assigns the result of the open file dialogue to a variable
                DialogResult result = ofdFileFinder.ShowDialog();

                // Once the file is selected (and they press ok), its file path is used to create a new inventory
                if (result == DialogResult.OK)
                {
                    filePath = ofdFileFinder.FileName;
                    inventory = new Inventory(filePath);

                    // The contents of the file are read and assigned to the list box to be displayed as a string
                    listInventory.DataSource = inventory.ReadFile();
                }
            }
            catch(FileNotFoundException)
            {
                lblMessage.Text = "The file was not found";
            }
            catch(Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        // Pre: The user inputs the item to be added as a string seperated by commas and chooses the item type from the drop list
        // Post: The item is created and added to the inventory
        // Description: An item inputed by the user is added to the inventory
        private void bttnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                // The user input is split up into the different traits
                userInput = txtUserInput.Text.Split(',');
                
                // Depending on the combobox item type chosen, a different class of item is added. If none is chosen, there is a message
                if (cmbxItemType.Text.Equals("Movie"))
                {
                    Movie newItem = new Movie(userInput[0], Convert.ToDouble(userInput[1]), userInput[2], userInput[3],
                        Convert.ToInt32(userInput[4]), userInput[5], Convert.ToInt32(userInput[6]));

                    inventory.AddItem(newItem);
                }
                else if (cmbxItemType.Text.Equals("Book"))
                {
                    Book newItem = new Book(userInput[0], Convert.ToDouble(userInput[1]), userInput[2], userInput[3],
                        Convert.ToInt32(userInput[4]), userInput[5], userInput[6]);

                    inventory.AddItem(newItem);
                }
                else if (cmbxItemType.Text.Equals("Game"))
                {
                    Game newItem = new Game(userInput[0], Convert.ToDouble(userInput[1]), userInput[2], userInput[3],
                        Convert.ToInt32(userInput[4]), userInput[5], Convert.ToDouble(userInput[6]));

                    inventory.AddItem(newItem);
                }
                else if (cmbxItemType.Text.Equals("Item Type"))
                {
                    lblMessage.Text = "Please select the item type";
                }

                // The new updated inventory is assigned to the list box to be displayed
                listInventory.DataSource = inventory.GetItems();
            }
            catch (FormatException)
            {
                lblMessage.Text = "The input was not in the correct format";
            }
            catch (NullReferenceException)
            {
                lblMessage.Text = "Please add in missing variables";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
        
        // Pre: The user selects an item from the list box
        // Post: The item is deleted from the inventory
        // Description: Deletes an item from the items list
        private void bttnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // The item is removed from the selected index
                inventory.DeleteItem(listInventory.SelectedIndex);

                // The new updated inventory is assigned to the list box to be displayed
                listInventory.DataSource = inventory.GetItems();
            }
            catch(IndexOutOfRangeException)
            {
                lblMessage.Text = "No more items to delete";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }

        }

        // Pre: The user selects which trait(s) to modify, selects the item and inputs the modifications
        // Post: The item is modified
        // Description: Modifies a chosen item
        private void bttnModifyItem_Click(object sender, EventArgs e)
        {
            try
            {
                // The selected item is modified
                inventory.ModifyItem(listInventory.SelectedIndex, txtUserInput.Text, cmbxItemTrait.Text);

                // The inventory list box is updated
                listInventory.DataSource = inventory.GetItems();
            }
            catch (FormatException)
            {
                lblMessage.Text = "The input was not in the correct format";
            }
            catch (NullReferenceException)
            {
                lblMessage.Text = "Please fill in missing variables or select an item.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }

        }

        // Pre: The user selects which trait to search by and what term the trait should contain
        // Post: The first occurance of the item is highlighted
        // Description: Finds the first occurance of an item based on the searched for trait
        private void bttnFindItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets the previous index to -1 to be able to search from the begining of the list
                inventory.SetPreviousIndex(-1);

                // The first occurance is found and selected in the list box
                // If no item is found, nothing is highlighted
                listInventory.SelectedIndex = inventory.FindItem(txtUserInput.Text, cmbxSearchBy.Text);
            }
            catch (FormatException)
            {
                lblMessage.Text = "The input was not in the correct format";
            }
            catch (NullReferenceException)
            {
                lblMessage.Text = "Please fill in missing variables";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        // Pre: The user selects which trait to search by and what term the trait should contain
        // Post: The next occurance of the item is highlighted
        // Description: Finds the next occurance of an item based on the searched for trait
        private void bttnFindNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Highlights the next ovvurance of the item
                // If there is no next occurance, nothing is highlighted
                listInventory.SelectedIndex = inventory.FindItem(txtUserInput.Text, cmbxSearchBy.Text);
            }
            catch (FormatException)
            {
                lblMessage.Text = "The input was not in the correct format";
            }
            catch (NullReferenceException)
            {
                lblMessage.Text = "Please fill in missing variables";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        // Pre: none
        // Post: The txt file containing the inventory list is updated to the modified one
        // Description: Saves the inventory list into the txt file chosen in the begining
        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Writes the new inventory into the file
                inventory.WriteToFile();
            }
            catch (NullReferenceException)
            {
                lblMessage.Text = "No inventory file found.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
