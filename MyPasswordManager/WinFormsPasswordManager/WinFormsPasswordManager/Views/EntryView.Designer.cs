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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Entries = new Label();
            panel1 = new Panel();
            tabPageAddEntry = new TabPage();
            buttonCreate = new Button();
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
            SearchButton = new Button();
            textBoxSearchEntry = new TextBox();
            dataGridViewEntries = new DataGridView();
            tabPageEntriesOperations = new TabControl();
            buttonGeneratePassword = new Button();
            panel1.SuspendLayout();
            tabPageAddEntry.SuspendLayout();
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
            // tabPageAddEntry
            // 
            tabPageAddEntry.Controls.Add(buttonGeneratePassword);
            tabPageAddEntry.Controls.Add(buttonCreate);
            tabPageAddEntry.Controls.Add(textBoxNotes);
            tabPageAddEntry.Controls.Add(labelNotes);
            tabPageAddEntry.Controls.Add(textBoxUrl);
            tabPageAddEntry.Controls.Add(labelUrl);
            tabPageAddEntry.Controls.Add(textBoxName);
            tabPageAddEntry.Controls.Add(labelName);
            tabPageAddEntry.Controls.Add(textBoxPassword);
            tabPageAddEntry.Controls.Add(labelPassword);
            tabPageAddEntry.Controls.Add(textBoxTitle);
            tabPageAddEntry.Controls.Add(labelTitle);
            tabPageAddEntry.Location = new Point(4, 29);
            tabPageAddEntry.Name = "tabPageAddEntry";
            tabPageAddEntry.Padding = new Padding(3);
            tabPageAddEntry.Size = new Size(1014, 450);
            tabPageAddEntry.TabIndex = 1;
            tabPageAddEntry.Text = "Add Entry";
            tabPageAddEntry.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(8, 246);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(148, 29);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(8, 202);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(996, 27);
            textBoxNotes.TabIndex = 9;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(8, 179);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(51, 20);
            labelNotes.TabIndex = 8;
            labelNotes.Text = "Notes:";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(8, 149);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(996, 27);
            textBoxUrl.TabIndex = 7;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(11, 126);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(38, 20);
            labelUrl.TabIndex = 6;
            labelUrl.Text = "URL:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(498, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(508, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(498, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(8, 96);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(842, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(8, 73);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(77, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password: ";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(8, 43);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(484, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(8, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // EntryList
            // 
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
            // SearchButton
            // 
            SearchButton.Location = new Point(8, 43);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(131, 27);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEntry
            // 
            textBoxSearchEntry.Location = new Point(145, 43);
            textBoxSearchEntry.Name = "textBoxSearchEntry";
            textBoxSearchEntry.Size = new Size(811, 27);
            textBoxSearchEntry.TabIndex = 1;
            // 
            // dataGridViewEntries
            // 
            dataGridViewEntries.AllowUserToAddRows = false;
            dataGridViewEntries.AllowUserToDeleteRows = false;
            dataGridViewEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntries.Dock = DockStyle.Bottom;
            dataGridViewEntries.Location = new Point(3, 81);
            dataGridViewEntries.Name = "dataGridViewEntries";
            dataGridViewEntries.ReadOnly = true;
            dataGridViewEntries.RowHeadersWidth = 51;
            dataGridViewEntries.RowTemplate.Height = 29;
            dataGridViewEntries.Size = new Size(1008, 366);
            dataGridViewEntries.TabIndex = 0;
            // 
            // tabPageEntriesOperations
            // 
            tabPageEntriesOperations.Controls.Add(EntryList);
            tabPageEntriesOperations.Controls.Add(tabPageAddEntry);
            tabPageEntriesOperations.Dock = DockStyle.Fill;
            tabPageEntriesOperations.Location = new Point(0, 55);
            tabPageEntriesOperations.Name = "tabPageEntriesOperations";
            tabPageEntriesOperations.SelectedIndex = 0;
            tabPageEntriesOperations.Size = new Size(1022, 483);
            tabPageEntriesOperations.TabIndex = 2;
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(856, 96);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(148, 29);
            buttonGeneratePassword.TabIndex = 11;
            buttonGeneratePassword.Text = "Password Generator";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
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
            tabPageAddEntry.ResumeLayout(false);
            tabPageAddEntry.PerformLayout();
            EntryList.ResumeLayout(false);
            EntryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntries).EndInit();
            tabPageEntriesOperations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Entries;
        private Panel panel1;
        private TabPage tabPageAddEntry;
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
        private Button buttonCreate;
        private Button buttonGeneratePassword;
    }
}