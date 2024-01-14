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
            Entries = new Label();
            panel1 = new Panel();
            tabPageEntryDetails = new TabPage();
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
            panel1.SuspendLayout();
            tabPageEntryDetails.SuspendLayout();
            EntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntries).BeginInit();
            tabPageEntriesOperations.SuspendLayout();
            SuspendLayout();
            // 
            // Entries
            // 
            Entries.AutoSize = true;
            Entries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Entries.Location = new Point(26, 9);
            Entries.Name = "Entries";
            Entries.Size = new Size(70, 28);
            Entries.TabIndex = 0;
            Entries.Text = "Entries";
            // 
            // panel1
            // 
            panel1.Controls.Add(Entries);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 55);
            panel1.TabIndex = 1;
            // 
            // tabPageEntryDetails
            // 
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
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(851, 153);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(153, 29);
            buttonGeneratePassword.TabIndex = 11;
            buttonGeneratePassword.Text = "Password Generator";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(11, 292);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(148, 29);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(6, 259);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(998, 27);
            textBoxNotes.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(8, 236);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(51, 20);
            labelNotes.TabIndex = 8;
            labelNotes.Text = "Notes:";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(6, 206);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(998, 27);
            textBoxUrl.TabIndex = 7;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(6, 183);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(38, 20);
            labelUrl.TabIndex = 6;
            labelUrl.Text = "URL:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(496, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(508, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(496, 77);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(6, 153);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(839, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(6, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(77, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password: ";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(6, 100);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(484, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(6, 77);
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
            tabPageEntriesOperations.Dock = DockStyle.Fill;
            tabPageEntriesOperations.Location = new Point(0, 55);
            tabPageEntriesOperations.Name = "tabPageEntriesOperations";
            tabPageEntriesOperations.SelectedIndex = 0;
            tabPageEntriesOperations.Size = new Size(1022, 483);
            tabPageEntriesOperations.TabIndex = 2;
            // 
            // EntryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 538);
            Controls.Add(tabPageEntriesOperations);
            Controls.Add(panel1);
            Name = "EntryView";
            Text = "EntryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageEntryDetails.ResumeLayout(false);
            tabPageEntryDetails.PerformLayout();
            EntryList.ResumeLayout(false);
            EntryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntries).EndInit();
            tabPageEntriesOperations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Entries;
        private Panel panel1;
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
    }
}