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
            "user_likes",
            "user_posts");

           

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
            labelLoggedInUserName.Text = m_LoggedInUser.Name;
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(clearProfilePicture);
           
        }

        private void clearProfilePicture()
        {
            pictureBoxProfilePicture.ImageLocation = null;
        }

        private void buttonRaffle_Click(object sender, EventArgs e)
        {
            int numberOfFriends = m_LoggedInUser.Friends.Count;
            int friend1, friend2;
            User match1, match2;
            Random randomChoice = new Random();

            friend1 = randomChoice.Next(0, numberOfFriends);
            pictureBoxMatchPerson1.ImageLocation = m_LoggedInUser.Friends[friend1].PictureNormalURL;
            match1 = m_LoggedInUser.Friends[friend1];
            labelMatchPerson1.Text = match1.Name;
            friend2 = randomChoice.Next(0, numberOfFriends);

            while (friend1 == friend2)
            {
                friend2 = randomChoice.Next(0, numberOfFriends);
            }

            pictureBoxMatchPerson2.ImageLocation = m_LoggedInUser.Friends[friend2].PictureNormalURL;
            match2 = m_LoggedInUser.Friends[friend2];
            labelMatchPerson2.Text = match2.Name;
        }
    }
}
