namespace WinFormsPasswordManager.Views
{
    partial class UnlockView
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
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonUnlock = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(21, 33);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(77, 20);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password: ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(104, 30);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(512, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonUnlock
            // 
            buttonUnlock.Location = new Point(422, 63);
            buttonUnlock.Name = "buttonUnlock";
            buttonUnlock.Size = new Size(94, 29);
            buttonUnlock.TabIndex = 2;
            buttonUnlock.Text = "Unlock";
            buttonUnlock.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(522, 63);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // UnlockView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 104);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUnlock);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Name = "UnlockView";
            Text = "UnlockView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonUnlock;
        private Button buttonCancel;
    }
}