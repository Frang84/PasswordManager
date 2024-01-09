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
            tabPageEntryList = new TabControl();
            EntryList = new TabPage();
            SearchButton = new Button();
            textBoxSearchEntry = new TextBox();
            dataGridViewEntris = new DataGridView();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            tabPageEntryList.SuspendLayout();
            EntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntris).BeginInit();
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
            // tabPageEntryList
            // 
            tabPageEntryList.Controls.Add(EntryList);
            tabPageEntryList.Controls.Add(tabPage2);
            tabPageEntryList.Dock = DockStyle.Fill;
            tabPageEntryList.Location = new Point(0, 55);
            tabPageEntryList.Name = "tabPageEntryList";
            tabPageEntryList.SelectedIndex = 0;
            tabPageEntryList.Size = new Size(1022, 483);
            tabPageEntryList.TabIndex = 2;
            // 
            // EntryList
            // 
            EntryList.Controls.Add(SearchButton);
            EntryList.Controls.Add(textBoxSearchEntry);
            EntryList.Controls.Add(dataGridViewEntris);
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
            SearchButton.Text = "button1";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEntry
            // 
            textBoxSearchEntry.Location = new Point(145, 43);
            textBoxSearchEntry.Name = "textBoxSearchEntry";
            textBoxSearchEntry.Size = new Size(811, 27);
            textBoxSearchEntry.TabIndex = 1;
            // 
            // dataGridViewEntris
            // 
            dataGridViewEntris.AllowUserToAddRows = false;
            dataGridViewEntris.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEntris.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEntris.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntris.Dock = DockStyle.Bottom;
            dataGridViewEntris.Location = new Point(3, 81);
            dataGridViewEntris.Name = "dataGridViewEntris";
            dataGridViewEntris.ReadOnly = true;
            dataGridViewEntris.RowHeadersWidth = 51;
            dataGridViewEntris.RowTemplate.Height = 29;
            dataGridViewEntris.Size = new Size(1008, 366);
            dataGridViewEntris.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1014, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EntryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 538);
            Controls.Add(tabPageEntryList);
            Controls.Add(panel1);
            Name = "EntryView";
            Text = "EntryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageEntryList.ResumeLayout(false);
            EntryList.ResumeLayout(false);
            EntryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntris).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Entries;
        private Panel panel1;
        private TabControl tabPageEntryList;
        private TabPage EntryList;
        private TabPage tabPage2;
        private DataGridView dataGridViewEntris;
        private Button SearchButton;
        private TextBox textBoxSearchEntry;
    }
}