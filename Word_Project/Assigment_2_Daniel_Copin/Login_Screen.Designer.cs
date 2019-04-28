namespace Assigment_2_Daniel_Copin
{
    partial class Login_Screen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.New_User = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(123, 53);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(100, 22);
            this.tB_Username.TabIndex = 0;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(123, 144);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(100, 22);
            this.tB_Password.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(34, 53);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(73, 17);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(34, 144);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 17);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // New_User
            // 
            this.New_User.Location = new System.Drawing.Point(349, 47);
            this.New_User.Name = "New_User";
            this.New_User.Size = new System.Drawing.Size(84, 23);
            this.New_User.TabIndex = 4;
            this.New_User.Text = "New User";
            this.New_User.UseVisualStyleBackColor = true;
            this.New_User.Click += new System.EventHandler(this.NewUser2_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(349, 94);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(84, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(349, 144);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(84, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 224);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.New_User);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Username);
            this.Name = "Login_Screen";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button New_User;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
    }
}

