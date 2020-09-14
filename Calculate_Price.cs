using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    public partial class Calculate_Price : Form
    {
        //connecting the database
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");

        public static string PassingText1;
        public Calculate_Price()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("White Tulips");
            comboBox1.Items.Add("Roses Classic");
            comboBox1.Items.Add("Forever Love");
            comboBox1.Items.Add("Orient Bouquet");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Yellow Gebera");
            comboBox1.Items.Add("White Gebera");
            comboBox1.Items.Add("Red Love");
            comboBox1.Items.Add("Love Rings");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Green;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Green;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Green;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Green;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Green;
            radioButton9.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            radioButton6.ForeColor = System.Drawing.Color.Red;
            radioButton7.ForeColor = System.Drawing.Color.Red;
            radioButton8.ForeColor = System.Drawing.Color.Red;
            radioButton9.ForeColor = System.Drawing.Color.Green;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            connection.Open();

            string selectQuery = "SELECT * FROM floral_shop_db.ex5 WHERE productName = '" + comboBox1.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader MDR;


            try
            {
                MDR = command.ExecuteReader();
                if (MDR.Read())
                {
                    textBox3.Text = MDR.GetString("proPrice");

                }
                else
                {
                    textBox3.Text = "";
                    comboBox1.Text = "";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
         {
             //Validate the price
             string cont = "^([0-9]{2,10})$";
             if (Regex.IsMatch(textBox3.Text, cont))
             {
                 errorProvider1.Clear();
             }
             else
             {
                 errorProvider1.SetError(this.textBox3, "Please enter a valid price");
                 return;
             }

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Validate the quantity
            string cont = "^([0-9]{1,2})$";
            if (Regex.IsMatch(textBox2.Text, cont))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.textBox2, "Please enter a valid price");
                return;
            }
            if (textBox2.Text.Length > 0)
            {
                textBox5.Text = (Convert.ToInt16(textBox3.Text) * Convert.ToInt16(textBox2.Text)).ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Validate the amount
            string cont = "^([0-9]{2,10})$";
            if (Regex.IsMatch(textBox3.Text, cont))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox3, "Please enter a valid price");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate null values in fields
            if (comboBox1.Text == "")
            {

                comboBox1.BackColor = Color.LightPink;
                MessageBox.Show("Product is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {

                textBox2.BackColor = Color.LightPink;
                MessageBox.Show("Price is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {

                textBox3.BackColor = Color.LightPink;
                MessageBox.Show("Quantity is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }

            if (textBox5.Text == "")
            {

                textBox5.BackColor = Color.LightPink;
                MessageBox.Show("Amount is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Focus();
                return;
            }


            try
            {

                string[] arr = new string[4];
                arr[0] = comboBox1.SelectedItem.ToString();
                arr[1] = textBox3.Text;
                arr[2] = textBox2.Text;
                arr[3] = textBox5.Text;

                ListViewItem lvi = new ListViewItem(arr);

                listView1.Items.Add(lvi);

                textBox6.Text = (Convert.ToInt16(textBox6.Text) + Convert.ToInt16(textBox5.Text)).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //remove an item
                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            textBox6.Text = (Convert.ToInt16(textBox6.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                            listView1.Items[i].Remove();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassingText1 = textBox6.Text;
            OrderNow on = new OrderNow();
            on.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductView_main me = new ProductView_main();
            me.ShowDialog();
        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
