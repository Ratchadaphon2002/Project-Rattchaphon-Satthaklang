namespace Project_Nik
{
    partial class cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart));
            this.cartDt = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToPd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.holderName = new System.Windows.Forms.TextBox();
            this.visaNum = new System.Windows.Forms.TextBox();
            this.getPhone = new System.Windows.Forms.TextBox();
            this.getAdress = new System.Windows.Forms.TextBox();
            this.getRealName = new System.Windows.Forms.TextBox();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cartDt)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDt
            // 
            this.cartDt.AllowUserToAddRows = false;
            this.cartDt.AllowUserToDeleteRows = false;
            this.cartDt.AllowUserToResizeColumns = false;
            this.cartDt.AllowUserToResizeRows = false;
            this.cartDt.BackgroundColor = System.Drawing.Color.White;
            this.cartDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product,
            this.color,
            this.count,
            this.price,
            this.email});
            this.cartDt.GridColor = System.Drawing.Color.DarkGreen;
            this.cartDt.Location = new System.Drawing.Point(32, 222);
            this.cartDt.Margin = new System.Windows.Forms.Padding(4);
            this.cartDt.Name = "cartDt";
            this.cartDt.RowHeadersVisible = false;
            this.cartDt.RowHeadersWidth = 51;
            this.cartDt.Size = new System.Drawing.Size(590, 290);
            this.cartDt.TabIndex = 6;
            this.cartDt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDt_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "สินค้า";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 200;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "สี";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.color.Width = 125;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "จำนวน";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count.Width = 80;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคา";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Visible = false;
            this.email.Width = 125;
            // 
            // btnBackToPd
            // 
            this.btnBackToPd.Location = new System.Drawing.Point(43, 571);
            this.btnBackToPd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToPd.Name = "btnBackToPd";
            this.btnBackToPd.Size = new System.Drawing.Size(115, 32);
            this.btnBackToPd.TabIndex = 1;
            this.btnBackToPd.Text = "ย้อนกลับ";
            this.btnBackToPd.UseVisualStyleBackColor = true;
            this.btnBackToPd.Click += new System.EventHandler(this.btnBackToPd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Visa Holder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Visa Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "โทรศัพท์  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "ที่อยู่ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "ชื่อ - สกุล :";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Snow;
            this.btnInsert.Location = new System.Drawing.Point(959, 476);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 36);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "จ่ายทั้งหมด";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // holderName
            // 
            this.holderName.Location = new System.Drawing.Point(773, 395);
            this.holderName.Margin = new System.Windows.Forms.Padding(4);
            this.holderName.Name = "holderName";
            this.holderName.Size = new System.Drawing.Size(356, 22);
            this.holderName.TabIndex = 4;
            // 
            // visaNum
            // 
            this.visaNum.Location = new System.Drawing.Point(773, 337);
            this.visaNum.Margin = new System.Windows.Forms.Padding(4);
            this.visaNum.Name = "visaNum";
            this.visaNum.Size = new System.Drawing.Size(356, 22);
            this.visaNum.TabIndex = 3;
            // 
            // getPhone
            // 
            this.getPhone.Location = new System.Drawing.Point(772, 279);
            this.getPhone.Margin = new System.Windows.Forms.Padding(4);
            this.getPhone.Name = "getPhone";
            this.getPhone.Size = new System.Drawing.Size(356, 22);
            this.getPhone.TabIndex = 2;
            // 
            // getAdress
            // 
            this.getAdress.Location = new System.Drawing.Point(772, 222);
            this.getAdress.Margin = new System.Windows.Forms.Padding(4);
            this.getAdress.Name = "getAdress";
            this.getAdress.Size = new System.Drawing.Size(356, 22);
            this.getAdress.TabIndex = 1;
            // 
            // getRealName
            // 
            this.getRealName.Location = new System.Drawing.Point(772, 164);
            this.getRealName.Margin = new System.Windows.Forms.Padding(4);
            this.getRealName.Name = "getRealName";
            this.getRealName.Size = new System.Drawing.Size(356, 22);
            this.getRealName.TabIndex = 0;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(839, 476);
            this.btnDelItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(108, 36);
            this.btnDelItem.TabIndex = 32;
            this.btnDelItem.Text = "ลบ";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Nik.Properties.Resources.สีแดง_ไล่โทนสี_เรียบง่าย_ต้นแบบ_UI_เว็บไซต์_หน้าแลนดิ้งเถจ_บล็อก_UI__11_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 623);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.holderName);
            this.Controls.Add(this.visaNum);
            this.Controls.Add(this.getPhone);
            this.Controls.Add(this.getAdress);
            this.Controls.Add(this.getRealName);
            this.Controls.Add(this.btnBackToPd);
            this.Controls.Add(this.cartDt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1161, 670);
            this.MinimumSize = new System.Drawing.Size(1161, 670);
            this.Name = "cart";
            this.Text = "cart";
            this.Load += new System.EventHandler(this.cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDt;
        private System.Windows.Forms.Button btnBackToPd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox holderName;
        private System.Windows.Forms.TextBox visaNum;
        private System.Windows.Forms.TextBox getPhone;
        private System.Windows.Forms.TextBox getAdress;
        private System.Windows.Forms.TextBox getRealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnDelItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}