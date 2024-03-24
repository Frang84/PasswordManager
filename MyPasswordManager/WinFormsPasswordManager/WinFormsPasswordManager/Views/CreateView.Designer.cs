namespace WinFormsPasswordManager.Views
{
    partial class CreateView
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelMasterPassword = new Label();
            labelRepeat = new Label();
            buttonCreate = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(802, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(802, 27);
            textBox2.TabIndex = 1;
            // 
            // labelMasterPassword
            // 
            labelMasterPassword.AutoSize = true;
            labelMasterPassword.Location = new Point(12, 27);
            labelMasterPassword.Name = "labelMasterPassword";
            labelMasterPassword.Size = new Size(122, 20);
            labelMasterPassword.TabIndex = 2;
            labelMasterPassword.Text = "Master Password:";
            // 
            // labelRepeat
            // 
            labelRepeat.AutoSize = true;
            labelRepeat.Location = new Point(12, 80);
            labelRepeat.Name = "labelRepeat";
            labelRepeat.Size = new Size(59, 20);
            labelRepeat.TabIndex = 3;
            labelRepeat.Text = "Repeat:";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(568, 199);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(120, 40);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(694, 199);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 40);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 251);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(labelRepeat);
            Controls.Add(labelMasterPassword);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelMasterPassword;
        private Label labelRepeat;
        private Button buttonCreate;
        private Button buttonCancel;
    }
}