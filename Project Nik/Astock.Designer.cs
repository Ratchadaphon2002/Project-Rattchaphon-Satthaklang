namespace Project_Nik
{
    partial class Astock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astock));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnBack2Home = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.no_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxPrct = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.nmberQntity = new System.Windows.Forms.NumericUpDown();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nmberPrice = new System.Windows.Forms.NumericUpDown();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnOkAdd = new System.Windows.Forms.Button();
            this.labelAddressPic = new System.Windows.Forms.Label();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnOkEdit = new System.Windows.Forms.Button();
            this.tbxNewData = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.btnOkDel = new System.Windows.Forms.Button();
            this.panelDel = new System.Windows.Forms.Panel();
            this.btn_history = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmberQntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmberPrice)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(17, 371);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(134, 52);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnBack2Home
            // 
            this.btnBack2Home.Location = new System.Drawing.Point(13, 46);
            this.btnBack2Home.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack2Home.Name = "btnBack2Home";
            this.btnBack2Home.Size = new System.Drawing.Size(134, 49);
            this.btnBack2Home.TabIndex = 6;
            this.btnBack2Home.Text = "Back";
            this.btnBack2Home.UseVisualStyleBackColor = true;
            this.btnBack2Home.Click += new System.EventHandler(this.btnBack2Home_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 151);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_item,
            this.picture,
            this.id_item,
            this.product,
            this.color,
            this.price,
            this.quantity});
            this.dataHistory.Location = new System.Drawing.Point(158, 222);
            this.dataHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHistory.Size = new System.Drawing.Size(915, 377);
            this.dataHistory.TabIndex = 9;
            this.dataHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistory_CellClick);
            this.dataHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistory_CellContentClick);
            // 
            // no_item
            // 
            this.no_item.DataPropertyName = "No";
            this.no_item.HeaderText = "Column1";
            this.no_item.MinimumWidth = 6;
            this.no_item.Name = "no_item";
            this.no_item.ReadOnly = true;
            this.no_item.Visible = false;
            this.no_item.Width = 125;
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
            // id_item
            // 
            this.id_item.DataPropertyName = "id";
            this.id_item.HeaderText = "ID";
            this.id_item.MinimumWidth = 6;
            this.id_item.Name = "id_item";
            this.id_item.ReadOnly = true;
            this.id_item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_item.Visible = false;
            this.id_item.Width = 50;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "PRODUCT";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 250;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "COLOR";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 200;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // tbxPrct
            // 
            this.tbxPrct.Location = new System.Drawing.Point(16, 25);
            this.tbxPrct.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrct.Name = "tbxPrct";
            this.tbxPrct.Size = new System.Drawing.Size(301, 22);
            this.tbxPrct.TabIndex = 10;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(341, 26);
            this.tbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(169, 22);
            this.tbxColor.TabIndex = 12;
            // 
            // nmberQntity
            // 
            this.nmberQntity.Location = new System.Drawing.Point(741, 27);
            this.nmberQntity.Margin = new System.Windows.Forms.Padding(4);
            this.nmberQntity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmberQntity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmberQntity.Name = "nmberQntity";
            this.nmberQntity.Size = new System.Drawing.Size(160, 22);
            this.nmberQntity.TabIndex = 13;
            this.nmberQntity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 258);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 50);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nmberPrice
            // 
            this.nmberPrice.Location = new System.Drawing.Point(560, 26);
            this.nmberPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmberPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmberPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmberPrice.Name = "nmberPrice";
            this.nmberPrice.Size = new System.Drawing.Size(160, 22);
            this.nmberPrice.TabIndex = 15;
            this.nmberPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelAdd.Controls.Add(this.btnOkAdd);
            this.panelAdd.Controls.Add(this.labelAddressPic);
            this.panelAdd.Controls.Add(this.btnUploadPic);
            this.panelAdd.Controls.Add(this.nmberPrice);
            this.panelAdd.Controls.Add(this.nmberQntity);
            this.panelAdd.Controls.Add(this.tbxColor);
            this.panelAdd.Controls.Add(this.tbxPrct);
            this.panelAdd.Location = new System.Drawing.Point(160, 46);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(913, 121);
            this.panelAdd.TabIndex = 16;
            // 
            // btnOkAdd
            // 
            this.btnOkAdd.Location = new System.Drawing.Point(785, 66);
            this.btnOkAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkAdd.Name = "btnOkAdd";
            this.btnOkAdd.Size = new System.Drawing.Size(116, 38);
            this.btnOkAdd.TabIndex = 18;
            this.btnOkAdd.Text = "OK Add";
            this.btnOkAdd.UseVisualStyleBackColor = true;
            this.btnOkAdd.Click += new System.EventHandler(this.btnOkAdd_Click);
            // 
            // labelAddressPic
            // 
            this.labelAddressPic.AutoSize = true;
            this.labelAddressPic.Location = new System.Drawing.Point(145, 79);
            this.labelAddressPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddressPic.Name = "labelAddressPic";
            this.labelAddressPic.Size = new System.Drawing.Size(58, 16);
            this.labelAddressPic.TabIndex = 17;
            this.labelAddressPic.Text = "Address";
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Location = new System.Drawing.Point(16, 71);
            this.btnUploadPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(119, 28);
            this.btnUploadPic.TabIndex = 16;
            this.btnUploadPic.Text = "Choose Image";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelEdit.Controls.Add(this.btnOkEdit);
            this.panelEdit.Controls.Add(this.tbxNewData);
            this.panelEdit.Location = new System.Drawing.Point(158, 46);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(4);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(512, 121);
            this.panelEdit.TabIndex = 17;
            // 
            // btnOkEdit
            // 
            this.btnOkEdit.Location = new System.Drawing.Point(361, 39);
            this.btnOkEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkEdit.Name = "btnOkEdit";
            this.btnOkEdit.Size = new System.Drawing.Size(113, 46);
            this.btnOkEdit.TabIndex = 1;
            this.btnOkEdit.Text = "OK";
            this.btnOkEdit.UseVisualStyleBackColor = true;
            this.btnOkEdit.Click += new System.EventHandler(this.btnOkEdit_Click);
            // 
            // tbxNewData
            // 
            this.tbxNewData.Location = new System.Drawing.Point(36, 50);
            this.tbxNewData.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNewData.Name = "tbxNewData";
            this.tbxNewData.Size = new System.Drawing.Size(280, 22);
            this.tbxNewData.TabIndex = 0;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(59, 50);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(116, 16);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "PRODUCT NAME";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(295, 50);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(123, 16);
            this.labelColor.TabIndex = 1;
            this.labelColor.Text = "PRODUCT COLOR";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(479, 50);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(117, 16);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "PRODUCT PRICE";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(663, 50);
            this.labelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(146, 16);
            this.labelQ.TabIndex = 3;
            this.labelQ.Text = "PRODUCT QUANTITY";
            // 
            // btnOkDel
            // 
            this.btnOkDel.Location = new System.Drawing.Point(361, 94);
            this.btnOkDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkDel.Name = "btnOkDel";
            this.btnOkDel.Size = new System.Drawing.Size(191, 33);
            this.btnOkDel.TabIndex = 4;
            this.btnOkDel.Text = "OK Delete";
            this.btnOkDel.UseVisualStyleBackColor = true;
            this.btnOkDel.Click += new System.EventHandler(this.btnOkDel_Click);
            // 
            // panelDel
            // 
            this.panelDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelDel.Controls.Add(this.btnOkDel);
            this.panelDel.Controls.Add(this.labelQ);
            this.panelDel.Controls.Add(this.labelPrice);
            this.panelDel.Controls.Add(this.labelColor);
            this.panelDel.Controls.Add(this.labelProduct);
            this.panelDel.Location = new System.Drawing.Point(158, 46);
            this.panelDel.Margin = new System.Windows.Forms.Padding(4);
            this.panelDel.Name = "panelDel";
            this.panelDel.Size = new System.Drawing.Size(915, 154);
            this.panelDel.TabIndex = 18;
            this.panelDel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDel_Paint);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(17, 482);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(134, 56);
            this.btn_history.TabIndex = 19;
            this.btn_history.Text = "history";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // Astock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 646);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.panelDel);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataHistory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack2Home);
            this.Controls.Add(this.btnDel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Astock";
            this.Text = "Astock";
            this.Load += new System.EventHandler(this.Astock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmberQntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmberPrice)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDel.ResumeLayout(false);
            this.panelDel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBack2Home;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.TextBox tbxPrct;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.NumericUpDown nmberQntity;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nmberPrice;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnOkEdit;
        private System.Windows.Forms.TextBox tbxNewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label labelAddressPic;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Button btnOkDel;
        private System.Windows.Forms.Panel panelDel;
        private System.Windows.Forms.Button btnOkAdd;
        private System.Windows.Forms.Button btn_history;
    }
}