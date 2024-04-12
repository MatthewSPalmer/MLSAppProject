using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSApp
{
    public partial class UpdateHouse : Form
    {
        string path;  //  String to hold a filepath
        string filename;  //  String to hold a filename
        byte[] pictureArray;  //  Byte array to hold a new picture for the DB
        byte[] currentPictureArray;  //  Byte array to hold the current picture
        bool replacePicture = false;  //  Flag for whether or not current picture should be replaced in DB
        HouseCRUD houseCRUD;
        public UpdateHouse()
        {
            InitializeComponent();
        }

        private void UpdateHouse_Load(object sender, EventArgs e)
        {
            houseCRUD = new HouseCRUD();
            var house = houseCRUD.GetHouse(CurrentAgent.currentAgent.CurrentHouseMLS);  //  Create temp house from CurrentHouseMLS set in Agent Portal form
            txtPrice.Text = house.Price.ToString();  //  Set form field values to house that needs to be updated
            txtArea.Text = house.Area.ToString();
            txtBed.Text = house.Bed.ToString();
            txtBath.Text = house.Bath.ToString();
            txtStreet.Text = house.Street;
            txtCity.Text = house.City;
            comboBoxState.SelectedItem = house.State;
            txtZip.Text = house.Zip.ToString();
            richTextDescription.Text = house.Description;
            lblFileName.Text = house.PictureFileName;
            pictureBoxHouse.Image = new Bitmap(house.PictureFileName);  //  Generate a bitmap from filepath field and display it in picture box
            currentPictureArray = house.Picture;
            groupBoxDetails.Text = $"Details for MLS #: {house.MLS}";  //  Change group box lable to show MLS of house to update
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)  //  Remove picture from picture box
        {
            pictureBoxHouse.Image.Dispose();   
            pictureBoxHouse.Image = null;
            lblFileName.Text = "Picture";  
            btnAddPicture.Visible = true;  //  Allow user to add a new picture  
        }

        private void btnAddPicture_Click(object sender, EventArgs e)  //  Open File Dialog, show selected picture in picture box, and generate new byte array for DB
        {
            try
            {
                if (openPictureFileDialog.ShowDialog() == DialogResult.OK)  //  When user selects a picture file, get the filepath and set variables
                {
                    if (openPictureFileDialog.CheckFileExists)
                    {
                        path = System.IO.Path.GetFullPath(openPictureFileDialog.FileName);
                        pictureBoxHouse.Image = new Bitmap(openPictureFileDialog.FileName);  //  Generate a bitmap image from selected file and display in picture box
                        filename = openPictureFileDialog.FileName;
                        lblFileName.Text = filename;  //  Display filename to user

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConvertPicture();  //  Convert selected file to new byte array for DB
            replacePicture = true;  //  Set replace picture flag to indicate the current picture needs to be replaced with the new one
        }
        
        void ConvertPicture()
        {
            if (pictureBoxHouse.Image != null)  //  Make sure a new image was selected
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);  //  Read selected picture file
                pictureArray = new byte[fileStream.Length];  //  Create byte array of correct size
                fileStream.Read(pictureArray, 0, pictureArray.Length);  //  Populate byte array with picture info
                fileStream.Close();  //  Dispose resource
            }
        }

        private void btnUpdateHouseSubmit_Click(object sender, EventArgs e)  //  Update house info in DB
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtArea.Text) &&
                !string.IsNullOrEmpty(txtStreet.Text) && !string.IsNullOrEmpty(txtCity.Text) &&
                !string.IsNullOrEmpty(txtZip.Text) && !string.IsNullOrEmpty(richTextDescription.Text) &&
                !string.IsNullOrEmpty(txtBed.Text) && !string.IsNullOrEmpty(txtBath.Text) && pictureArray != null)  //  Check fields for data
            {
                var updateHouse = new House();  //  Temp house updated data to replace selected house in DB
                updateHouse.MLS = CurrentAgent.currentAgent.CurrentHouseMLS;
                updateHouse.Price = int.Parse(txtPrice.Text);
                updateHouse.PriceCat = houseCRUD.GetPriceCat(int.Parse(txtPrice.Text));  //  Set Price Cat based on Price text box
                updateHouse.Area = int.Parse(txtArea.Text);
                updateHouse.AreaCat = houseCRUD.GetAreaCat(int.Parse(txtArea.Text));  //  Set Area Cat based on Area text box
                updateHouse.Bed = int.Parse(txtBed.Text);
                updateHouse.Bath = int.Parse(txtBath.Text);
                updateHouse.Street = txtStreet.Text;
                updateHouse.City = txtCity.Text;
                updateHouse.State = (string)comboBoxState.SelectedItem;  //  Convert selected state in comboBox to string
                updateHouse.Zip = int.Parse(txtZip.Text);
                updateHouse.Description = richTextDescription.Text;
                updateHouse.AgentID = CurrentAgent.currentAgent.CurrentAgentId;
                if (replacePicture == false)  //  Set the picture information based on replacePicture flag
                {
                    updateHouse.Picture = currentPictureArray;
                }
                else  //  
                {
                    updateHouse.Picture = pictureArray;
                }
                updateHouse.PictureFileName = lblFileName.Text;
                houseCRUD.UpdateHouse(updateHouse.MLS,updateHouse);  //  Pass temp house to UpdateHouse fuction to update DB
                MessageBox.Show("Listing updated!");
                AgentPortal agentPortal = new AgentPortal();  //  Create and show Agent Portal form, close Update House form
                agentPortal.Show();
                this.Close();
            }
            else  //  
            {
                MessageBox.Show("Please fill out all fields and don't forget to add a picture!");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)  //  Create and show Agent Portal form, close Update House form without updating DB
        {
            AgentPortal agentPortal = new AgentPortal();
            agentPortal.Show();
            this.Close();
        }
       
        private void txtPrice_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtPrice.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtPrice.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtPrice.Clear();
                }
            }
        }
       
        private void txtArea_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtArea.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtArea.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtArea.Clear();
                }
            }
        }
        
        private void txtBed_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtBed.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtBed.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtBed.Clear();
                }
            }
        }
        
        private void txtBath_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtBath.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtBath.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtBath.Clear();
                }
            }
        }

        private void txtZip_TextChanged(object sender, EventArgs e)  //  In-line validation to prevent user from entering a non-digit character
        {
            if (txtZip.Text != String.Empty)
            {
                bool isDigit = int.TryParse(txtZip.Text, out int result);
                if (isDigit == false)
                {
                    MessageBox.Show("Please enter numbers only!");
                    txtZip.Clear();
                }
            }
        }
    }
}
