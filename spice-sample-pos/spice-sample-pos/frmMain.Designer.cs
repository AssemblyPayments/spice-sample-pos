namespace spice_sample_pos
{
    partial class frmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.Purchase = new System.Windows.Forms.TabPage();
            this.rbCashoutYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCashoutNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSurcharge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCashout = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPurchase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.MOTO = new System.Windows.Forms.TabPage();
            this.rbSuppressPasswordYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSuppressPasswordNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMotoSurcharge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMotoPurchase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.Refund = new System.Windows.Forms.TabPage();
            this.rbRefundSuppressPasswordYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRefundSuppressPasswordNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRefund = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SettlementEnquiry = new System.Windows.Forms.TabPage();
            this.tsMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblReceipt = new MaterialSkin.Controls.MaterialLabel();
            this.pnlResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentAdaptorStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcMain.SuspendLayout();
            this.Purchase.SuspendLayout();
            this.MOTO.SuspendLayout();
            this.Refund.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::spice_sample_pos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.Purchase);
            this.tcMain.Controls.Add(this.MOTO);
            this.tcMain.Controls.Add(this.Refund);
            this.tcMain.Controls.Add(this.SettlementEnquiry);
            this.tcMain.Depth = 0;
            this.tcMain.Location = new System.Drawing.Point(470, 116);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(649, 422);
            this.tcMain.TabIndex = 5;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tsMain_SelectedIndexChanged);
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.SystemColors.Control;
            this.Purchase.Controls.Add(this.rbCashoutYes);
            this.Purchase.Controls.Add(this.rbCashoutNo);
            this.Purchase.Controls.Add(this.materialLabel6);
            this.Purchase.Controls.Add(this.txtSurcharge);
            this.Purchase.Controls.Add(this.materialLabel5);
            this.Purchase.Controls.Add(this.txtTip);
            this.Purchase.Controls.Add(this.materialLabel4);
            this.Purchase.Controls.Add(this.txtCashout);
            this.Purchase.Controls.Add(this.materialLabel2);
            this.Purchase.Controls.Add(this.panel1);
            this.Purchase.Controls.Add(this.txtPurchase);
            this.Purchase.Controls.Add(this.materialLabel3);
            this.Purchase.Location = new System.Drawing.Point(4, 22);
            this.Purchase.Name = "Purchase";
            this.Purchase.Padding = new System.Windows.Forms.Padding(3);
            this.Purchase.Size = new System.Drawing.Size(641, 396);
            this.Purchase.TabIndex = 0;
            this.Purchase.Text = "Purchase";
            // 
            // rbCashoutYes
            // 
            this.rbCashoutYes.AutoSize = true;
            this.rbCashoutYes.Depth = 0;
            this.rbCashoutYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCashoutYes.Location = new System.Drawing.Point(68, 276);
            this.rbCashoutYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbCashoutYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCashoutYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCashoutYes.Name = "rbCashoutYes";
            this.rbCashoutYes.Ripple = true;
            this.rbCashoutYes.Size = new System.Drawing.Size(52, 30);
            this.rbCashoutYes.TabIndex = 13;
            this.rbCashoutYes.Text = "Yes";
            this.rbCashoutYes.UseVisualStyleBackColor = true;
            // 
            // rbCashoutNo
            // 
            this.rbCashoutNo.AutoSize = true;
            this.rbCashoutNo.Checked = true;
            this.rbCashoutNo.Depth = 0;
            this.rbCashoutNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCashoutNo.Location = new System.Drawing.Point(-1, 276);
            this.rbCashoutNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbCashoutNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCashoutNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCashoutNo.Name = "rbCashoutNo";
            this.rbCashoutNo.Ripple = true;
            this.rbCashoutNo.Size = new System.Drawing.Size(47, 30);
            this.rbCashoutNo.TabIndex = 12;
            this.rbCashoutNo.TabStop = true;
            this.rbCashoutNo.Text = "No";
            this.rbCashoutNo.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(1, 253);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Cashout?";
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Depth = 0;
            this.txtSurcharge.Hint = "";
            this.txtSurcharge.Location = new System.Drawing.Point(5, 215);
            this.txtSurcharge.MaxLength = 32767;
            this.txtSurcharge.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.PasswordChar = '\0';
            this.txtSurcharge.SelectedText = "";
            this.txtSurcharge.SelectionLength = 0;
            this.txtSurcharge.SelectionStart = 0;
            this.txtSurcharge.Size = new System.Drawing.Size(348, 23);
            this.txtSurcharge.TabIndex = 10;
            this.txtSurcharge.TabStop = false;
            this.txtSurcharge.Text = "0";
            this.txtSurcharge.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(2, 193);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(184, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Surcharge Amount - Cents";
            // 
            // txtTip
            // 
            this.txtTip.Depth = 0;
            this.txtTip.Hint = "";
            this.txtTip.Location = new System.Drawing.Point(6, 154);
            this.txtTip.MaxLength = 32767;
            this.txtTip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTip.Name = "txtTip";
            this.txtTip.PasswordChar = '\0';
            this.txtTip.SelectedText = "";
            this.txtTip.SelectionLength = 0;
            this.txtTip.SelectionStart = 0;
            this.txtTip.Size = new System.Drawing.Size(348, 23);
            this.txtTip.TabIndex = 8;
            this.txtTip.TabStop = false;
            this.txtTip.Text = "0";
            this.txtTip.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 132);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(142, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Tip Amount - Cents:";
            // 
            // txtCashout
            // 
            this.txtCashout.Depth = 0;
            this.txtCashout.Hint = "";
            this.txtCashout.Location = new System.Drawing.Point(6, 96);
            this.txtCashout.MaxLength = 32767;
            this.txtCashout.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCashout.Name = "txtCashout";
            this.txtCashout.PasswordChar = '\0';
            this.txtCashout.SelectedText = "";
            this.txtCashout.SelectionLength = 0;
            this.txtCashout.SelectionStart = 0;
            this.txtCashout.Size = new System.Drawing.Size(348, 23);
            this.txtCashout.TabIndex = 6;
            this.txtCashout.TabStop = false;
            this.txtCashout.Text = "0";
            this.txtCashout.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(2, 74);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Cashout Amount - Cents:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-4, -88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Depth = 0;
            this.txtPurchase.Hint = "";
            this.txtPurchase.Location = new System.Drawing.Point(6, 37);
            this.txtPurchase.MaxLength = 32767;
            this.txtPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.PasswordChar = '\0';
            this.txtPurchase.SelectedText = "";
            this.txtPurchase.SelectionLength = 0;
            this.txtPurchase.SelectionStart = 0;
            this.txtPurchase.Size = new System.Drawing.Size(348, 23);
            this.txtPurchase.TabIndex = 3;
            this.txtPurchase.TabStop = false;
            this.txtPurchase.Text = "0";
            this.txtPurchase.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 15);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(183, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Purchase Amount - Cents:";
            // 
            // MOTO
            // 
            this.MOTO.BackColor = System.Drawing.SystemColors.Control;
            this.MOTO.Controls.Add(this.rbSuppressPasswordYes);
            this.MOTO.Controls.Add(this.rbSuppressPasswordNo);
            this.MOTO.Controls.Add(this.materialLabel9);
            this.MOTO.Controls.Add(this.txtMotoSurcharge);
            this.MOTO.Controls.Add(this.materialLabel7);
            this.MOTO.Controls.Add(this.txtMotoPurchase);
            this.MOTO.Controls.Add(this.materialLabel8);
            this.MOTO.Location = new System.Drawing.Point(4, 22);
            this.MOTO.Name = "MOTO";
            this.MOTO.Size = new System.Drawing.Size(641, 396);
            this.MOTO.TabIndex = 4;
            this.MOTO.Text = "MOTO";
            // 
            // rbSuppressPasswordYes
            // 
            this.rbSuppressPasswordYes.AutoSize = true;
            this.rbSuppressPasswordYes.Depth = 0;
            this.rbSuppressPasswordYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSuppressPasswordYes.Location = new System.Drawing.Point(70, 154);
            this.rbSuppressPasswordYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbSuppressPasswordYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSuppressPasswordYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSuppressPasswordYes.Name = "rbSuppressPasswordYes";
            this.rbSuppressPasswordYes.Ripple = true;
            this.rbSuppressPasswordYes.Size = new System.Drawing.Size(52, 30);
            this.rbSuppressPasswordYes.TabIndex = 17;
            this.rbSuppressPasswordYes.Text = "Yes";
            this.rbSuppressPasswordYes.UseVisualStyleBackColor = true;
            // 
            // rbSuppressPasswordNo
            // 
            this.rbSuppressPasswordNo.AutoSize = true;
            this.rbSuppressPasswordNo.Checked = true;
            this.rbSuppressPasswordNo.Depth = 0;
            this.rbSuppressPasswordNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSuppressPasswordNo.Location = new System.Drawing.Point(1, 154);
            this.rbSuppressPasswordNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbSuppressPasswordNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSuppressPasswordNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSuppressPasswordNo.Name = "rbSuppressPasswordNo";
            this.rbSuppressPasswordNo.Ripple = true;
            this.rbSuppressPasswordNo.Size = new System.Drawing.Size(47, 30);
            this.rbSuppressPasswordNo.TabIndex = 16;
            this.rbSuppressPasswordNo.TabStop = true;
            this.rbSuppressPasswordNo.Text = "No";
            this.rbSuppressPasswordNo.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 131);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(215, 19);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Suppress Merchant Password?";
            // 
            // txtMotoSurcharge
            // 
            this.txtMotoSurcharge.Depth = 0;
            this.txtMotoSurcharge.Hint = "";
            this.txtMotoSurcharge.Location = new System.Drawing.Point(6, 95);
            this.txtMotoSurcharge.MaxLength = 32767;
            this.txtMotoSurcharge.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMotoSurcharge.Name = "txtMotoSurcharge";
            this.txtMotoSurcharge.PasswordChar = '\0';
            this.txtMotoSurcharge.SelectedText = "";
            this.txtMotoSurcharge.SelectionLength = 0;
            this.txtMotoSurcharge.SelectionStart = 0;
            this.txtMotoSurcharge.Size = new System.Drawing.Size(348, 23);
            this.txtMotoSurcharge.TabIndex = 14;
            this.txtMotoSurcharge.TabStop = false;
            this.txtMotoSurcharge.Text = "0";
            this.txtMotoSurcharge.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 73);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(184, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Surcharge Amount - Cents";
            // 
            // txtMotoPurchase
            // 
            this.txtMotoPurchase.Depth = 0;
            this.txtMotoPurchase.Hint = "";
            this.txtMotoPurchase.Location = new System.Drawing.Point(6, 37);
            this.txtMotoPurchase.MaxLength = 32767;
            this.txtMotoPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMotoPurchase.Name = "txtMotoPurchase";
            this.txtMotoPurchase.PasswordChar = '\0';
            this.txtMotoPurchase.SelectedText = "";
            this.txtMotoPurchase.SelectionLength = 0;
            this.txtMotoPurchase.SelectionStart = 0;
            this.txtMotoPurchase.Size = new System.Drawing.Size(348, 23);
            this.txtMotoPurchase.TabIndex = 12;
            this.txtMotoPurchase.TabStop = false;
            this.txtMotoPurchase.Text = "0";
            this.txtMotoPurchase.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 15);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(183, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Purchase Amount - Cents:";
            // 
            // Refund
            // 
            this.Refund.BackColor = System.Drawing.SystemColors.Control;
            this.Refund.Controls.Add(this.rbRefundSuppressPasswordYes);
            this.Refund.Controls.Add(this.rbRefundSuppressPasswordNo);
            this.Refund.Controls.Add(this.materialLabel10);
            this.Refund.Controls.Add(this.txtRefund);
            this.Refund.Controls.Add(this.materialLabel1);
            this.Refund.Location = new System.Drawing.Point(4, 22);
            this.Refund.Name = "Refund";
            this.Refund.Padding = new System.Windows.Forms.Padding(3);
            this.Refund.Size = new System.Drawing.Size(641, 396);
            this.Refund.TabIndex = 1;
            this.Refund.Text = "Refund";
            // 
            // rbRefundSuppressPasswordYes
            // 
            this.rbRefundSuppressPasswordYes.AutoSize = true;
            this.rbRefundSuppressPasswordYes.Depth = 0;
            this.rbRefundSuppressPasswordYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRefundSuppressPasswordYes.Location = new System.Drawing.Point(70, 98);
            this.rbRefundSuppressPasswordYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbRefundSuppressPasswordYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRefundSuppressPasswordYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRefundSuppressPasswordYes.Name = "rbRefundSuppressPasswordYes";
            this.rbRefundSuppressPasswordYes.Ripple = true;
            this.rbRefundSuppressPasswordYes.Size = new System.Drawing.Size(52, 30);
            this.rbRefundSuppressPasswordYes.TabIndex = 20;
            this.rbRefundSuppressPasswordYes.Text = "Yes";
            this.rbRefundSuppressPasswordYes.UseVisualStyleBackColor = true;
            // 
            // rbRefundSuppressPasswordNo
            // 
            this.rbRefundSuppressPasswordNo.AutoSize = true;
            this.rbRefundSuppressPasswordNo.Checked = true;
            this.rbRefundSuppressPasswordNo.Depth = 0;
            this.rbRefundSuppressPasswordNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRefundSuppressPasswordNo.Location = new System.Drawing.Point(1, 98);
            this.rbRefundSuppressPasswordNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbRefundSuppressPasswordNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRefundSuppressPasswordNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRefundSuppressPasswordNo.Name = "rbRefundSuppressPasswordNo";
            this.rbRefundSuppressPasswordNo.Ripple = true;
            this.rbRefundSuppressPasswordNo.Size = new System.Drawing.Size(47, 30);
            this.rbRefundSuppressPasswordNo.TabIndex = 19;
            this.rbRefundSuppressPasswordNo.TabStop = true;
            this.rbRefundSuppressPasswordNo.Text = "No";
            this.rbRefundSuppressPasswordNo.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(3, 75);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(215, 19);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Suppress Merchant Password?";
            // 
            // txtRefund
            // 
            this.txtRefund.Depth = 0;
            this.txtRefund.Hint = "";
            this.txtRefund.Location = new System.Drawing.Point(6, 37);
            this.txtRefund.MaxLength = 32767;
            this.txtRefund.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.PasswordChar = '\0';
            this.txtRefund.SelectedText = "";
            this.txtRefund.SelectionLength = 0;
            this.txtRefund.SelectionStart = 0;
            this.txtRefund.Size = new System.Drawing.Size(348, 23);
            this.txtRefund.TabIndex = 4;
            this.txtRefund.TabStop = false;
            this.txtRefund.Text = "0.00";
            this.txtRefund.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(167, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Refund Amount - Cents:";
            // 
            // SettlementEnquiry
            // 
            this.SettlementEnquiry.Location = new System.Drawing.Point(4, 22);
            this.SettlementEnquiry.Name = "SettlementEnquiry";
            this.SettlementEnquiry.Padding = new System.Windows.Forms.Padding(3);
            this.SettlementEnquiry.Size = new System.Drawing.Size(641, 396);
            this.SettlementEnquiry.TabIndex = 2;
            this.SettlementEnquiry.Text = "Settlement Enquiry";
            this.SettlementEnquiry.UseVisualStyleBackColor = true;
            // 
            // tsMain
            // 
            this.tsMain.BaseTabControl = this.tcMain;
            this.tsMain.Depth = 0;
            this.tsMain.Location = new System.Drawing.Point(470, 87);
            this.tsMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(649, 23);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "tsMain";
            // 
            // btnAction
            // 
            this.btnAction.AutoSize = true;
            this.btnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAction.Depth = 0;
            this.btnAction.Icon = null;
            this.btnAction.Location = new System.Drawing.Point(1028, 544);
            this.btnAction.MaximumSize = new System.Drawing.Size(91, 36);
            this.btnAction.MinimumSize = new System.Drawing.Size(91, 36);
            this.btnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAction.Name = "btnAction";
            this.btnAction.Primary = true;
            this.btnAction.Size = new System.Drawing.Size(91, 36);
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Purchase";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Depth = 0;
            this.lblReceipt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReceipt.Location = new System.Drawing.Point(470, 302);
            this.lblReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(0, 19);
            this.lblReceipt.TabIndex = 8;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.panel2);
            this.pnlResult.Location = new System.Drawing.Point(470, 116);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(649, 422);
            this.pnlResult.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "lblResult";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(56, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Powered By Assembly Payments";
            // 
            // lblCurrentAdaptorStatus
            // 
            this.lblCurrentAdaptorStatus.AutoSize = true;
            this.lblCurrentAdaptorStatus.Location = new System.Drawing.Point(470, 565);
            this.lblCurrentAdaptorStatus.Name = "lblCurrentAdaptorStatus";
            this.lblCurrentAdaptorStatus.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentAdaptorStatus.TabIndex = 11;
            this.lblCurrentAdaptorStatus.Text = "Adaptor Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 587);
            this.Controls.Add(this.lblCurrentAdaptorStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Habanero POS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.Purchase.ResumeLayout(false);
            this.Purchase.PerformLayout();
            this.MOTO.ResumeLayout(false);
            this.MOTO.PerformLayout();
            this.Refund.ResumeLayout(false);
            this.Refund.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage Purchase;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage Refund;
        private MaterialSkin.Controls.MaterialTabSelector tsMain;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPurchase;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRefund;
        private MaterialSkin.Controls.MaterialRaisedButton btnAction;
        private MaterialSkin.Controls.MaterialLabel lblReceipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCashout;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTip;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TabPage SettlementEnquiry;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSurcharge;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton rbCashoutNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton rbCashoutYes;
        private System.Windows.Forms.TabPage MOTO;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMotoSurcharge;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMotoPurchase;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRadioButton rbSuppressPasswordYes;
        private MaterialSkin.Controls.MaterialRadioButton rbSuppressPasswordNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialRadioButton rbRefundSuppressPasswordYes;
        private MaterialSkin.Controls.MaterialRadioButton rbRefundSuppressPasswordNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Label lblCurrentAdaptorStatus;
    }
}

