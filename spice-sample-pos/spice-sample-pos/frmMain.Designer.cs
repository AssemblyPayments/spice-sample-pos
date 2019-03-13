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
            this.txtPurchase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Refund = new System.Windows.Forms.TabPage();
            this.txtRefund = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tsMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblReceipt = new MaterialSkin.Controls.MaterialLabel();
            this.pnlResult = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcMain.SuspendLayout();
            this.Purchase.SuspendLayout();
            this.Refund.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.Purchase);
            this.tcMain.Controls.Add(this.Refund);
            this.tcMain.Depth = 0;
            this.tcMain.Location = new System.Drawing.Point(470, 116);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(442, 179);
            this.tcMain.TabIndex = 5;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tsMain_SelectedIndexChanged);
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.SystemColors.Control;
            this.Purchase.Controls.Add(this.panel1);
            this.Purchase.Controls.Add(this.txtPurchase);
            this.Purchase.Controls.Add(this.materialLabel3);
            this.Purchase.Location = new System.Drawing.Point(4, 22);
            this.Purchase.Name = "Purchase";
            this.Purchase.Padding = new System.Windows.Forms.Padding(3);
            this.Purchase.Size = new System.Drawing.Size(434, 153);
            this.Purchase.TabIndex = 0;
            this.Purchase.Text = "Purchase";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Depth = 0;
            this.txtPurchase.Hint = "";
            this.txtPurchase.Location = new System.Drawing.Point(6, 50);
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
            this.txtPurchase.Text = "0.00";
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
            this.materialLabel3.Size = new System.Drawing.Size(132, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Purchase Amount:";
            // 
            // Refund
            // 
            this.Refund.BackColor = System.Drawing.SystemColors.Control;
            this.Refund.Controls.Add(this.txtRefund);
            this.Refund.Controls.Add(this.materialLabel1);
            this.Refund.Location = new System.Drawing.Point(4, 22);
            this.Refund.Name = "Refund";
            this.Refund.Padding = new System.Windows.Forms.Padding(3);
            this.Refund.Size = new System.Drawing.Size(434, 153);
            this.Refund.TabIndex = 1;
            this.Refund.Text = "Refund";
            // 
            // txtRefund
            // 
            this.txtRefund.Depth = 0;
            this.txtRefund.Hint = "";
            this.txtRefund.Location = new System.Drawing.Point(6, 50);
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
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Refund Amount:";
            // 
            // tsMain
            // 
            this.tsMain.BaseTabControl = this.tcMain;
            this.tsMain.Depth = 0;
            this.tsMain.Location = new System.Drawing.Point(470, 87);
            this.tsMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(438, 23);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "tsMain";
            // 
            // btnAction
            // 
            this.btnAction.AutoSize = true;
            this.btnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAction.Depth = 0;
            this.btnAction.Icon = null;
            this.btnAction.Location = new System.Drawing.Point(817, 440);
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
            this.pnlResult.Size = new System.Drawing.Size(438, 308);
            this.pnlResult.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-4, -88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 486);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Habanero POS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.Purchase.ResumeLayout(false);
            this.Purchase.PerformLayout();
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
    }
}

