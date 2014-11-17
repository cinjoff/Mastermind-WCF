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
    public partial class RoomForm : Form
    {
        public ServiceReference1.ServiceClient proxy;
        List<int> myListofGuess;
        public string playerName, roomName;
        public RoomForm(ref ServiceReference1.ServiceClient Proxy, string PlayerName, string RoomName)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(65, 61, 61);
            gpGuess.ForeColor = Color.FromArgb(0, 204, 190);
            gpFeedback.ForeColor = Color.FromArgb(0, 204, 190);
            gbChat.ForeColor = Color.FromArgb(0, 204, 190);
            gbPlayersIngame.ForeColor = Color.FromArgb(0, 204, 190);
            lbIguessTheNumber.ForeColor = Color.FromArgb(200, 255, 0);
            lbNumberOfGuesses.ForeColor = Color.FromArgb(200, 255, 0);
            btnTryGuess.ForeColor = Color.FromArgb(200, 255, 0);
            btnLeaveRoom.ForeColor = Color.FromArgb(200, 255, 0);
            btnStart.ForeColor = Color.FromArgb(200, 255, 0);
            btnJoinNewRoom.ForeColor = Color.FromArgb(200, 255, 0);
            lbChat.Items.Add("Welcome to the game! Start guessing!");
            proxy = Proxy;
            this.playerName = PlayerName;
            this.roomName = RoomName;
            Global.info = this.lbFeedback;
            if (playerName != roomName)
            {
                btnStart.ForeColor = Color.FromArgb(255, 0, 0);
                btnStart.Text = "Game started";
                btnStart.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm(ref proxy, playerName);
            mf.Show();
        }

        private void btnLeaveRoom_Click(object sender, EventArgs e)
        {
            proxy.PlayerLeaveRoom(playerName, roomName);
            this.Hide();
            MainForm mf = new MainForm(ref proxy, this.playerName);
            mf.Show();
        }

        private void btnTryGuess_Click(object sender, EventArgs e)
        {
            //try
            //{
                myListofGuess = new List<int>();
                for (int i = 0; i <= 3; i++)
                {
                    myListofGuess.Add(Convert.ToInt32(tbGuessInput.Text.Substring(i, 1)));
                }
                int[] myList = proxy.GetHiddenNumber(roomName);
                lbFeedback.Items.Add(myList[0] + " " + myList[1] + " " + " " + myList[2] + " " + myList[3]);
                string[] myResults = proxy.GetGuessResults(myListofGuess.ToArray(), roomName);
                string results = "";
                int count = 0;
                for (int i = 0; i < myResults.Length; i++)
                {
                    if (myResults[i] == "A")
                    {
                        results += "✓";
                        count++;
                    }
                    else if (myResults[i] == "B")
                    {
                        results += "?";
                    }

                }
                if (count==4)
                {
                    proxy.GameOver(roomName);
                }

                lbFeedback.Items.Add(results + "      " + tbGuessInput.Text);
                tbGuessInput.Text = "";

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            proxy.StartNewGame(roomName);
            btnStart.Enabled = false;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            List<string> playersInRoom = proxy.GetPlayersInRoom(roomName).ToList();
            foreach (string playerName in playersInRoom)
            {
                lbPlayers.Items.Add(playerName);
            }
        }
        public class IService1Callback : ServiceReference1.IServiceCallback
        {
            public void gameFinished(string resulOfGame)
            {
                Global.info.Items.Add(resulOfGame);
            }
        }

        static public class Global
        {
            static public ListBox info;
        }


    }
}
