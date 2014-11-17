using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindGameGUI
{
    public partial class RegisterForm : Form
    {
        public string playerName;
        public ServiceReference1.ServiceClient proxy;
        public RegisterForm(ref ServiceReference1.ServiceClient Proxy, string playerName)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(65, 61, 61);
            lbAccount.ForeColor = Color.FromArgb(200, 255, 0);
            lbPassword.ForeColor = Color.FromArgb(200, 255, 0);
            lbPasswordAgain.ForeColor = Color.FromArgb(200, 255, 0);
            lbTitle.ForeColor = Color.FromArgb(0, 204, 190);
            btnRegister.ForeColor = Color.FromArgb(200, 255, 0);
            lbBackToLogin.LinkColor = Color.FromArgb(0, 204, 190);
            this.proxy = Proxy;
            this.playerName = playerName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbAccount.Text != "" && tbPassword.Text != "" && tbPasswordAgain.Text != "")
            {
                if (tbPassword.Text != tbPasswordAgain.Text)
                {
                    MessageBox.Show("Please enter the same password twice!");
                }
                else
                {
                    if (proxy.RegisterNewPlayer(tbAccount.Text, tbPassword.Text))
                    {
                        this.Hide();
                        MainForm mf = new MainForm(ref proxy, tbAccount.Text);
                        mf.Show();
                    }
                    else
                    {
                        MessageBox.Show("This playername already exists, please choose another one!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input data in the fields!");
            }
            
        }
    }
}
