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
    public partial class MakeLeave : Form
    {
        public MakeLeave()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tbID.Text);
            DateTime LDate = dtpDate.Value;


            EMPLOYEE emp = new EMPLOYEE();

            if (emp.makeLeave(ID, LDate))
            {
                MessageBox.Show("Leave made successfully", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MaterialEmail mat = new MaterialEmail();
                mat.ShowDialog();
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public static implicit operator MakeLeave(EditEmployee v)
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
