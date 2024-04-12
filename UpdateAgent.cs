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
    public partial class UpdateAgent : Form
    {
        AgentCRUD agentCRUD;
        public UpdateAgent()
        {
            InitializeComponent();
        }

        private void UpdateAgent_Load(object sender, EventArgs e)
        {
            txtAgentId.Text = CurrentAgent.currentAgent.CurrentAgentId.ToString();  //  Set Agent ID text box to current agent
            txtAgentId.ReadOnly = true;  //  Prevent user from changing Agent ID
            agentCRUD = new AgentCRUD();
            int id = int.Parse(txtAgentId.Text);  
            var agent = agentCRUD.GetAgentById(id);  //  Create temp agent and populate with current agent info
            txtUsername.Text = agent.Username;
            txtPassword.Text = agent.Password;
            txtPhone.Text = agent.Phone;
            txtEmail.Text = agent.Email;
            txtName.Text = agent.Name;
        }

        private void btnUpdateAgentSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgentId.Text) && !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text))  //  Check fields for data
            {
                var updateAgent = new Agent();  //  Create temp agent with updated info from form fields
                updateAgent.AgentID = int.Parse(txtAgentId.Text);
                updateAgent.Username = txtUsername.Text;
                updateAgent.Password = txtPassword.Text;
                updateAgent.Name = txtName.Text;
                updateAgent.Phone = txtPhone.Text;
                updateAgent.Email = txtEmail.Text;
                agentCRUD.UpdateAgent(updateAgent.AgentID, updateAgent);  //  Pass temp agent info to UpdateAgent method to update DB
                MessageBox.Show("Agent information updated!");
                this.Close();  //  CLose Update Agent form to return to Agent Portal
            }
            else 
                MessageBox.Show("Please fill out all fields!");
        }
    }
}
