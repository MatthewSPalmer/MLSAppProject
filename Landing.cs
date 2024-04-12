using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSApp
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {

        }

        private void btnClientPortal_Click(object sender, EventArgs e)
        {
            ClientPortal clientPortal = new ClientPortal();  //  Create ClientPortal form
            clientPortal.Show();  //  Display Client Portal
            this.Hide();  //  Close Landing form
        }

        private void btnAgentPortal_Click(object sender, EventArgs e)
        {
            AgentLogin agentLogin = new AgentLogin();  //  Create AgentLogin form
            agentLogin.Show();  //  Display Agent Portal
            this.Hide();  //  Close Landing Form
        }
    }
}
