namespace AmalkaFlora
{
    partial class EmpSal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpSal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectEmp = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbnic = new System.Windows.Forms.TextBox();
            this.tbsal = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblempType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLeave = new System.Windows.Forms.TextBox();
            this.lblleaves = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbal = new System.Windows.Forms.TextBox();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.tbfinalsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalSal = new System.Windows.Forms.Button();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSelectEmp
            // 
            this.btnSelectEmp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSelectEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEmp.Location = new System.Drawing.Point(420, 112);
            this.btnSelectEmp.Name = "btnSelectEmp";
            this.btnSelectEmp.Size = new System.Drawing.Size(186, 31);
            this.btnSelectEmp.TabIndex = 58;
            this.btnSelectEmp.Text = "Select Employee";
            this.btnSelectEmp.UseVisualStyleBackColor = false;
            this.btnSelectEmp.Click += new System.EventHandler(this.btnSelectEmp_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(220, 112);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(81, 20);
            this.tbID.TabIndex = 57;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Admin",
            "Delivery Employee",
            "Decorator",
            "Boquets Creater"});
            this.comboBox1.Location = new System.Drawing.Point(220, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 55;
            // 
            // tbnic
            // 
            this.tbnic.Location = new System.Drawing.Point(220, 286);
            this.tbnic.Name = "tbnic";
            this.tbnic.Size = new System.Drawing.Size(344, 20);
            this.tbnic.TabIndex = 52;
            // 
            // tbsal
            // 
            this.tbsal.Location = new System.Drawing.Point(220, 246);
            this.tbsal.Name = "tbsal";
            this.tbsal.Size = new System.Drawing.Size(344, 20);
            this.tbsal.TabIndex = 51;
            this.tbsal.TextChanged += new System.EventHandler(this.tbsal_TextChanged);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(220, 158);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(344, 20);
            this.tbname.TabIndex = 47;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(36, 286);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(33, 16);
            this.lblNIC.TabIndex = 46;
            this.lblNIC.Text = "NIC";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(36, 250);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(53, 16);
            this.lblSal.TabIndex = 44;
            this.lblSal.Text = "Salary";
            this.lblSal.Click += new System.EventHandler(this.lblSal_Click);
            // 
            // lblempType
            // 
            this.lblempType.AutoSize = true;
            this.lblempType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempType.Location = new System.Drawing.Point(36, 208);
            this.lblempType.Name = "lblempType";
            this.lblempType.Size = new System.Drawing.Size(118, 16);
            this.lblempType.TabIndex = 43;
            this.lblempType.Text = "Employee Type";
            this.lblempType.Click += new System.EventHandler(this.lblempType_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 162);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(580, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 31);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLeave
            // 
            this.tbLeave.Location = new System.Drawing.Point(220, 328);
            this.tbLeave.Name = "tbLeave";
            this.tbLeave.Size = new System.Drawing.Size(344, 20);
            this.tbLeave.TabIndex = 60;
            // 
            // lblleaves
            // 
            this.lblleaves.AutoSize = true;
            this.lblleaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblleaves.Location = new System.Drawing.Point(36, 332);
            this.lblleaves.Name = "lblleaves";
            this.lblleaves.Size = new System.Drawing.Size(136, 16);
            this.lblleaves.TabIndex = 59;
            this.lblleaves.Text = "Number Of Leaves";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 34);
            this.btnBack.TabIndex = 65;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbal
            // 
            this.tbal.Location = new System.Drawing.Point(220, 379);
            this.tbal.Name = "tbal";
            this.tbal.Size = new System.Drawing.Size(344, 20);
            this.tbal.TabIndex = 67;
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowance.Location = new System.Drawing.Point(36, 379);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(79, 16);
            this.lblAllowance.TabIndex = 66;
            this.lblAllowance.Text = "Allowance";
            // 
            // tbfinalsal
            // 
            this.tbfinalsal.Location = new System.Drawing.Point(220, 481);
            this.tbfinalsal.Name = "tbfinalsal";
            this.tbfinalsal.Size = new System.Drawing.Size(344, 20);
            this.tbfinalsal.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Final Salary";
            // 
            // btnCalSal
            // 
            this.btnCalSal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalSal.Location = new System.Drawing.Point(113, 428);
            this.btnCalSal.Name = "btnCalSal";
            this.btnCalSal.Size = new System.Drawing.Size(336, 31);
            this.btnCalSal.TabIndex = 70;
            this.btnCalSal.Text = "Calculate Final Salary";
            this.btnCalSal.UseVisualStyleBackColor = false;
            this.btnCalSal.Click += new System.EventHandler(this.btnCalSal_Click);
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(1240, 15);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 72;
            this.btmMin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(1302, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 71;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // EmpSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalSal);
            this.Controls.Add(this.tbfinalsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbal);
            this.Controls.Add(this.lblAllowance);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbLeave);
            this.Controls.Add(this.lblleaves);
            this.Controls.Add(this.btnSelectEmp);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbnic);
            this.Controls.Add(this.tbsal);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblempType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "EmpSal";
            this.Text = "EmpSal";
            this.Load += new System.EventHandler(this.EmpSal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectEmp;
        internal System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox tbnic;
        internal System.Windows.Forms.TextBox tbsal;
        internal System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblempType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox tbLeave;
        private System.Windows.Forms.Label lblleaves;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.TextBox tbal;
        private System.Windows.Forms.Label lblAllowance;
        internal System.Windows.Forms.TextBox tbfinalsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalSal;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
    }
}