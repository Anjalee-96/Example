using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AmalkaFlora
{
    public partial class AddFlowerItems : Form
    {
        public AddFlowerItems()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            //Select and display an image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbFlower.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddFlowerItems_Load(object sender, EventArgs e)
        {

        }
        //Button for add new product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FLOWERPRO product = new FLOWERPRO();
            

            string category = cbCat.Text;
            string productName = tbName.Text;
            int proPrice = Convert.ToInt32(tbPrice.Text);
            string description = tbDes.Text;

            try
            {
                if (verifFields("add"))
                {
                    //Get Image
                    MemoryStream image = new MemoryStream();
                    pbFlower.Image.Save(image, pbFlower.Image.RawFormat);

                    if (product.insertProduct(category, productName, proPrice, description, image))
                    {
                        MessageBox.Show("New Product is added", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
                else
                {
                    MessageBox.Show("Required Fields", "add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
        //Link with previous interface
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertUpdateDeleteFlower ms = new InsertUpdateDeleteFlower();
            ms.ShowDialog();
        }
        //Button for minimize the window
        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Button for close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            //Validate the price
            string cont = "^([0-9]{2,10})$";
            if (Regex.IsMatch(tbPrice.Text, cont))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbPrice, "Please enter a valid price");
                return;
            }

        }

        private void tbDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbFlower_Click(object sender, EventArgs e)
        {

        }
        //Create a function to check empty fields

        public bool verifFields(string operation)
        {
            bool check = false;

            //If the operation is register
            if (operation == "add")
            {
                if (cbCat.Text.Equals("") || tbName.Text.Equals("") || tbPrice.Text.Equals("") || tbDes.Text.Equals("") || pbFlower.Image == null)
                {
                    check = false;
                }

                else
                {
                    check = true;
                }
            }
            //if the operation is login
            else if (operation == "login")
            {
                if (tbDes.Text.Equals("") || tbName.Text.Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
