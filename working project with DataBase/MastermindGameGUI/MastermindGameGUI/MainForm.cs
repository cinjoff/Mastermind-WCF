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
    public partial class MainForm : Form
    {
        public ServiceReference1.ServiceClient proxy;
        public string playerName;
        public MainForm(ref ServiceReference1.ServiceClient Proxy, string PlayerName)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(65, 61, 61);
            btnCreateRoom.ForeColor = Color.FromArgb(200, 255, 0);
            btnQuickJoin.ForeColor = Color.FromArgb(200, 255, 0);
            btnRefresh.ForeColor = Color.FromArgb(200, 255, 0);
            lbPlayersOnline.ForeColor = Color.FromArgb(0, 204, 190);
            lbAccount.ForeColor = Color.FromArgb(200, 255, 0);
            btnJoin.ForeColor = Color.FromArgb(200, 255, 0);
            btnPlayerDetails.ForeColor = Color.FromArgb(200, 255, 0);
            btnLogout.BackColor = Color.FromArgb(185, 5, 4);
            groupBox1.ForeColor = Color.FromArgb(0, 204, 190);
            groupBox2.ForeColor = Color.FromArgb(0, 204, 190);
            groupBox3.ForeColor = Color.FromArgb(0, 204, 190);
            this.proxy = Proxy;
            this.playerName = PlayerName;
            Global.info = this.lbRooms;
            timer1 = new Timer();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            proxy.PlayerCreateRoom(playerName);
            this.Hide();
            RoomForm rf = new RoomForm(ref proxy, playerName, playerName);
            rf.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string RoomName = lbRooms.SelectedItem.ToString();
            if (proxy.PlayerJoinRoom(playerName,RoomName))
            {
                this.Hide();
                RoomForm rf = new RoomForm(ref proxy, playerName, RoomName);
                rf.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            proxy.PlayerLeavePortal(playerName);
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbPlayersOnline.Text = "Players online: " + proxy.GetListOfPlayers().Count().ToString();
            List<string> roomList = proxy.GetRoomList().ToList();
            foreach (string roomName in roomList)
            {
                lbRooms.Items.Add(roomName);
            }
            lbAccountPlace.Text = playerName;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            List<string> roomList = proxy.GetRoomList().ToList();
            foreach (string roomName in roomList)
            {
                lbRooms.Items.Add(roomName);
            }
            lbPlayersOnline.Text = "Players online: " + proxy.GetListOfPlayers().Count().ToString();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.PlayerLeavePortal(playerName);
        }

        /*public class IService1Callback : ServiceReference1.IServiceCallback
        {
            public void gameFinished(string resulOfGame)
            {
                Global.info.Items.Add(resulOfGame);
            }
        }*/

        static public class Global
        {
            static public ListBox info;
        }
       
       
    }
}
