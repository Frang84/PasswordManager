namespace WinFormsPasswordManager.Views
{
    partial class EntryView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabPageEntryDetails = new TabPage();
            buttonCancelEntryDetails = new Button();
            buttonGeneratePassword = new Button();
            buttonSave = new Button();
            textBoxNotes = new TextBox();
            labelNotes = new Label();
            textBoxUrl = new TextBox();
            labelUrl = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            EntryList = new TabPage();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            SearchButton = new Button();
            textBoxSearchEntry = new TextBox();
            dataGridViewEntries = new DataGridView();
            tabPageEntriesOperations = new TabControl();
            tabPagePasswordGenerator = new TabPage();
            buttonCancelPasswordGenerator = new Button();
            labelBigLetters = new Label();
            buttonGenerate = new Button();
            textBoxLength = new TextBox();
            labelLength = new Label();
            checkBoxSpecialCharacters = new CheckBox();
            checkBoxSpecialBrackets = new CheckBox();
            checkBoxNumbers = new CheckBox();
            checkBoxSmallLetters = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            tabPageEntryDetails.SuspendLayout();
            EntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntries).BeginInit();
            tabPageEntriesOperations.SuspendLayout();
            tabPagePasswordGenerator.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageEntryDetails
            // 
            tabPageEntryDetails.Controls.Add(buttonCancelEntryDetails);
            tabPageEntryDetails.Controls.Add(buttonGeneratePassword);
            tabPageEntryDetails.Controls.Add(buttonSave);
            tabPageEntryDetails.Controls.Add(textBoxNotes);
            tabPageEntryDetails.Controls.Add(labelNotes);
            tabPageEntryDetails.Controls.Add(textBoxUrl);
            tabPageEntryDetails.Controls.Add(labelUrl);
            tabPageEntryDetails.Controls.Add(textBoxName);
            tabPageEntryDetails.Controls.Add(labelName);
            tabPageEntryDetails.Controls.Add(textBoxPassword);
            tabPageEntryDetails.Controls.Add(labelPassword);
            tabPageEntryDetails.Controls.Add(textBoxTitle);
            tabPageEntryDetails.Controls.Add(labelTitle);
            tabPageEntryDetails.Location = new Point(4, 29);
            tabPageEntryDetails.Name = "tabPageEntryDetails";
            tabPageEntryDetails.Padding = new Padding(3);
            tabPageEntryDetails.Size = new Size(1014, 450);
            tabPageEntryDetails.TabIndex = 1;
            tabPageEntryDetails.Text = "Entry Details";
            tabPageEntryDetails.UseVisualStyleBackColor = true;
            // 
            // buttonCancelEntryDetails
            // 
            buttonCancelEntryDetails.Location = new Point(157, 413);
            buttonCancelEntryDetails.Name = "buttonCancelEntryDetails";
            buttonCancelEntryDetails.Size = new Size(148, 29);
            buttonCancelEntryDetails.TabIndex = 12;
            buttonCancelEntryDetails.Text = "Cancel";
            buttonCancelEntryDetails.UseVisualStyleBackColor = true;
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(855, 87);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(153, 29);
            buttonGeneratePassword.TabIndex = 11;
            buttonGeneratePassword.Text = "Password Generator";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(3, 413);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(148, 29);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(10, 193);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(998, 214);
            textBoxNotes.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(12, 170);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(51, 20);
            labelNotes.TabIndex = 8;
            labelNotes.Text = "Notes:";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(10, 140);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(998, 27);
            textBoxUrl.TabIndex = 7;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(10, 117);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(38, 20);
            labelUrl.TabIndex = 6;
            labelUrl.Text = "URL:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(500, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(508, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(500, 11);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(10, 87);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(839, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(10, 64);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(77, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password: ";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(10, 34);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(484, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(10, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // EntryList
            // 
            EntryList.Controls.Add(buttonAdd);
            EntryList.Controls.Add(buttonEdit);
            EntryList.Controls.Add(buttonDelete);
            EntryList.Controls.Add(SearchButton);
            EntryList.Controls.Add(textBoxSearchEntry);
            EntryList.Controls.Add(dataGridViewEntries);
            EntryList.Location = new Point(4, 29);
            EntryList.Name = "EntryList";
            EntryList.Padding = new Padding(3);
            EntryList.Size = new Size(1014, 450);
            EntryList.TabIndex = 0;
            EntryList.Text = "Entry List";
            EntryList.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 39);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(143, 39);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(131, 29);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(280, 39);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(6, 6);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(131, 27);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEntry
            // 
            textBoxSearchEntry.Location = new Point(143, 6);
            textBoxSearchEntry.Name = "textBoxSearchEntry";
            textBoxSearchEntry.Size = new Size(811, 27);
            textBoxSearchEntry.TabIndex = 1;
            // 
            // dataGridViewEntries
            // 
            dataGridViewEntries.AllowUserToAddRows = false;
            dataGridViewEntries.AllowUserToDeleteRows = false;
            dataGridViewEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntries.Dock = DockStyle.Bottom;
            dataGridViewEntries.Location = new Point(3, 81);
            dataGridViewEntries.Name = "dataGridViewEntries";
            dataGridViewEntries.ReadOnly = true;
            dataGridViewEntries.RowHeadersWidth = 51;
            dataGridViewEntries.RowTemplate.Height = 29;
            dataGridViewEntries.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewEntries.Size = new Size(1008, 366);
            dataGridViewEntries.TabIndex = 0;
            // 
            // tabPageEntriesOperations
            // 
            tabPageEntriesOperations.Controls.Add(EntryList);
            tabPageEntriesOperations.Controls.Add(tabPageEntryDetails);
            tabPageEntriesOperations.Controls.Add(tabPagePasswordGenerator);
            tabPageEntriesOperations.Dock = DockStyle.Bottom;
            tabPageEntriesOperations.Location = new Point(0, 55);
            tabPageEntriesOperations.Name = "tabPageEntriesOperations";
            tabPageEntriesOperations.SelectedIndex = 0;
            tabPageEntriesOperations.Size = new Size(1022, 483);
            tabPageEntriesOperations.TabIndex = 2;
            // 
            // tabPagePasswordGenerator
            // 
            tabPagePasswordGenerator.Controls.Add(buttonCancelPasswordGenerator);
            tabPagePasswordGenerator.Controls.Add(labelBigLetters);
            tabPagePasswordGenerator.Controls.Add(buttonGenerate);
            tabPagePasswordGenerator.Controls.Add(textBoxLength);
            tabPagePasswordGenerator.Controls.Add(labelLength);
            tabPagePasswordGenerator.Controls.Add(checkBoxSpecialCharacters);
            tabPagePasswordGenerator.Controls.Add(checkBoxSpecialBrackets);
            tabPagePasswordGenerator.Controls.Add(checkBoxNumbers);
            tabPagePasswordGenerator.Controls.Add(checkBoxSmallLetters);
            tabPagePasswordGenerator.Location = new Point(4, 29);
            tabPagePasswordGenerator.Name = "tabPagePasswordGenerator";
            tabPagePasswordGenerator.Padding = new Padding(3);
            tabPagePasswordGenerator.Size = new Size(1014, 450);
            tabPagePasswordGenerator.TabIndex = 2;
            tabPagePasswordGenerator.Text = "Password Generator";
            tabPagePasswordGenerator.UseVisualStyleBackColor = true;
            // 
            // buttonCancelPasswordGenerator
            // 
            buttonCancelPasswordGenerator.Location = new Point(8, 260);
            buttonCancelPasswordGenerator.Name = "buttonCancelPasswordGenerator";
            buttonCancelPasswordGenerator.Size = new Size(198, 45);
            buttonCancelPasswordGenerator.TabIndex = 11;
            buttonCancelPasswordGenerator.Text = "Cancel";
            buttonCancelPasswordGenerator.UseVisualStyleBackColor = true;
            // 
            // labelBigLetters
            // 
            labelBigLetters.AutoSize = true;
            labelBigLetters.Location = new Point(6, 13);
            labelBigLetters.Name = "labelBigLetters";
            labelBigLetters.Size = new Size(239, 20);
            labelBigLetters.TabIndex = 10;
            labelBigLetters.Text = "Big Letters are mandatory ( ABC... )";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(8, 209);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(198, 45);
            buttonGenerate.TabIndex = 9;
            buttonGenerate.Text = "Generate Password";
            buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(8, 176);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(198, 27);
            textBoxLength.TabIndex = 8;
            textBoxLength.Text = "20";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(8, 153);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(140, 20);
            labelLength.TabIndex = 7;
            labelLength.Text = "Length of Password:";
            // 
            // checkBoxSpecialCharacters
            // 
            checkBoxSpecialCharacters.AutoSize = true;
            checkBoxSpecialCharacters.Location = new Point(8, 126);
            checkBoxSpecialCharacters.Name = "checkBoxSpecialCharacters";
            checkBoxSpecialCharacters.Size = new Size(214, 24);
            checkBoxSpecialCharacters.TabIndex = 5;
            checkBoxSpecialCharacters.Text = "Special Characters ( !@#... ) ";
            checkBoxSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialBrackets
            // 
            checkBoxSpecialBrackets.AutoSize = true;
            checkBoxSpecialBrackets.Location = new Point(8, 96);
            checkBoxSpecialBrackets.Name = "checkBoxSpecialBrackets";
            checkBoxSpecialBrackets.Size = new Size(138, 24);
            checkBoxSpecialBrackets.TabIndex = 4;
            checkBoxSpecialBrackets.Text = "Brackets ( []{}() )";
            checkBoxSpecialBrackets.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Checked = true;
            checkBoxNumbers.CheckState = CheckState.Checked;
            checkBoxNumbers.Location = new Point(8, 66);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(146, 24);
            checkBoxNumbers.TabIndex = 3;
            checkBoxNumbers.Text = "Numbers ( 012... )";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallLetters
            // 
            checkBoxSmallLetters.AutoSize = true;
            checkBoxSmallLetters.Checked = true;
            checkBoxSmallLetters.CheckState = CheckState.Checked;
            checkBoxSmallLetters.Location = new Point(8, 36);
            checkBoxSmallLetters.Name = "checkBoxSmallLetters";
            checkBoxSmallLetters.Size = new Size(168, 24);
            checkBoxSmallLetters.TabIndex = 2;
            checkBoxSmallLetters.Text = "Small Letters ( abc.. )";
            checkBoxSmallLetters.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New ";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(224, 26);
            closeToolStripMenuItem.Text = "E&xit";
            // 
            // EntryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 538);
            Controls.Add(tabPageEntriesOperations);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EntryView";
            Text = "PasswordManager";
            tabPageEntryDetails.ResumeLayout(false);
            tabPageEntryDetails.PerformLayout();
            EntryList.ResumeLayout(false);
            EntryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntries).EndInit();
            tabPageEntriesOperations.ResumeLayout(false);
            tabPagePasswordGenerator.ResumeLayout(false);
            tabPagePasswordGenerator.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPageEntryDetails;
        private TabPage EntryList;
        private Button SearchButton;
        private TextBox textBoxSearchEntry;
        private DataGridView dataGridViewEntries;
        private TabControl tabPageEntriesOperations;
        private Label labelTitle;
        private Label labelPassword;
        private TextBox textBoxTitle;
        private TextBox textBoxPassword;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxNotes;
        private Label labelNotes;
        private TextBox textBoxUrl;
        private Label labelUrl;
        private Button buttonSave;
        private Button buttonGeneratePassword;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private TabPage tabPagePasswordGenerator;
        private CheckBox checkBoxSmallLetters;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxSpecialBrackets;
        private CheckBox checkBoxSpecialCharacters;
        private Label labelLength;
        private TextBox textBoxLength;
        private Button buttonGenerate;
        private Label labelBigLetters;
        private Button buttonCancelEntryDetails;
        private Button buttonCancelPasswordGenerator;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}