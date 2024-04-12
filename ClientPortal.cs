using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;

namespace MLSApp
{
    public partial class ClientPortal : Form
    {
        AgentCRUD agentCRUD;
        HouseCRUD houseCRUD;
        List<House> houseListing = new List<House>();  //  Temp list to hold houses from DB
        List<House> houseFiltered = new List<House>();   //  Temp list to hold houses that match filter settings
        List<House> houseSearch = new List<House>();  //  Temp list to hold house that matches MLS search
        List<string> city = new List<string>();  //  Temp list to hold unique cities in DB for the City combo box
        string mapUrl;  //  String to hold the Google Maps url for the selected house
        string name;  //  Strings to hold the agent information for the selected house
        string phone;
        string email;
        public ClientPortal()
        {
            InitializeComponent();
        }

        private void ClientPortal_Load(object sender, EventArgs e)
        {
            agentCRUD = new AgentCRUD();
            houseCRUD = new HouseCRUD();
            foreach (House house in houseCRUD.GetHouses())  //  Populate houseListing list with houses from the DB
            {
                houseListing.Add(house);
            }
            city.Add("All");  //  Add "All" as the first item in the city list
            foreach (House house in houseListing)  //  Add unique cities in the houseListing list to the city list for the City combo box
            {
                if (!city.Contains(house.City))
                {
                    city.Add(house.City);
                }
            }
            dataGridHouseListings.DataSource = houseListing;  //  Set data grid to houseListing list
            ResetFormFields();  //  Clear form fields and reset combo boxes to All
            HideHouseGridColumns();  //  Hide unnecessary columns in data grid
        }
        private string BuildMapsUrl(string street, string city, string state, string zip)  //  Build a url string to pass to Google Maps
        {
            string formattedUrl = $"https://www.google.com/maps/search/?api=1&query={street}+{city}+{state}+{zip}";
            return formattedUrl.Replace(" ", "%20");  //  Replace spaces in the string to meet url syntax
        }
        private void HideHouseGridColumns()  //  Hide unnecessary columns in data grid
        {
            dataGridHouseListings.Columns[2].Visible = false;
            dataGridHouseListings.Columns[4].Visible = false;
            dataGridHouseListings.Columns[7].Visible = false;
            dataGridHouseListings.Columns[9].Visible = false;
            dataGridHouseListings.Columns[10].Visible = false;
            dataGridHouseListings.Columns[11].Visible = false;
            dataGridHouseListings.Columns[12].Visible = false;
            dataGridHouseListings.Columns[13].Visible = false;
            dataGridHouseListings.Columns[14].Visible = false;
            dataGridHouseListings.Columns[15].Visible = false;
        }
        private void ResetFormFields()  //  Clear form fields and reset combo boxes to All
        {
            comboBoxPrice.SelectedIndex = 0;
            comboBoxArea.SelectedIndex = 0;
            comboBoxBed.SelectedIndex = 0;
            comboBoxBath.SelectedIndex = 0;
            comboBoxCity.DataSource = city;
            comboBoxCity.SelectedIndex = 0;
            groupBoxDetails.Visible = false;
            pictureBoxHouse.Visible = false;
            richTextDescription.Text = "Select a listing to view description.";
            btnShowAgent.Visible = false;
            btnShowMap.Visible = false;
        }
        private void dataGridHouseListings_CellContentClick(object sender, DataGridViewCellEventArgs e)  //  Triggered when user clicks a cell in the data grid
        {
            int row = e.RowIndex;  //  Holds the index of the data grid row the user clicked on. The index is used to change form labels to display details for selected house
            if (dataGridHouseListings.DataSource == houseListing)  //  Determine if houseListing list is currently displayed
            {
                lblMLSNum.Text = $"MLS #: {houseListing[row].MLS}";
                lblPrice.Text = $"Price: {houseListing[row].Price:C0}";
                lblArea.Text = $"Area: {houseListing[row].Area}";
                lblBed.Text = $"Bed: {houseListing[row].Bed}";
                lblBath.Text = $"Bath: {houseListing[row].Bath}";
                lblAddress.Text = $"Address: {houseListing[row].Street}, {houseListing[row].City}, " +
                    $"{houseListing[row].State}, {houseListing[row].Zip}";
                richTextDescription.Text = houseListing[row].Description;
                var agent = agentCRUD.GetAgentById(houseListing[row].AgentID);  //  Create temp agent and populate with agent info from DB based on Agent ID of selected house
                name = agent.Name;  //  Set agent info strings
                phone = agent.Phone;
                email = agent.Email;
                pictureBoxHouse.Image = new Bitmap(houseListing[row].PictureFileName);  //  Generate bitmap from picture filename of selected house and display in picture box 
                string street = houseListing[row].Street;  //  Strings for passing address info to maps url builder
                string city = houseListing[row].City;
                string state = houseListing[row].State;
                string zip = houseListing[row].Zip.ToString();
                mapUrl = BuildMapsUrl(street, city,state, zip);  //  Generate a Google Maps url string for selected house
                pictureBoxHouse.Visible = true;  //  Shows picture box with current house's picture
                btnShowAgent.Visible = true;  //  Gives user option to view agent info for selected house
                groupBoxDetails.Visible = true;  //  Displays info for selected house
                btnShowMap.Visible = true;  //  Gives user option to view selected house on Google Maps using default browser
            }
            if (dataGridHouseListings.DataSource == houseSearch)
            {
                lblMLSNum.Text = $"MLS #: {houseSearch[row].MLS}";
                lblPrice.Text = $"Price: {houseSearch[row].Price:C0}";
                lblArea.Text = $"Area: {houseSearch[row].Area}";
                lblBed.Text = $"Bed: {houseSearch[row].Bed}";
                lblBath.Text = $"Bath: {houseSearch[row].Bath}";
                lblAddress.Text = $"Address: {houseSearch[row].Street}, {houseSearch[row].City}, " +
                    $"{houseSearch[row].State}, {houseSearch[row].Zip}";
                richTextDescription.Text = houseSearch[row].Description;
                var agent = agentCRUD.GetAgentById(houseSearch[row].AgentID);
                name = agent.Name;
                phone = agent.Phone;
                email = agent.Email;
                pictureBoxHouse.Image = new Bitmap(houseSearch[row].PictureFileName);
                string street = houseSearch[row].Street;
                string city = houseSearch[row].City;
                string state = houseSearch[row].State;
                string zip = houseSearch[row].Zip.ToString();
                mapUrl = BuildMapsUrl(street, city, state, zip);
                pictureBoxHouse.Visible = true;
                btnShowAgent.Visible = true;
                groupBoxDetails.Visible = true;
                btnShowMap.Visible = true;
            }  //  Same as above if data grid is displaying houseSearch list
            if (dataGridHouseListings.DataSource == houseFiltered)
            {
                lblMLSNum.Text = $"MLS #: {houseFiltered[row].MLS}";
                lblPrice.Text = $"Price: {houseFiltered[row].Price:C0}";
                lblArea.Text = $"Area: {houseFiltered[row].Area}";
                lblBed.Text = $"Bed: {houseFiltered[row].Bed}";
                lblBath.Text = $"Bath: {houseFiltered[row].Bath}";
                lblAddress.Text = $"Address: {houseFiltered[row].Street}, {houseFiltered[row].City}, " +
                    $"{houseFiltered[row].State}, {houseFiltered[row].Zip}";
                richTextDescription.Text = houseFiltered[row].Description;
                var agent = agentCRUD.GetAgentById(houseFiltered[row].AgentID);
                name = agent.Name;
                phone = agent.Phone;
                email = agent.Email;
                pictureBoxHouse.Image = new Bitmap(houseFiltered[row].PictureFileName);
                string street = houseFiltered[row].Street;
                string city = houseFiltered[row].City;
                string state = houseFiltered[row].State;
                string zip = houseFiltered[row].Zip.ToString();
                mapUrl = BuildMapsUrl(street, city, state, zip);
                pictureBoxHouse.Visible = true;
                btnShowAgent.Visible = true;
                groupBoxDetails.Visible = true;
                btnShowMap.Visible = true;

            }  //  Same as above if data grid is displaying houseFiltered list
        }
        private void btnShowMap_Click(object sender, EventArgs e)  //  Open default browser and display selected house in Google Maps
        {
            try
            { Process.Start(mapUrl); }  //  Pass Google Maps url for selected house to default browser
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAgent_Click(object sender, EventArgs e)  //  Shows a message box with agent details for selected house
        {
            MessageBox.Show($"The listing agent for this home is:\n\n{name}\n\n{phone}\n\n{email}");
        }

        private void txtMLS_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtMLS.Text != String.Empty)
            {
                bool MLSnum = int.TryParse(txtMLS.Text, out int result);
                if (MLSnum == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtMLS.Clear();
                }
            }
        }

        private void btnSearchMLS_Click(object sender, EventArgs e)  //  Search houses for matching MLS and display in data grid
        {
            houseSearch.Clear();  //  Clear any previous searches from search list
            int mls = int.Parse(txtMLS.Text);
            foreach (House house in houseListing)  //  Search houseListings list for match and add match to houseSearch list
            {
                if (house.MLS == mls)
                {
                    houseSearch.Add(house);
                }
            }
            if (houseSearch.Count > 0)  //  If match is added to houseSearch list, change data grid to display houseSearch list
            {
                dataGridHouseListings.DataSource = null;
                dataGridHouseListings.DataSource = houseSearch;
                HideHouseGridColumns();
                ResetFormFields();
            }
            else  //  If no match is found, display message box
            {
                MessageBox.Show("The MLS # was not found!");
            }
            txtMLS.Clear();  //  
        }
        private void btnFilterClear_Click(object sender, EventArgs e)  //  Reset filter settings to All
        {
            ResetFormFields();
        }

        private void btnAgentLogin_Click(object sender, EventArgs e)  //  Create and show Agent Login form, close Client Portal form
        {
            AgentLogin agentLogin = new AgentLogin();
            agentLogin.Show();
            this.Close();
        }
        private void btnSaveSelected_Click(object sender, EventArgs e)  //  Save selected house info to txt file
        {
            int index = dataGridHouseListings.CurrentRow.Index;  //  Temp variable to hold index of selected row
            House saveHouse = new House();  //  Temp house to hold info for selected house
            if (dataGridHouseListings.DataSource == houseListing)  //  If houseListing is displayed in data grid, use info from houseListing list
            {
                saveHouse = houseListing[index];  //  Set temp house to house at the selected index in houseListing list
            }
            if (dataGridHouseListings.DataSource == houseFiltered)  //  Same as above for houseFiltered list
            {
                saveHouse = houseFiltered[index];
            }
            if (dataGridHouseListings.DataSource == houseSearch)  //  Same as above for houseSearch list
            {
                saveHouse = houseSearch[index];
            }
            string filename = "SavedHouses";  //  Set name for text file
            string path = @"C:\SavedHouses\";  //  Set location to save text file
            string tempfile = $"{path}{filename}.txt";  //  Full filename for text file
            StreamWriter streamWriter = null;  //  Use Stream Writer to generate text file
            try
            {
                if (!File.Exists(tempfile))  //  If no file exists, create one
                {
                    streamWriter = File.CreateText(tempfile);  //  Create new text file and add house information in readable format
                    streamWriter.WriteLine($"Address: {saveHouse.Street}, {saveHouse.City}, {saveHouse.State} {saveHouse.Zip}");
                    streamWriter.WriteLine($"MLS: {saveHouse.MLS}\nPrice: {saveHouse.Price:C0}");
                    streamWriter.WriteLine($"{saveHouse.Area} square feet, {saveHouse.Bed} bedroom, {saveHouse.Bath} bath.");
                    streamWriter.WriteLine($"\n{saveHouse.Description}\n");
                    MessageBox.Show("A new file has been created!");
                }
                else  //  If file exists, add selected house's information in readable format
                {
                    File.AppendAllText(tempfile, $"Address: {saveHouse.Street}, {saveHouse.City}, {saveHouse.State} {saveHouse.Zip}\n" +
                        $"MLS: {saveHouse.MLS}\nPrice: {saveHouse.Price:C0}\n{saveHouse.Area} square feet, {saveHouse.Bed} bedroom, {saveHouse.Bath} bath." +
                        $"\n\n{saveHouse.Description}\n");
                    MessageBox.Show("File updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (streamWriter != null)  //  Close stream writer if it was used. Avoids object null exception if file already exists.
                    streamWriter.Close();
            }
        }

        private void btnFilterSave_Click(object sender, EventArgs e)  //  Save info for houses in houseFiltered list to text file
        {
            string filename = "FilteredHouses";  //  Set name for text file
            string path = @"C:\SavedHouses\";  //  Set location to save text file
            string tempfile = $"{path}{filename}.txt";  //  Full filename for text file
            StreamWriter streamWriter = null;  //  Use Stream Writer to generate text file
            try
            {
                if (!File.Exists(tempfile))  //  If no file exists, create one
                {
                    streamWriter = File.CreateText(tempfile);  //  Create new text file and add each house's information in readable format
                    foreach (var house in houseFiltered)  //  Add info for each house in the houseFiltered list
                    {
                        streamWriter.WriteLine($"Address: {house.Street}, {house.City}, {house.State} {house.Zip}");
                        streamWriter.WriteLine($"MLS: {house.MLS}\nPrice: {house.Price:C0}");
                        streamWriter.WriteLine($"{house.Area} square feet, {house.Bed} bedroom, {house.Bath} bath.");
                        streamWriter.WriteLine($"\n{house.Description}\n");
                    }
                    MessageBox.Show("A new file has been created!");
                }
                else  //  If file exists, add each house's information in readable format
                {
                    foreach (var house in houseFiltered)  //  Add info for each house in the houseFiltered list
                    {
                        File.AppendAllText(tempfile, $"Address: {house.Street}, {house.City}, {house.State} {house.Zip}\n" +
                            $"MLS: {house.MLS}\nPrice: {house.Price:C0}\n{house.Area} square feet, {house.Bed} bedroom, {house.Bath} bath." +
                            $"\n\n{house.Description}\n\n");
                    }
                    MessageBox.Show("File updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (streamWriter != null)  //  Close stream writer if it was used. Avoids object null exception if file already exists.
                    streamWriter.Close();
            }
        }

        private void btnFilterApply_Click(object sender, EventArgs e)  //  Generate and display a list of houses in data grid that match selected filters
        {
            houseFiltered.Clear();  //  Clear any previous filtered list
            int pricecat = comboBoxPrice.SelectedIndex;  //  Variables to hold user selections
            int areacat = comboBoxArea.SelectedIndex;
            int bed = comboBoxBed.SelectedIndex;
            int bath = comboBoxBath.SelectedIndex;
            string city = comboBoxCity.SelectedValue.ToString();
            //  Series of if statements for all possible combinations of filter settings. If combo box selected index is 0, user has not selected that filter.
            //  If user selects something other than "All" in a combo box, then each house in houseListing list will be compared for a matching value and added to houseFiltered list
            //00000
            if (pricecat != 0 && areacat != 0 && bed != 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing) 
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bed == bed && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00001
            if (pricecat != 0 && areacat != 0 && bed != 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bed == bed && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00010
            if (pricecat != 0 && areacat != 0 && bed != 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bed == bed && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00011
            if (pricecat != 0 && areacat != 0 && bed != 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bed == bed)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00100
            if (pricecat != 0 && areacat != 0 && bed == 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00101
            if (pricecat != 0 && areacat != 0 && bed == 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00110
            if (pricecat != 0 && areacat != 0 && bed == 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //00111
            if (pricecat != 0 && areacat != 0 && bed == 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.AreaCat == areacat)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01000
            if (pricecat != 0 && areacat == 0 && bed != 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bed == bed && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01001
            if (pricecat != 0 && areacat == 0 && bed != 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bed == bed && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01010
            if (pricecat != 0 && areacat == 0 && bed != 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bed == bed && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01011
            if (pricecat != 0 && areacat == 0 && bed != 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bed == bed)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01100
            if (pricecat != 0 && areacat == 0 && bed == 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01101
            if (pricecat != 0 && areacat == 0 && bed == 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01110
            if (pricecat != 0 && areacat == 0 && bed == 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat  && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //01111
            if (pricecat != 0 && areacat == 0 && bed == 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.PriceCat == pricecat)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10000
            if (pricecat == 0 && areacat != 0 && bed != 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bed == bed && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10001
            if (pricecat == 0 && areacat != 0 && bed != 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bed == bed && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10010
            if (pricecat == 0 && areacat != 0 && bed != 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bed == bed && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10011
            if (pricecat == 0 && areacat != 0 && bed != 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bed == bed)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10100
            if (pricecat == 0 && areacat != 0 && bed == 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10101
            if (pricecat == 0 && areacat != 0 && bed == 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10110
            if (pricecat == 0 && areacat != 0 && bed == 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //10111
            if (pricecat == 0 && areacat != 0 && bed == 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.AreaCat == areacat)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11000
            if (pricecat == 0 && areacat == 0 && bed != 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bed == bed && house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11001
            if (pricecat == 0 && areacat == 0 && bed != 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bed == bed && house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11010
            if (pricecat == 0 && areacat == 0 && bed != 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bed == bed && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11011
            if (pricecat == 0 && areacat == 0 && bed != 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bed == bed)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11100
            if (pricecat == 0 && areacat == 0 && bed == 0 && bath != 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bath == bath && house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11101
            if (pricecat == 0 && areacat == 0 && bed == 0 && bath != 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.Bath == bath)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11110
            if (pricecat == 0 && areacat == 0 && bed == 0 && bath == 0 && city != "All")
            {
                foreach (House house in houseListing)
                {
                    if (house.City == city)
                    {
                        houseFiltered.Add(house);
                    }
                }
            }
            //11111
            if (pricecat == 0 && areacat == 0 && bed == 0 && bath == 0 && city == "All")
            {
                foreach (House house in houseListing)
                {
                     houseFiltered.Add(house);
                }
            }
            btnFilterSave.Visible = true;  //  Once the houseFilted list is populated, the user can save the contents to a text file
            dataGridHouseListings.DataSource = null;
            dataGridHouseListings.DataSource = houseFiltered;  //  Sets the data grid to display the list of filtered houses
            HideHouseGridColumns();
            ResetFormFields();
        }
    }
}
