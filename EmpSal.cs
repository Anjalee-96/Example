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
    public partial class EmpSal : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public EmpSal()
        {
            InitializeComponent();
        }
        //Creating Variables
        int a, b, c, d;
        
        private void EmpSal_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectEmp_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  * FROM floral_shop_db.ex3 WHERE `id`= '" + tbID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;



            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    tbname.Text = mdr.GetString("name");
                    
                    comboBox1.Text = mdr.GetString("empType");
                    tbsal.Text = mdr.GetString("sal");
                    //pbpic.Image = mdr.GetValue("photo");
                    tbnic.Text = mdr.GetString("nic");
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

        private void tbsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblempType_Click(object sender, EventArgs e)
        {

        }

        private void lblSal_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.ShowDialog();
        }

        private void btnCalSal_Click(object sender, EventArgs e)
        {
            a = int.Parse(tbsal.Text);
            b = int.Parse(tbLeave.Text);
            //d = int.Parse(tbfinalsal.Text);
            c = int.Parse(tbal.Text);

            if (b > 0) 
            {
                d = a - (b * 500);
                tbfinalsal.Text = d.ToString();
            }
            else
            {
                d = a;
                tbfinalsal.Text = d.ToString();
            }
            if(c>0)
            {
                d = d + c;
                tbfinalsal.Text = d.ToString();
            }
            else
            {
                d = d;
                tbfinalsal.Text = d.ToString();
            }
            
           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  COUNT(ID) FROM floral_shop_db.ex7 WHERE `ID`= '" + tbID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;
            



            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    

                    tbLeave.Text = mdr.GetValue(0).ToString();



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
    }
}
