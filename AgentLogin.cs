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
    public partial class AgentLogin : Form
    {
        AgentCRUD agentCRUD;
        int attempts = 0;  //  Counter for login attempts
        public AgentLogin()
        {
            InitializeComponent();
        }

        private void AgentLogin_Load(object sender, EventArgs e)
        {
            agentCRUD = new AgentCRUD();  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgentId.Text) && !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))  //  Check fields for data
            {
                int id = int.Parse(txtAgentId.Text);
                var agent = agentCRUD.GetAgentById(id);  //  Temp agent for holding info returned by GetAgentById method

                if (agent != null && agent.Username == txtUsername.Text && agent.Password == txtPassword.Text)  //  If an agent was found and the username/password matches
                {
                    CurrentAgent.currentAgent.CurrentAgentId = agent.AgentID;  //  Set the CurrentAgentId in the CurrentAgent class to this Agent ID
                    AgentPortal agentPortal = new AgentPortal();  //  Create and show Agent Portal form. Close Agent Login
                    agentPortal.Show();
                    this.Close();
                }
                else  //  If Agent ID doesn't return an agent from the DB or username/password doesn't match
                {
                    attempts++;  //  Add failed attempt to counter
                    if (attempts == 3)  //  If counter reaches 3, lock text fields
                    {
                        MessageBox.Show("User Locked out! Please exit program.");
                        txtAgentId.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                        txtUsername.ReadOnly = true;
                    }
                    int remaining = 3 - attempts;  //  Calculate remaining attempts, show user, and clear text boxes
                    MessageBox.Show($"Incorrect Username, Password, or Agent ID. {remaining} attempts remaining!");
                    txtAgentId.Clear();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields!");
            }
        }

        private void btnRegisterAgent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgentId.Text) && !string.IsNullOrEmpty(txtUsername.Text) && 
                !string.IsNullOrEmpty(txtPassword.Text))  //  Check fields for data
            {
                int id = int.Parse(txtAgentId.Text);
                var agent = agentCRUD.GetAgentById(id);  //  Temp agent for holding info returned by GetAgentById method

                if (agent != null && agent.Username == txtUsername.Text && agent.Password == txtPassword.Text)  //  If an agent was found and the username/password matches
                {
                    RegisterAgent registerAgent = new RegisterAgent(); // Create and show Register Agent form. Close Agent Login.
                    registerAgent.Show();
                    this.Close();
                }
                else  //  If Agent ID doesn't return an agent from the DB or username/password doesn't match
                {
                    attempts++;  //  Add failed attempt to counter
                    if (attempts == 3)  //  If counter reaches 3, lock text fields
                    {
                        MessageBox.Show("User Locked out! Please exit program.");
                        txtAgentId.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                        txtUsername.ReadOnly = true;
                    }
                    int remaining = 3 - attempts;  //  Calculate remaining attempts, show user, and clear text boxes
                    MessageBox.Show($"Incorrect Username, Password, or Agent ID. {remaining} attempts remaining!");
                    txtAgentId.Clear();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields!");
            }
        }

        private void txtAgentId_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtAgentId.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtAgentId.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtAgentId.Clear();
                }
            }
        }
    }
}
