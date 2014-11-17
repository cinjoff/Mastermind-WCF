using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace MastermindGameGUI
{
    public partial class LoginForm : Form
    {
        public ServiceReference1.ServiceClient proxy;
        public string playerName;
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(65, 61, 61);
            lbAccount.ForeColor = Color.FromArgb(200, 255, 0);
            lbPassword.ForeColor = Color.FromArgb(200, 255, 0);
            btnLogin.ForeColor = Color.FromArgb(200, 255, 0);
            //btnLogin.BackColor = Color.FromArgb(75, 0, 15);
            lbRegister.LinkColor = Color.FromArgb(0, 204, 190);
            proxy = new ServiceReference1.ServiceClient();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm(ref proxy, playerName);
            this.Hide();
            rf.Show();
            rf.Activate();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbAccount.Text != "" && tbPassword.Text != "")
            {
                if (proxy.Login(tbAccount.Text, tbPassword.Text))
                {
                    MessageBox.Show("Succesfully logged in as " + tbAccount.Text + " !");
                    playerName = tbAccount.Text;
                    this.Hide();
                    MainForm mf = new MainForm(ref proxy, playerName);
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Player login failed. Please check your password & username!");
                }
            }
            else
            {
                MessageBox.Show("Please input Player name and Password in the fields!");
            }


        }
        /*public class IService1Callback : ServiceReference1.IServiceCallback
        {
            public void gameFinished(string resulOfGame)
            {
                //Global.info.Items.Add(resulOfGame);
            }
        }*/

    }
}
