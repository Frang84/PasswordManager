namespace WinFormsPasswordManager.Views
{
    partial class CreateDatabaseView
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
            textBoxPassword = new TextBox();
            textBoxRepeat = new TextBox();
            buttonCancel = new Button();
            buttonCreate = new Button();
            labelPassword = new Label();
            labelRepeat = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(117, 12);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(637, 27);
            textBoxPassword.TabIndex = 0;
            // 
            // textBoxRepeat
            // 
            textBoxRepeat.Location = new Point(117, 64);
            textBoxRepeat.Name = "textBoxRepeat";
            textBoxRepeat.PasswordChar = '*';
            textBoxRepeat.Size = new Size(637, 27);
            textBoxRepeat.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(660, 143);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(557, 143);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(41, 15);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // labelRepeat
            // 
            labelRepeat.AutoSize = true;
            labelRepeat.Location = new Point(51, 67);
            labelRepeat.Name = "labelRepeat";
            labelRepeat.Size = new Size(60, 20);
            labelRepeat.TabIndex = 5;
            labelRepeat.Text = "Repeat ";
            // 
            // CreateDatabaseView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 184);
            Controls.Add(labelRepeat);
            Controls.Add(labelPassword);
            Controls.Add(buttonCreate);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxRepeat);
            Controls.Add(textBoxPassword);
            Name = "CreateDatabaseView";
            Text = "CreateDatabaseView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxRepeat;
        private Button buttonCancel;
        private Button buttonCreate;
        private Label labelPassword;
        private Label labelRepeat;
    }
}