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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;


namespace AmalkaFlora
{
    public partial class Pro_Discount : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Pro_Discount()
        {
            InitializeComponent();
        }
        int a;
        double  c;
        double b;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp ms = new ManageEmp();
            ms.ShowDialog();
        }

        private void btnSelectPro_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  * FROM floral_shop_db.ex5 WHERE `productID`= '" + tbID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;

            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    tbname.Text = mdr.GetString("productName");

                    comboBox1.Text = mdr.GetString("category");
                    tbPrice.Text = mdr.GetString("proPrice");


                }
                else

                {
                    MessageBox.Show("No Data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void btnCalprice_Click(object sender, EventArgs e)
        {
            a = int.Parse(tbPrice.Text);
            b = double.Parse(tbDis.Text);
            

            if (a > 1000)
            {
                b = (a * 0.08);
                c = a - b;
                tbfinalprice.Text = c.ToString();
            }
            else
            {
                b = (a * 0.1);
                c = a - b;
                tbfinalprice.Text = c.ToString();
            }


        }

        private void Pro_Discount_Load(object sender, EventArgs e)
        {

        }
    }
    }

