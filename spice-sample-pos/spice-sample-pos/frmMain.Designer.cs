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
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.Purchase = new System.Windows.Forms.TabPage();
            this.txtTip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCashout = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPurchase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Refund = new System.Windows.Forms.TabPage();
            this.txtRefund = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SettlementEnquiry = new System.Windows.Forms.TabPage();
            this.PayAtTable = new System.Windows.Forms.TabPage();
            this.tsMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblReceipt = new MaterialSkin.Controls.MaterialLabel();
            this.pnlResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain.SuspendLayout();
            this.Purchase.SuspendLayout();
            this.Refund.SuspendLayout();
            this.PayAtTable.SuspendLayout();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.Purchase);
            this.tcMain.Controls.Add(this.Refund);
            this.tcMain.Controls.Add(this.SettlementEnquiry);
            this.tcMain.Controls.Add(this.PayAtTable);
            this.tcMain.Depth = 0;
            this.tcMain.Location = new System.Drawing.Point(470, 116);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(516, 308);
            this.tcMain.TabIndex = 5;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tsMain_SelectedIndexChanged);
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.SystemColors.Control;
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
            this.Purchase.Size = new System.Drawing.Size(508, 282);
            this.Purchase.TabIndex = 0;
            this.Purchase.Text = "Purchase";
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
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 132);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(139, 18);
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
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(2, 74);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(175, 18);
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
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 15);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(182, 18);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Purchase Amount - Cents:";
            // 
            // Refund
            // 
            this.Refund.BackColor = System.Drawing.SystemColors.Control;
            this.Refund.Controls.Add(this.txtRefund);
            this.Refund.Controls.Add(this.materialLabel1);
            this.Refund.Location = new System.Drawing.Point(4, 22);
            this.Refund.Name = "Refund";
            this.Refund.Padding = new System.Windows.Forms.Padding(3);
            this.Refund.Size = new System.Drawing.Size(508, 282);
            this.Refund.TabIndex = 1;
            this.Refund.Text = "Refund";
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
            this.txtRefund.Text = "0";
            this.txtRefund.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 18);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Refund Amount - Cents:";
            // 
            // SettlementEnquiry
            // 
            this.SettlementEnquiry.Location = new System.Drawing.Point(4, 22);
            this.SettlementEnquiry.Name = "SettlementEnquiry";
            this.SettlementEnquiry.Padding = new System.Windows.Forms.Padding(3);
            this.SettlementEnquiry.Size = new System.Drawing.Size(508, 282);
            this.SettlementEnquiry.TabIndex = 2;
            this.SettlementEnquiry.Text = "Settlement Enquiry";
            this.SettlementEnquiry.UseVisualStyleBackColor = true;
            // 
            // PayAtTable
            // 
            this.PayAtTable.BackColor = System.Drawing.SystemColors.Control;
            this.PayAtTable.Controls.Add(this.btnTable2);
            this.PayAtTable.Controls.Add(this.btnTable1);
            this.PayAtTable.Location = new System.Drawing.Point(4, 22);
            this.PayAtTable.Name = "PayAtTable";
            this.PayAtTable.Size = new System.Drawing.Size(508, 282);
            this.PayAtTable.TabIndex = 3;
            this.PayAtTable.Text = "Pay at Table";
            // 
            // tsMain
            // 
            this.tsMain.BaseTabControl = this.tcMain;
            this.tsMain.Depth = 0;
            this.tsMain.Location = new System.Drawing.Point(470, 87);
            this.tsMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(516, 23);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "tsMain";
            // 
            // btnAction
            // 
            this.btnAction.AutoSize = true;
            this.btnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAction.Depth = 0;
            this.btnAction.Icon = null;
            this.btnAction.Location = new System.Drawing.Point(895, 440);
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
            this.lblReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReceipt.Location = new System.Drawing.Point(470, 302);
            this.lblReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(0, 18);
            this.lblReceipt.TabIndex = 8;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.panel2);
            this.pnlResult.Location = new System.Drawing.Point(470, 116);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(438, 308);
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
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTable1.Location = new System.Drawing.Point(52, 57);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(171, 139);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.BtnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTable2.Location = new System.Drawing.Point(292, 57);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(171, 139);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.BtnTable2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::spice_sample_pos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 486);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Habanero POS";
            this.tcMain.ResumeLayout(false);
            this.Purchase.ResumeLayout(false);
            this.Purchase.PerformLayout();
            this.Refund.ResumeLayout(false);
            this.Refund.PerformLayout();
            this.PayAtTable.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabPage PayAtTable;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable1;
    }
}

