using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginScreen : Form
    {
        MyTcpClient client = new MyTcpClient();

        public LoginScreen()
        {
            InitializeComponent();
        }

        void ConnectToServer(string name)
        {

        } 

        void GetAllMembers()
        {

        }

        
    }
}
