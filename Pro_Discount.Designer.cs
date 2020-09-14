namespace AmalkaFlora
{
    partial class Pro_Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pro_Discount));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btmMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalprice = new System.Windows.Forms.Button();
            this.tbfinalprice = new System.Windows.Forms.TextBox();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.tbDis = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectPro = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(393, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 119;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(209, 259);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 16);
            this.lblCategory.TabIndex = 118;
            this.lblCategory.Text = "Category";
            // 
            // btmMin
            // 
            this.btmMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmMin.BackgroundImage")));
            this.btmMin.Location = new System.Drawing.Point(1413, 112);
            this.btmMin.Name = "btmMin";
            this.btmMin.Size = new System.Drawing.Size(47, 50);
            this.btmMin.TabIndex = 117;
            this.btmMin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(1475, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 116;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCalprice
            // 
            this.btnCalprice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalprice.Location = new System.Drawing.Point(393, 486);
            this.btnCalprice.Name = "btnCalprice";
            this.btnCalprice.Size = new System.Drawing.Size(336, 31);
            this.btnCalprice.TabIndex = 115;
            this.btnCalprice.Text = "Calculate Final Price";
            this.btnCalprice.UseVisualStyleBackColor = false;
            this.btnCalprice.Click += new System.EventHandler(this.btnCalprice_Click);
            // 
            // tbfinalprice
            // 
            this.tbfinalprice.Location = new System.Drawing.Point(393, 549);
            this.tbfinalprice.Name = "tbfinalprice";
            this.tbfinalprice.Size = new System.Drawing.Size(344, 20);
            this.tbfinalprice.TabIndex = 114;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(209, 549);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(82, 16);
            this.lblFinalPrice.TabIndex = 113;
            this.lblFinalPrice.Text = "Final Price";
            // 
            // tbDis
            // 
            this.tbDis.Location = new System.Drawing.Point(393, 427);
            this.tbDis.Name = "tbDis";
            this.tbDis.Size = new System.Drawing.Size(344, 20);
            this.tbDis.TabIndex = 112;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(209, 431);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(68, 16);
            this.lblDiscount.TabIndex = 111;
            this.lblDiscount.Text = "Discount";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 34);
            this.btnBack.TabIndex = 110;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelectPro
            // 
            this.btnSelectPro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSelectPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPro.Location = new System.Drawing.Point(819, 209);
            this.btnSelectPro.Name = "btnSelectPro";
            this.btnSelectPro.Size = new System.Drawing.Size(186, 31);
            this.btnSelectPro.TabIndex = 109;
            this.btnSelectPro.Text = "Select Product";
            this.btnSelectPro.UseVisualStyleBackColor = false;
            this.btnSelectPro.Click += new System.EventHandler(this.btnSelectPro_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(393, 209);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(344, 20);
            this.tbID.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Product ID";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(393, 370);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(344, 20);
            this.tbPrice.TabIndex = 106;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(393, 312);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(344, 20);
            this.tbname.TabIndex = 105;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(209, 374);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(44, 16);
            this.lblSal.TabIndex = 104;
            this.lblSal.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(209, 312);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 103;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 42);
            this.label1.TabIndex = 102;
            this.label1.Text = "Calculate Discount";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(1247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 121;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1309, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 50);
            this.button2.TabIndex = 120;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Pro_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btmMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalprice);
            this.Controls.Add(this.tbfinalprice);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.tbDis);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectPro);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "Pro_Discount";
            this.Text = "Pro_Discount";
            this.Load += new System.EventHandler(this.Pro_Discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btmMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalprice;
        internal System.Windows.Forms.TextBox tbfinalprice;
        private System.Windows.Forms.Label lblFinalPrice;
        internal System.Windows.Forms.TextBox tbDis;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectPro;
        internal System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbPrice;
        internal System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}