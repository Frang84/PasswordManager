namespace WinFormsPasswordManager.Views
{
    partial class PasswordGeneratorView
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
            checkBoxBigLetters = new CheckBox();
            checkBoxSmallLetters = new CheckBox();
            checkBoxNumbers = new CheckBox();
            checkBoxSpecialCharacters = new CheckBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            labelLength = new Label();
            buttonGenerate = new Button();
            SuspendLayout();
            // 
            // checkBoxBigLetters
            // 
            checkBoxBigLetters.AutoSize = true;
            checkBoxBigLetters.Checked = true;
            checkBoxBigLetters.CheckState = CheckState.Checked;
            checkBoxBigLetters.Location = new Point(12, 10);
            checkBoxBigLetters.Name = "checkBoxBigLetters";
            checkBoxBigLetters.Size = new Size(157, 24);
            checkBoxBigLetters.TabIndex = 0;
            checkBoxBigLetters.Text = "Big letters ( ABC... )";
            checkBoxBigLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallLetters
            // 
            checkBoxSmallLetters.AutoSize = true;
            checkBoxSmallLetters.Checked = true;
            checkBoxSmallLetters.CheckState = CheckState.Checked;
            checkBoxSmallLetters.Location = new Point(12, 40);
            checkBoxSmallLetters.Name = "checkBoxSmallLetters";
            checkBoxSmallLetters.Size = new Size(168, 24);
            checkBoxSmallLetters.TabIndex = 1;
            checkBoxSmallLetters.Text = "Small Letters ( abc.. )";
            checkBoxSmallLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Checked = true;
            checkBoxNumbers.CheckState = CheckState.Checked;
            checkBoxNumbers.Location = new Point(12, 70);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(146, 24);
            checkBoxNumbers.TabIndex = 2;
            checkBoxNumbers.Text = "Numbers ( 012... )";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialCharacters
            // 
            checkBoxSpecialCharacters.AutoSize = true;
            checkBoxSpecialCharacters.Location = new Point(12, 100);
            checkBoxSpecialCharacters.Name = "checkBoxSpecialCharacters";
            checkBoxSpecialCharacters.Size = new Size(138, 24);
            checkBoxSpecialCharacters.TabIndex = 3;
            checkBoxSpecialCharacters.Text = "Brackets ( []{}() )";
            checkBoxSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(214, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Special Characters ( !@#... ) ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "20";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(12, 157);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(140, 20);
            labelLength.TabIndex = 6;
            labelLength.Text = "Length of Password:";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(12, 213);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(198, 45);
            buttonGenerate.TabIndex = 7;
            buttonGenerate.Text = "Generate Password";
            buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // PasswordGeneratorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 270);
            Controls.Add(buttonGenerate);
            Controls.Add(labelLength);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(checkBoxSpecialCharacters);
            Controls.Add(checkBoxNumbers);
            Controls.Add(checkBoxSmallLetters);
            Controls.Add(checkBoxBigLetters);
            Name = "PasswordGeneratorView";
            Text = "PasswordGeneratorView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxBigLetters;
        private CheckBox checkBoxSmallLetters;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxSpecialCharacters;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label labelLength;
        private Button buttonGenerate;
    }
}