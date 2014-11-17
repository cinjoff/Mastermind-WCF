using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindGameGUI
{
    class MyForm : Form
    {
        public ServiceReference1.ServiceClient proxy;
        string playerName;
        public MyForm(ref ServiceReference1.ServiceClient Proxy, string playerName)
        {
            this.proxy = Proxy;
            this.playerName = playerName;
        }
    }
}
