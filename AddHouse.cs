using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MLSApp
{
    public partial class AddHouse : Form
    {
        string path;  //  String to hold a filepath
        string filename;  //  String to hold a filename
        byte[] pictureArray;  //  Byte array to hold picture in the DB
        HouseCRUD houseCRUD;
        public AddHouse()
        {
            InitializeComponent();
        }

        private void AddHouse_Load(object sender, EventArgs e)
        {
            lblFileName.Text = "Picture";  //  Display "Picture" until a picture file is selected by user
            houseCRUD = new HouseCRUD();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)  //  Open File Dialog, show selected picture in picture box, and generate byte array for DB
        {
            try
            {
                if(openPictureFileDialog.ShowDialog() == DialogResult.OK)  //  When user selects a picture file, get the filepath and set variables
                {
                    if(openPictureFileDialog.CheckFileExists)
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
            ConvertPicture();  //  Covert selected file to byte array for DB
        }
        void ConvertPicture()
        {
            if (pictureBoxHouse.Image != null)  //  Make sure an image was selected
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);  //  Read selected picture file
                pictureArray = new byte[fileStream.Length];  //  Create byte array of correct size
                fileStream.Read(pictureArray, 0, pictureArray.Length);  //  Populate byte array with picture info
                fileStream.Close();  //  Dispose resource
            }
        }

        private void btnAddHouseSubmit_Click(object sender, EventArgs e)  //  Add new house to DB
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtArea.Text) && 
                !string.IsNullOrEmpty(txtStreet.Text) && !string.IsNullOrEmpty(txtCity.Text) && 
                !string.IsNullOrEmpty(txtZip.Text) && !string.IsNullOrEmpty(richTextDescription.Text) &&
                !string.IsNullOrEmpty(txtBed.Text) && !string.IsNullOrEmpty(txtBath.Text) && 
                comboBoxState.SelectedIndex != -1 && pictureArray != null)  //  Check fields for data
            {
                var newHouse = new House();  //  Temp house to hold new house data
                newHouse.MLS = (houseCRUD.GetMaxMLS() + 1);  //  Generate unique MLS by adding one to the max existing MLS number
                newHouse.Price = int.Parse(txtPrice.Text);
                newHouse.PriceCat = houseCRUD.GetPriceCat(int.Parse(txtPrice.Text));  //  Set Price Cat based on Price text box
                newHouse.Area = int.Parse(txtArea.Text);
                newHouse.AreaCat = houseCRUD.GetAreaCat(int.Parse(txtArea.Text));  //  Set Area Cat based on Area text box
                newHouse.Bed = int.Parse(txtBed.Text);
                newHouse.Bath = int.Parse(txtBath.Text);
                newHouse.Street = txtStreet.Text;
                newHouse.City = txtCity.Text;
                newHouse.State = (string)comboBoxState.SelectedItem;  //  Convert selected state in comboBox to string
                newHouse.Zip = int.Parse(txtZip.Text);
                newHouse.Description = richTextDescription.Text;
                newHouse.AgentID = CurrentAgent.currentAgent.CurrentAgentId;  //  Set Agent ID to the CurrentAgentId that was set when the agent logged in
                newHouse.Picture = pictureArray;  //  Set Picture property to the temp byte array
                newHouse.PictureFileName = lblFileName.Text;
                houseCRUD.AddHouse(newHouse);  //  Pass temp house to AddHouse function to save info to DB
                AgentPortal agentPortal = new AgentPortal();  //  Create and show Agent Portal form, close Add House form
                agentPortal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields and don't forget to add a picture!");
            }
        }
        private void Clear()  //  Method to clear text boxes and temp variables
        {
            txtArea.Clear();
            txtBed.Clear();
            txtCity.Clear();
            txtArea.Clear();
            txtBath.Clear();
            txtStreet.Clear();
            txtZip.Clear();
            richTextDescription.Clear();
            pictureArray = null;
            filename = null;
            path = null;
            lblFileName.Text = "Picture";
        }

        private void btnCloseForm_Click(object sender, EventArgs e)  //  Create and show Agent Portal form, close Add House form without adding house to DB
        {
            AgentPortal agentPortal = new AgentPortal();
            agentPortal.Show();
            this.Close();

        }

        private void btnClearForm_Click(object sender, EventArgs e)  //  Clear text boxes and temp variables
        {
            Clear();
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
