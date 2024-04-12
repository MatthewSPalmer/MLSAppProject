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
    public partial class AgentPortal : Form
    {
        AgentCRUD agentCRUD;
        HouseCRUD houseCRUD;
        List<House> agentListings = new List<House>();  //  List to hold houses for the current agent
        public AgentPortal()
        {
            InitializeComponent();
        }

        private void AgentPortal_Load(object sender, EventArgs e)
        {
            agentCRUD = new AgentCRUD();
            houseCRUD = new HouseCRUD();
            txtCurrentAgentName.Text = agentCRUD.GetAgentName(CurrentAgent.currentAgent.CurrentAgentId);  //  Display name of current agent to user
            foreach (House house in houseCRUD.GetHouses())  //  Populate agentListings list with houses that have the CurrentAgentId as the AgentID
            {
                if (house.AgentID == CurrentAgent.currentAgent.CurrentAgentId)
                {
                    agentListings.Add(house);
                }
            }
            dataGridAgentListings.DataSource = agentListings;  //  Set data grid to agentListings list
            HideAgentGridColumns();  //  Hide unnecessary columns in data grid
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)  //  Create and show Update Agent form
        {
            UpdateAgent updateAgent = new UpdateAgent();
            updateAgent.Show();
        }

        private void btnAddHouse_Click(object sender, EventArgs e)  //  Create and show Add House form, close Agent Portal form
        {
            AddHouse addHouse = new AddHouse();
            addHouse.Show();
            this.Close();
        }
        private void HideAgentGridColumns()  //  Method for hiding unnecessary columns in data grid
        {
            dataGridAgentListings.Columns[2].Visible = false;
            dataGridAgentListings.Columns[4].Visible = false;
            dataGridAgentListings.Columns[7].Visible = false;
            dataGridAgentListings.Columns[8].Visible = false;
            dataGridAgentListings.Columns[9].Visible = false;
            dataGridAgentListings.Columns[10].Visible = false;
            dataGridAgentListings.Columns[11].Visible = false;
            dataGridAgentListings.Columns[12].Visible = false;
            dataGridAgentListings.Columns[14].Visible = false;
            dataGridAgentListings.Columns[15].Visible = false;

        }

        private void dataGridAgentListings_CellClick(object sender, DataGridViewCellEventArgs e)  //  Triggered when user clicks a cell in the data grid
        {
            int row = e.RowIndex;  //  Holds the index of the data grid row the user clicked on. The index is used to change form labels to display details from the agentListings list
            lblMLSNum.Text = $"MLS #: {agentListings[row].MLS}";
            lblPrice.Text = $"Price: {agentListings[row].Price:C0}";
            lblArea.Text = $"Area: {agentListings[row].Area}";
            lblBed.Text = $"Bed: {agentListings[row].Bed}";
            lblBath.Text = $"Bath: {agentListings[row].Bath}";
            lblAddress.Text = $"Address: { agentListings[row].Street}, {agentListings[row].City}, " +
                $"{agentListings[row].State} {agentListings[row].Zip}";
            richTextDescription.Text = agentListings[row].Description;
            CurrentAgent.currentAgent.CurrentHouseMLS = agentListings[row].MLS;  //  Sets CurrentHouseMLS to the MLS of the selected row
            groupBoxDetails.Visible = true;
            groupBoxDescription.Visible = true;
            btnRemoveHouse.Visible = true;  //  Allows user to Remove/Update the now selected house
            btnUpdateHouse.Visible = true;
        }

        private void btnUpdateHouse_Click(object sender, EventArgs e)  //  Create and show Update House form, close Agent Portal form
        {
            UpdateHouse updateHouse = new UpdateHouse();
            updateHouse.Show();
            this.Close();
        }

        private void btnRemoveHouse_Click(object sender, EventArgs e)  //  Create and show Remove House form, close Agent Portal form
        {
            var result = MessageBox.Show("Are you sure you want to remove the listing?",
                 "Warning", MessageBoxButtons.YesNo);  //  Make sure user wants to delete the house from DB
            if (result == DialogResult.Yes)
            {
                houseCRUD = new HouseCRUD();
                var removehouse = houseCRUD.GetHouse(CurrentAgent.currentAgent.CurrentHouseMLS);  //  Temp house populated with data based on CurrentHouseMLS
                houseCRUD.RemoveHouse(removehouse);  //  Pass temp house to the RemoveHouse function to delete it from the DB
                agentListings.Clear();  //  Clear the agentListings list contents
                dataGridAgentListings.DataSource = null;
                foreach (House house in houseCRUD.GetHouses())  //  Rebuild the agentListings list now that a house has been deleted
                {
                    if (house.AgentID == CurrentAgent.currentAgent.CurrentAgentId)
                    {
                        agentListings.Add(house);
                    }
                }
                dataGridAgentListings.DataSource = agentListings;  //  Set data grid to newly populated agentListing list
                HideAgentGridColumns();  //  Hide unnecessary columns in data grid
                MessageBox.Show("Listing removed!");
                groupBoxDetails.Visible = false;  //  Hide group boxes and buttons that need user to select a row in the data grid to function
                groupBoxDescription.Visible = false;
                btnRemoveHouse.Visible = false;
                btnUpdateHouse.Visible = false;
            }
        }

        private void btnChangeAgent_Click(object sender, EventArgs e)  //  Create and show Agent Login form, close Agent Portal form
        {
            AgentLogin agentLogin = new AgentLogin();
            agentLogin.Show();
            this.Close();
        }

        private void btnClientPortal_Click(object sender, EventArgs e)  //  Create and show Client Portal form, close Agent Portal form
        {
            ClientPortal clientPortal = new ClientPortal();
            clientPortal.Show();
            this.Close();
        }
    }
}
