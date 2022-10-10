namespace Project_Nik
{
    partial class Ahistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahistory));
            this.search = new System.Windows.Forms.TextBox();
            this.btnSrch = new System.Windows.Forms.Button();
            this.btnBack2Home = new System.Windows.Forms.Button();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.no_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(657, 33);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(388, 22);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSrch
            // 
            this.btnSrch.Location = new System.Drawing.Point(1072, 30);
            this.btnSrch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(69, 30);
            this.btnSrch.TabIndex = 4;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // btnBack2Home
            // 
            this.btnBack2Home.Location = new System.Drawing.Point(16, 23);
            this.btnBack2Home.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack2Home.Name = "btnBack2Home";
            this.btnBack2Home.Size = new System.Drawing.Size(122, 48);
            this.btnBack2Home.TabIndex = 5;
            this.btnBack2Home.Text = "Back";
            this.btnBack2Home.UseVisualStyleBackColor = true;
            this.btnBack2Home.Click += new System.EventHandler(this.btnBack2Home_Click);
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_item,
            this.id_item,
            this.email,
            this.product,
            this.color,
            this.count,
            this.price,
            this.dateTime});
            this.dataHistory.Location = new System.Drawing.Point(82, 107);
            this.dataHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHistory.Size = new System.Drawing.Size(1077, 494);
            this.dataHistory.TabIndex = 8;
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
            // id_item
            // 
            this.id_item.DataPropertyName = "id";
            this.id_item.HeaderText = "ID";
            this.id_item.MinimumWidth = 6;
            this.id_item.Name = "id_item";
            this.id_item.ReadOnly = true;
            this.id_item.Width = 50;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "PRODUCT";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 180;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "COLOR";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 150;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "COUNT";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 50;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 90;
            // 
            // dateTime
            // 
            this.dateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTime.DataPropertyName = "dateTime";
            this.dateTime.HeaderText = "DATE / TIME";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // Ahistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 726);
            this.Controls.Add(this.dataHistory);
            this.Controls.Add(this.btnBack2Home);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ahistory";
            this.Text = "Ahistory";
            this.Load += new System.EventHandler(this.Ahistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Button btnBack2Home;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
    }
}