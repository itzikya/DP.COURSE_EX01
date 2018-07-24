using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook.UI
{
    public partial class AppMainForm : Form
    {
        User m_LoggedInUser;

        private void loginAndInit()
        {
            /// Owner: design.patterns

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login("2010645948945916",
            "public_profile",
            "user_events",
            "user_friends",
            "user_birthday",
            "user_photos",
            "user_likes");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        public AppMainForm()
        {
            InitializeComponent();
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            
        }

       

    }
}
