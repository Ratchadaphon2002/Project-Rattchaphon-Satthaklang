namespace Project_Nik
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.button2 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.labelNameOfItem = new System.Windows.Forms.Label();
            this.labelColorOfItem = new System.Windows.Forms.Label();
            this.labelPriceOfItem = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.countOfItem = new System.Windows.Forms.NumericUpDown();
            this.btnCartPage = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfItem)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(739, 580);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "ย้อนกลับ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.data.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.picture,
            this.productClmn,
            this.color,
            this.price,
            this.quantity});
            this.data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data.Location = new System.Drawing.Point(27, 262);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 30;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(629, 241);
            this.data.TabIndex = 12;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // showPic
            // 
            this.showPic.Image = global::Project_Nik.Properties.Resources._1;
            this.showPic.Location = new System.Drawing.Point(740, 162);
            this.showPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(323, 318);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPic.TabIndex = 13;
            this.showPic.TabStop = false;
            // 
            // labelNameOfItem
            // 
            this.labelNameOfItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameOfItem.AutoSize = true;
            this.labelNameOfItem.BackColor = System.Drawing.Color.ForestGreen;
            this.labelNameOfItem.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNameOfItem.Location = new System.Drawing.Point(744, 121);
            this.labelNameOfItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameOfItem.Name = "labelNameOfItem";
            this.labelNameOfItem.Size = new System.Drawing.Size(295, 28);
            this.labelNameOfItem.TabIndex = 14;
            this.labelNameOfItem.Text = "ผ้าไหมมัดหมี่ลายสร้อยดอกหมาก";
            // 
            // labelColorOfItem
            // 
            this.labelColorOfItem.AutoSize = true;
            this.labelColorOfItem.BackColor = System.Drawing.Color.DimGray;
            this.labelColorOfItem.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorOfItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelColorOfItem.Location = new System.Drawing.Point(735, 496);
            this.labelColorOfItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColorOfItem.Name = "labelColorOfItem";
            this.labelColorOfItem.Size = new System.Drawing.Size(109, 23);
            this.labelColorOfItem.TabIndex = 14;
            this.labelColorOfItem.Text = "สีเปลือกมังคุด";
            // 
            // labelPriceOfItem
            // 
            this.labelPriceOfItem.AutoSize = true;
            this.labelPriceOfItem.BackColor = System.Drawing.Color.DarkGreen;
            this.labelPriceOfItem.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceOfItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPriceOfItem.Location = new System.Drawing.Point(733, 539);
            this.labelPriceOfItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceOfItem.Name = "labelPriceOfItem";
            this.labelPriceOfItem.Size = new System.Drawing.Size(111, 23);
            this.labelPriceOfItem.TabIndex = 14;
            this.labelPriceOfItem.Text = "2400.00 บาท";
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(940, 580);
            this.btnCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(123, 38);
            this.btnCart.TabIndex = 15;
            this.btnCart.Text = "หยิบใส่ตะกร้า";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // countOfItem
            // 
            this.countOfItem.Location = new System.Drawing.Point(940, 522);
            this.countOfItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countOfItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countOfItem.Name = "countOfItem";
            this.countOfItem.Size = new System.Drawing.Size(123, 22);
            this.countOfItem.TabIndex = 16;
            this.countOfItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countOfItem.ValueChanged += new System.EventHandler(this.countOfItem_ValueChanged);
            // 
            // btnCartPage
            // 
            this.btnCartPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCartPage.Location = new System.Drawing.Point(56, 580);
            this.btnCartPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCartPage.Name = "btnCartPage";
            this.btnCartPage.Size = new System.Drawing.Size(116, 38);
            this.btnCartPage.TabIndex = 17;
            this.btnCartPage.Text = "ไปที่ตะกร้า";
            this.btnCartPage.UseVisualStyleBackColor = true;
            this.btnCartPage.Click += new System.EventHandler(this.btnCartPage_Click);
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
            // picture
            // 
            this.picture.DataPropertyName = "picture";
            this.picture.HeaderText = "PICTURE";
            this.picture.MinimumWidth = 6;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            this.picture.Visible = false;
            this.picture.Width = 125;
            // 
            // productClmn
            // 
            this.productClmn.DataPropertyName = "product";
            this.productClmn.HeaderText = "สินค้า";
            this.productClmn.MinimumWidth = 6;
            this.productClmn.Name = "productClmn";
            this.productClmn.ReadOnly = true;
            this.productClmn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productClmn.Width = 200;
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
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคา";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "จำนวน";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 633);
            this.Controls.Add(this.btnCartPage);
            this.Controls.Add(this.countOfItem);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.labelPriceOfItem);
            this.Controls.Add(this.labelColorOfItem);
            this.Controls.Add(this.labelNameOfItem);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.Label labelNameOfItem;
        private System.Windows.Forms.Label labelColorOfItem;
        private System.Windows.Forms.Label labelPriceOfItem;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.NumericUpDown countOfItem;
        private System.Windows.Forms.Button btnCartPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn productClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}