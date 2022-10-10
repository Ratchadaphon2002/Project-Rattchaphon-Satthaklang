namespace Project_Nik
{
    partial class visa
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.visaEmail = new System.Windows.Forms.Label();
            this.panelCreateVisa = new System.Windows.Forms.Panel();
            this.btn_cancel_visa = new System.Windows.Forms.Button();
            this.btn_OK_visa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxVisaHolderName = new System.Windows.Forms.TextBox();
            this.labelVisaName = new System.Windows.Forms.Label();
            this.holdername = new System.Windows.Forms.Label();
            this.labelVisaNum = new System.Windows.Forms.Label();
            this.visaNumber = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.visaMoney = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panelVisa = new System.Windows.Forms.Panel();
            this.btn_refill = new System.Windows.Forms.Button();
            this.panelCreateVisa.SuspendLayout();
            this.panelVisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(39, 18);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 29);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // visaEmail
            // 
            this.visaEmail.AutoSize = true;
            this.visaEmail.BackColor = System.Drawing.Color.ForestGreen;
            this.visaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.visaEmail.Location = new System.Drawing.Point(119, 18);
            this.visaEmail.Name = "visaEmail";
            this.visaEmail.Size = new System.Drawing.Size(240, 29);
            this.visaEmail.TabIndex = 2;
            this.visaEmail.Text = "example@gmail.com";
            // 
            // panelCreateVisa
            // 
            this.panelCreateVisa.Controls.Add(this.btn_cancel_visa);
            this.panelCreateVisa.Controls.Add(this.btn_OK_visa);
            this.panelCreateVisa.Controls.Add(this.label1);
            this.panelCreateVisa.Controls.Add(this.tbxVisaHolderName);
            this.panelCreateVisa.Location = new System.Drawing.Point(38, 60);
            this.panelCreateVisa.Name = "panelCreateVisa";
            this.panelCreateVisa.Size = new System.Drawing.Size(693, 165);
            this.panelCreateVisa.TabIndex = 3;
            // 
            // btn_cancel_visa
            // 
            this.btn_cancel_visa.Location = new System.Drawing.Point(377, 108);
            this.btn_cancel_visa.Name = "btn_cancel_visa";
            this.btn_cancel_visa.Size = new System.Drawing.Size(75, 34);
            this.btn_cancel_visa.TabIndex = 3;
            this.btn_cancel_visa.Text = "CANCEL";
            this.btn_cancel_visa.UseVisualStyleBackColor = true;
            this.btn_cancel_visa.Click += new System.EventHandler(this.btn_cancel_visa_Click);
            // 
            // btn_OK_visa
            // 
            this.btn_OK_visa.Location = new System.Drawing.Point(296, 108);
            this.btn_OK_visa.Name = "btn_OK_visa";
            this.btn_OK_visa.Size = new System.Drawing.Size(75, 34);
            this.btn_OK_visa.TabIndex = 2;
            this.btn_OK_visa.Text = "OK";
            this.btn_OK_visa.UseVisualStyleBackColor = true;
            this.btn_OK_visa.Click += new System.EventHandler(this.btn_OK_visa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type your holder name";
            // 
            // tbxVisaHolderName
            // 
            this.tbxVisaHolderName.Location = new System.Drawing.Point(240, 74);
            this.tbxVisaHolderName.Name = "tbxVisaHolderName";
            this.tbxVisaHolderName.Size = new System.Drawing.Size(262, 22);
            this.tbxVisaHolderName.TabIndex = 0;
            this.tbxVisaHolderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVisaHolderName_KeyPress);
            // 
            // labelVisaName
            // 
            this.labelVisaName.AutoSize = true;
            this.labelVisaName.BackColor = System.Drawing.Color.Ivory;
            this.labelVisaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisaName.Location = new System.Drawing.Point(13, 41);
            this.labelVisaName.Name = "labelVisaName";
            this.labelVisaName.Size = new System.Drawing.Size(216, 29);
            this.labelVisaName.TabIndex = 0;
            this.labelVisaName.Text = "HOLDER NAME:";
            // 
            // holdername
            // 
            this.holdername.AutoSize = true;
            this.holdername.BackColor = System.Drawing.Color.GreenYellow;
            this.holdername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdername.Location = new System.Drawing.Point(265, 42);
            this.holdername.Name = "holdername";
            this.holdername.Size = new System.Drawing.Size(136, 29);
            this.holdername.TabIndex = 1;
            this.holdername.Text = "NAME NIK";
            // 
            // labelVisaNum
            // 
            this.labelVisaNum.AutoSize = true;
            this.labelVisaNum.BackColor = System.Drawing.Color.Ivory;
            this.labelVisaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisaNum.Location = new System.Drawing.Point(13, 113);
            this.labelVisaNum.Name = "labelVisaNum";
            this.labelVisaNum.Size = new System.Drawing.Size(193, 29);
            this.labelVisaNum.TabIndex = 2;
            this.labelVisaNum.Text = "VISA NUMBER:";
            // 
            // visaNumber
            // 
            this.visaNumber.AutoSize = true;
            this.visaNumber.BackColor = System.Drawing.Color.GreenYellow;
            this.visaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaNumber.Location = new System.Drawing.Point(243, 113);
            this.visaNumber.Name = "visaNumber";
            this.visaNumber.Size = new System.Drawing.Size(223, 29);
            this.visaNumber.TabIndex = 3;
            this.visaNumber.Text = "400123456789010";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Ivory;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(13, 174);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(94, 29);
            this.labelMoney.TabIndex = 4;
            this.labelMoney.Text = "Money";
            // 
            // visaMoney
            // 
            this.visaMoney.AutoSize = true;
            this.visaMoney.BackColor = System.Drawing.Color.GreenYellow;
            this.visaMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaMoney.Location = new System.Drawing.Point(133, 174);
            this.visaMoney.Name = "visaMoney";
            this.visaMoney.Size = new System.Drawing.Size(73, 29);
            this.visaMoney.TabIndex = 5;
            this.visaMoney.Text = "xxxxx";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(602, 205);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panelVisa
            // 
            this.panelVisa.BackColor = System.Drawing.Color.ForestGreen;
            this.panelVisa.Controls.Add(this.btn_refill);
            this.panelVisa.Controls.Add(this.btn_close);
            this.panelVisa.Controls.Add(this.visaMoney);
            this.panelVisa.Controls.Add(this.labelMoney);
            this.panelVisa.Controls.Add(this.visaNumber);
            this.panelVisa.Controls.Add(this.labelVisaNum);
            this.panelVisa.Controls.Add(this.holdername);
            this.panelVisa.Controls.Add(this.labelVisaName);
            this.panelVisa.Location = new System.Drawing.Point(38, 60);
            this.panelVisa.Name = "panelVisa";
            this.panelVisa.Size = new System.Drawing.Size(693, 253);
            this.panelVisa.TabIndex = 0;
            // 
            // btn_refill
            // 
            this.btn_refill.Location = new System.Drawing.Point(493, 205);
            this.btn_refill.Name = "btn_refill";
            this.btn_refill.Size = new System.Drawing.Size(75, 34);
            this.btn_refill.TabIndex = 4;
            this.btn_refill.Text = "REFILL";
            this.btn_refill.UseVisualStyleBackColor = true;
            this.btn_refill.Click += new System.EventHandler(this.btn_refill_Click);
            // 
            // visa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 338);
            this.Controls.Add(this.panelCreateVisa);
            this.Controls.Add(this.visaEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panelVisa);
            this.Name = "visa";
            this.Text = "visa";
            this.Load += new System.EventHandler(this.visa_Load);
            this.panelCreateVisa.ResumeLayout(false);
            this.panelCreateVisa.PerformLayout();
            this.panelVisa.ResumeLayout(false);
            this.panelVisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label visaEmail;
        private System.Windows.Forms.Panel panelCreateVisa;
        private System.Windows.Forms.Button btn_cancel_visa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxVisaHolderName;
        private System.Windows.Forms.Button btn_OK_visa;
        private System.Windows.Forms.Label labelVisaName;
        private System.Windows.Forms.Label holdername;
        private System.Windows.Forms.Label labelVisaNum;
        private System.Windows.Forms.Label visaNumber;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label visaMoney;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panelVisa;
        private System.Windows.Forms.Button btn_refill;
    }
}