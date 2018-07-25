namespace Facebook.UI
{
    partial class AppMainForm
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
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxMatchPerson1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatchPerson2 = new System.Windows.Forms.PictureBox();
            this.labelMatchPerson1 = new System.Windows.Forms.Label();
            this.labelMatchPerson2 = new System.Windows.Forms.Label();
            this.labelMatchGame = new System.Windows.Forms.Label();
            this.buttonRaffle = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLoggedInUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(35, 29);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(152, 145);
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(35, 234);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 44);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxMatchPerson1
            // 
            this.pictureBoxMatchPerson1.Location = new System.Drawing.Point(483, 83);
            this.pictureBoxMatchPerson1.Name = "pictureBoxMatchPerson1";
            this.pictureBoxMatchPerson1.Size = new System.Drawing.Size(150, 149);
            this.pictureBoxMatchPerson1.TabIndex = 2;
            this.pictureBoxMatchPerson1.TabStop = false;
            // 
            // pictureBoxMatchPerson2
            // 
            this.pictureBoxMatchPerson2.Location = new System.Drawing.Point(754, 83);
            this.pictureBoxMatchPerson2.Name = "pictureBoxMatchPerson2";
            this.pictureBoxMatchPerson2.Size = new System.Drawing.Size(146, 149);
            this.pictureBoxMatchPerson2.TabIndex = 3;
            this.pictureBoxMatchPerson2.TabStop = false;
            // 
            // labelMatchPerson1
            // 
            this.labelMatchPerson1.AutoSize = true;
            this.labelMatchPerson1.Location = new System.Drawing.Point(543, 257);
            this.labelMatchPerson1.Name = "labelMatchPerson1";
            this.labelMatchPerson1.Size = new System.Drawing.Size(0, 20);
            this.labelMatchPerson1.TabIndex = 4;
            // 
            // labelMatchPerson2
            // 
            this.labelMatchPerson2.AutoSize = true;
            this.labelMatchPerson2.Location = new System.Drawing.Point(828, 235);
            this.labelMatchPerson2.Name = "labelMatchPerson2";
            this.labelMatchPerson2.Size = new System.Drawing.Size(0, 20);
            this.labelMatchPerson2.TabIndex = 5;
            // 
            // labelMatchGame
            // 
            this.labelMatchGame.AutoSize = true;
            this.labelMatchGame.Location = new System.Drawing.Point(637, 29);
            this.labelMatchGame.Name = "labelMatchGame";
            this.labelMatchGame.Size = new System.Drawing.Size(132, 20);
            this.labelMatchGame.TabIndex = 6;
            this.labelMatchGame.Text = "The Match Maker";
            // 
            // buttonRaffle
            // 
            this.buttonRaffle.Location = new System.Drawing.Point(641, 271);
            this.buttonRaffle.Name = "buttonRaffle";
            this.buttonRaffle.Size = new System.Drawing.Size(119, 50);
            this.buttonRaffle.TabIndex = 7;
            this.buttonRaffle.Text = "Raffle!";
            this.buttonRaffle.UseVisualStyleBackColor = true;
            this.buttonRaffle.Click += new System.EventHandler(this.buttonRaffle_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(35, 299);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(132, 46);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelLoggedInUserName
            // 
            this.labelLoggedInUserName.AutoSize = true;
            this.labelLoggedInUserName.Location = new System.Drawing.Point(49, 188);
            this.labelLoggedInUserName.Name = "labelLoggedInUserName";
            this.labelLoggedInUserName.Size = new System.Drawing.Size(0, 20);
            this.labelLoggedInUserName.TabIndex = 9;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 641);
            this.Controls.Add(this.labelLoggedInUserName);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonRaffle);
            this.Controls.Add(this.labelMatchGame);
            this.Controls.Add(this.labelMatchPerson2);
            this.Controls.Add(this.labelMatchPerson1);
            this.Controls.Add(this.pictureBoxMatchPerson2);
            this.Controls.Add(this.pictureBoxMatchPerson1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Name = "AppMainForm";
            this.Text = "AppMainForm";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxMatchPerson1;
        private System.Windows.Forms.PictureBox pictureBoxMatchPerson2;
        private System.Windows.Forms.Label labelMatchPerson1;
        private System.Windows.Forms.Label labelMatchPerson2;
        private System.Windows.Forms.Label labelMatchGame;
        private System.Windows.Forms.Button buttonRaffle;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLoggedInUserName;
    }
}

