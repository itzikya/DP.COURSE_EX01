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
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatchPerson2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(35, 29);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(132, 123);
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(35, 182);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 44);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxMatchPerson1
            // 
            this.pictureBoxMatchPerson1.Location = new System.Drawing.Point(533, 132);
            this.pictureBoxMatchPerson1.Name = "pictureBoxMatchPerson1";
            this.pictureBoxMatchPerson1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMatchPerson1.TabIndex = 2;
            this.pictureBoxMatchPerson1.TabStop = false;
            // 
            // pictureBoxMatchPerson2
            // 
            this.pictureBoxMatchPerson2.Location = new System.Drawing.Point(754, 132);
            this.pictureBoxMatchPerson2.Name = "pictureBoxMatchPerson2";
            this.pictureBoxMatchPerson2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMatchPerson2.TabIndex = 3;
            this.pictureBoxMatchPerson2.TabStop = false;
            // 
            // labelMatchPerson1
            // 
            this.labelMatchPerson1.AutoSize = true;
            this.labelMatchPerson1.Location = new System.Drawing.Point(568, 258);
            this.labelMatchPerson1.Name = "labelMatchPerson1";
            this.labelMatchPerson1.Size = new System.Drawing.Size(0, 20);
            this.labelMatchPerson1.TabIndex = 4;
            // 
            // labelMatchPerson2
            // 
            this.labelMatchPerson2.AutoSize = true;
            this.labelMatchPerson2.Location = new System.Drawing.Point(788, 257);
            this.labelMatchPerson2.Name = "labelMatchPerson2";
            this.labelMatchPerson2.Size = new System.Drawing.Size(0, 20);
            this.labelMatchPerson2.TabIndex = 5;
            // 
            // labelMatchGame
            // 
            this.labelMatchGame.AutoSize = true;
            this.labelMatchGame.Location = new System.Drawing.Point(646, 80);
            this.labelMatchGame.Name = "labelMatchGame";
            this.labelMatchGame.Size = new System.Drawing.Size(132, 20);
            this.labelMatchGame.TabIndex = 6;
            this.labelMatchGame.Text = "The Match Maker";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(650, 267);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 50);
            this.button.TabIndex = 7;
            this.button.Text = "Raffle!";
            this.button.UseVisualStyleBackColor = true;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 641);
            this.Controls.Add(this.button);
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
        private System.Windows.Forms.Button button;
    }
}

