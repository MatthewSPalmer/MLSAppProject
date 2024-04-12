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
    public partial class RegisterAgent : Form
    {
        AgentCRUD agentCRUD;
        public RegisterAgent()
        {
            InitializeComponent();
        }

        private void RegisterAgent_Load(object sender, EventArgs e)
        {
            agentCRUD = new AgentCRUD();  //  Instantiate AgentCRUD class
            txtAgentId.Text = (agentCRUD.GetMaxAgentId() + 1).ToString();  //  Set Agent ID for new agent to one more than current max ID number in DB
            txtAgentId.ReadOnly = true;  //  Prevent user from changing AgentId
        }

        private void btnNewAgentSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgentId.Text) && !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text))  //  Check fields for data
            {
                var newAgent = new Agent();  //  Create temp agent and set fields to user entered values
                newAgent.AgentID = int.Parse(txtAgentId.Text);
                newAgent.Username = txtUsername.Text;
                newAgent.Password = txtPassword.Text;
                newAgent.Name = txtName.Text;
                newAgent.Phone = txtPhone.Text;
                newAgent.Email = txtEmail.Text;
                agentCRUD.AddAgent(newAgent);  //  Pass temp agent to AddAgent method to add to DB
                MessageBox.Show("New agent added!");
                CurrentAgent.currentAgent.CurrentAgentId = newAgent.AgentID;  //  Set CurrentAgentId to the new agent's ID
                AgentPortal agentPortal = new AgentPortal();  //  Create and show Agent Portal, close Register Agent form
                agentPortal.Show();
                this.Close();
            }
            else
                MessageBox.Show("Please fill out all fields!");
        }
    }
}
