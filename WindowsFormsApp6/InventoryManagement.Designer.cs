namespace InventoryManagement
{
    partial class InventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagement));
            this.ofdFileFinder = new System.Windows.Forms.OpenFileDialog();
            this.bttnImportInventory = new System.Windows.Forms.Button();
            this.cmbxItemType = new System.Windows.Forms.ComboBox();
            this.listInventory = new System.Windows.Forms.ListBox();
            this.bttnAddItem = new System.Windows.Forms.Button();
            this.bttnFindItem = new System.Windows.Forms.Button();
            this.bttnModifyItem = new System.Windows.Forms.Button();
            this.bttnDeleteItem = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.cmbxSearchBy = new System.Windows.Forms.ComboBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.cmbxItemTrait = new System.Windows.Forms.ComboBox();
            this.bttnFindNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImgIcon = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdFileFinder
            // 
            this.ofdFileFinder.Filter = "Text files (*.txt)|*.txt";
            // 
            // bttnImportInventory
            // 
            this.bttnImportInventory.Location = new System.Drawing.Point(692, 193);
            this.bttnImportInventory.Name = "bttnImportInventory";
            this.bttnImportInventory.Size = new System.Drawing.Size(121, 21);
            this.bttnImportInventory.TabIndex = 0;
            this.bttnImportInventory.Text = "Import Inventory";
            this.bttnImportInventory.UseVisualStyleBackColor = true;
            this.bttnImportInventory.Click += new System.EventHandler(this.bttnImportInventory_Click);
            // 
            // cmbxItemType
            // 
            this.cmbxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItemType.FormattingEnabled = true;
            this.cmbxItemType.Items.AddRange(new object[] {
            "Item Type",
            "Movie",
            "Book",
            "Game"});
            this.cmbxItemType.Location = new System.Drawing.Point(606, 245);
            this.cmbxItemType.Name = "cmbxItemType";
            this.cmbxItemType.Size = new System.Drawing.Size(150, 21);
            this.cmbxItemType.TabIndex = 1;
            // 
            // listInventory
            // 
            this.listInventory.FormattingEnabled = true;
            this.listInventory.Location = new System.Drawing.Point(8, 9);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(589, 498);
            this.listInventory.TabIndex = 2;
            // 
            // bttnAddItem
            // 
            this.bttnAddItem.Location = new System.Drawing.Point(762, 243);
            this.bttnAddItem.Name = "bttnAddItem";
            this.bttnAddItem.Size = new System.Drawing.Size(143, 23);
            this.bttnAddItem.TabIndex = 3;
            this.bttnAddItem.Text = "Add Item";
            this.bttnAddItem.UseVisualStyleBackColor = true;
            this.bttnAddItem.Click += new System.EventHandler(this.bttnAddItem_Click);
            // 
            // bttnFindItem
            // 
            this.bttnFindItem.Location = new System.Drawing.Point(762, 270);
            this.bttnFindItem.Name = "bttnFindItem";
            this.bttnFindItem.Size = new System.Drawing.Size(143, 23);
            this.bttnFindItem.TabIndex = 4;
            this.bttnFindItem.Text = "Find";
            this.bttnFindItem.UseVisualStyleBackColor = true;
            this.bttnFindItem.Click += new System.EventHandler(this.bttnFindItem_Click);
            // 
            // bttnModifyItem
            // 
            this.bttnModifyItem.Location = new System.Drawing.Point(762, 328);
            this.bttnModifyItem.Name = "bttnModifyItem";
            this.bttnModifyItem.Size = new System.Drawing.Size(143, 23);
            this.bttnModifyItem.TabIndex = 5;
            this.bttnModifyItem.Text = "Modify Item";
            this.bttnModifyItem.UseVisualStyleBackColor = true;
            this.bttnModifyItem.Click += new System.EventHandler(this.bttnModifyItem_Click);
            // 
            // bttnDeleteItem
            // 
            this.bttnDeleteItem.Location = new System.Drawing.Point(762, 357);
            this.bttnDeleteItem.Name = "bttnDeleteItem";
            this.bttnDeleteItem.Size = new System.Drawing.Size(143, 23);
            this.bttnDeleteItem.TabIndex = 6;
            this.bttnDeleteItem.Text = "Delete Item";
            this.bttnDeleteItem.UseVisualStyleBackColor = true;
            this.bttnDeleteItem.Click += new System.EventHandler(this.bttnDeleteItem_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(606, 220);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(299, 20);
            this.txtUserInput.TabIndex = 7;
            // 
            // cmbxSearchBy
            // 
            this.cmbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchBy.FormattingEnabled = true;
            this.cmbxSearchBy.Items.AddRange(new object[] {
            "Search By",
            "Title",
            "Genre",
            "Platform"});
            this.cmbxSearchBy.Location = new System.Drawing.Point(606, 272);
            this.cmbxSearchBy.Name = "cmbxSearchBy";
            this.cmbxSearchBy.Size = new System.Drawing.Size(150, 21);
            this.cmbxSearchBy.TabIndex = 8;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(692, 405);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(121, 23);
            this.bttnSave.TabIndex = 9;
            this.bttnSave.Text = "Save Inventory";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // cmbxItemTrait
            // 
            this.cmbxItemTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItemTrait.FormattingEnabled = true;
            this.cmbxItemTrait.Items.AddRange(new object[] {
            "Item Trait",
            "Title",
            "Cost",
            "Genre",
            "Platform",
            "Release Year",
            "Director",
            "Duration",
            "Author",
            "Publisher",
            "Developer",
            "IGN Rating"});
            this.cmbxItemTrait.Location = new System.Drawing.Point(606, 330);
            this.cmbxItemTrait.Name = "cmbxItemTrait";
            this.cmbxItemTrait.Size = new System.Drawing.Size(150, 21);
            this.cmbxItemTrait.TabIndex = 10;
            // 
            // bttnFindNext
            // 
            this.bttnFindNext.Location = new System.Drawing.Point(762, 299);
            this.bttnFindNext.Name = "bttnFindNext";
            this.bttnFindNext.Size = new System.Drawing.Size(143, 23);
            this.bttnFindNext.TabIndex = 11;
            this.bttnFindNext.Text = "Find Next";
            this.bttnFindNext.UseVisualStyleBackColor = true;
            this.bttnFindNext.Click += new System.EventHandler(this.bttnFindNext_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 92);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory Management";
            // 
            // lblImgIcon
            // 
            this.lblImgIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblImgIcon.Image")));
            this.lblImgIcon.Location = new System.Drawing.Point(772, 9);
            this.lblImgIcon.Name = "lblImgIcon";
            this.lblImgIcon.Size = new System.Drawing.Size(133, 128);
            this.lblImgIcon.TabIndex = 12;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(605, 441);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(302, 66);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = " Import inventory file to begin.\r\nTo add or completely modify an item, enter in t" +
    "he item details seperated by commas.\r\n";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InventoryManagement
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(911, 516);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblImgIcon);
            this.Controls.Add(this.bttnFindNext);
            this.Controls.Add(this.cmbxItemTrait);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.cmbxSearchBy);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.bttnDeleteItem);
            this.Controls.Add(this.bttnModifyItem);
            this.Controls.Add(this.bttnFindItem);
            this.Controls.Add(this.bttnAddItem);
            this.Controls.Add(this.listInventory);
            this.Controls.Add(this.cmbxItemType);
            this.Controls.Add(this.bttnImportInventory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryManagement";
            this.Text = "Inventory Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdFileFinder;
        private System.Windows.Forms.Button bttnImportInventory;
        private System.Windows.Forms.ComboBox cmbxItemType;
        private System.Windows.Forms.ListBox listInventory;
        private System.Windows.Forms.Button bttnAddItem;
        private System.Windows.Forms.Button bttnFindItem;
        private System.Windows.Forms.Button bttnModifyItem;
        private System.Windows.Forms.Button bttnDeleteItem;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.ComboBox cmbxSearchBy;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.ComboBox cmbxItemTrait;
        private System.Windows.Forms.Button bttnFindNext;
        private System.Windows.Forms.Label lblImgIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
    }
}

