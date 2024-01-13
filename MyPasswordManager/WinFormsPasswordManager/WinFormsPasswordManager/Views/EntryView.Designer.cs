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
            tabPageAddEntry = new TabPage();
            EntryList = new TabPage();
            dataGridViewEntries = new DataGridView();
            textBoxSearchEntry = new TextBox();
            SearchButton = new Button();
            tabPageEntriesOperations = new TabControl();
            panel1.SuspendLayout();
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
            tabPageAddEntry.Location = new Point(4, 29);
            tabPageAddEntry.Name = "tabPageAddEntry";
            tabPageAddEntry.Padding = new Padding(3);
            tabPageAddEntry.Size = new Size(1014, 450);
            tabPageAddEntry.TabIndex = 1;
            tabPageAddEntry.Text = "Add Entry";
            tabPageAddEntry.UseVisualStyleBackColor = true;
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
            dataGridViewEntries.Size = new Size(1008, 366);
            dataGridViewEntries.TabIndex = 0;
            // 
            // textBoxSearchEntry
            // 
            textBoxSearchEntry.Location = new Point(145, 43);
            textBoxSearchEntry.Name = "textBoxSearchEntry";
            textBoxSearchEntry.Size = new Size(811, 27);
            textBoxSearchEntry.TabIndex = 1;
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
    }
}