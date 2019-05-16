namespace spice_sample_pos
{
    partial class frmPAT
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
            this.btnPatAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPatOperatorId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.Open = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.TabPage();
            this.lvBillDetails = new MaterialSkin.Controls.MaterialListView();
            this.TableId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OperatorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutstandingAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPatAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPatClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tcMain.SuspendLayout();
            this.Open.SuspendLayout();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatAction
            // 
            this.btnPatAction.AutoSize = true;
            this.btnPatAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPatAction.Depth = 0;
            this.btnPatAction.Icon = null;
            this.btnPatAction.Location = new System.Drawing.Point(539, 354);
            this.btnPatAction.MaximumSize = new System.Drawing.Size(91, 36);
            this.btnPatAction.MinimumSize = new System.Drawing.Size(91, 36);
            this.btnPatAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPatAction.Name = "btnPatAction";
            this.btnPatAction.Primary = true;
            this.btnPatAction.Size = new System.Drawing.Size(91, 36);
            this.btnPatAction.TabIndex = 8;
            this.btnPatAction.Text = "Open Table";
            this.btnPatAction.UseVisualStyleBackColor = true;
            this.btnPatAction.Click += new System.EventHandler(this.BtnPatAction_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 15);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Operator ID:";
            // 
            // txtPatOperatorId
            // 
            this.txtPatOperatorId.Depth = 0;
            this.txtPatOperatorId.Hint = "";
            this.txtPatOperatorId.Location = new System.Drawing.Point(10, 37);
            this.txtPatOperatorId.MaxLength = 32767;
            this.txtPatOperatorId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPatOperatorId.Name = "txtPatOperatorId";
            this.txtPatOperatorId.PasswordChar = '\0';
            this.txtPatOperatorId.SelectedText = "";
            this.txtPatOperatorId.SelectionLength = 0;
            this.txtPatOperatorId.SelectionStart = 0;
            this.txtPatOperatorId.Size = new System.Drawing.Size(348, 23);
            this.txtPatOperatorId.TabIndex = 10;
            this.txtPatOperatorId.TabStop = false;
            this.txtPatOperatorId.Text = "0";
            this.txtPatOperatorId.UseSystemPasswordChar = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.Open);
            this.tcMain.Controls.Add(this.Add);
            this.tcMain.Depth = 0;
            this.tcMain.Location = new System.Drawing.Point(12, 73);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(622, 265);
            this.tcMain.TabIndex = 11;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.Control;
            this.Open.Controls.Add(this.txtPatOperatorId);
            this.Open.Controls.Add(this.panel1);
            this.Open.Controls.Add(this.materialLabel3);
            this.Open.Location = new System.Drawing.Point(4, 22);
            this.Open.Name = "Open";
            this.Open.Padding = new System.Windows.Forms.Padding(3);
            this.Open.Size = new System.Drawing.Size(614, 239);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-4, -88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Controls.Add(this.lvBillDetails);
            this.Add.Controls.Add(this.txtPatAmount);
            this.Add.Controls.Add(this.materialLabel5);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(614, 239);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            // 
            // lvBillDetails
            // 
            this.lvBillDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvBillDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableId,
            this.OperatorId,
            this.TotalAmount,
            this.OutstandingAmount});
            this.lvBillDetails.Depth = 0;
            this.lvBillDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvBillDetails.FullRowSelect = true;
            this.lvBillDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBillDetails.Location = new System.Drawing.Point(-1, 0);
            this.lvBillDetails.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvBillDetails.MouseState = MaterialSkin.MouseState.OUT;
            this.lvBillDetails.Name = "lvBillDetails";
            this.lvBillDetails.OwnerDraw = true;
            this.lvBillDetails.Size = new System.Drawing.Size(615, 145);
            this.lvBillDetails.TabIndex = 5;
            this.lvBillDetails.UseCompatibleStateImageBehavior = false;
            this.lvBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // TableId
            // 
            this.TableId.Text = "Table Id";
            this.TableId.Width = 80;
            // 
            // OperatorId
            // 
            this.OperatorId.Text = "Operator Id";
            this.OperatorId.Width = 130;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Text = "Total Amount";
            this.TotalAmount.Width = 200;
            // 
            // OutstandingAmount
            // 
            this.OutstandingAmount.Text = "Outstanding Amount";
            this.OutstandingAmount.Width = 200;
            // 
            // txtPatAmount
            // 
            this.txtPatAmount.Depth = 0;
            this.txtPatAmount.Hint = "";
            this.txtPatAmount.Location = new System.Drawing.Point(10, 199);
            this.txtPatAmount.MaxLength = 32767;
            this.txtPatAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPatAmount.Name = "txtPatAmount";
            this.txtPatAmount.PasswordChar = '\0';
            this.txtPatAmount.SelectedText = "";
            this.txtPatAmount.SelectionLength = 0;
            this.txtPatAmount.SelectionStart = 0;
            this.txtPatAmount.Size = new System.Drawing.Size(348, 23);
            this.txtPatAmount.TabIndex = 4;
            this.txtPatAmount.TabStop = false;
            this.txtPatAmount.Text = "0";
            this.txtPatAmount.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 177);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(165, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Amount to Add - Cents:";
            // 
            // btnPatClose
            // 
            this.btnPatClose.AutoSize = true;
            this.btnPatClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPatClose.Depth = 0;
            this.btnPatClose.Icon = null;
            this.btnPatClose.Location = new System.Drawing.Point(442, 354);
            this.btnPatClose.MaximumSize = new System.Drawing.Size(91, 36);
            this.btnPatClose.MinimumSize = new System.Drawing.Size(91, 36);
            this.btnPatClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPatClose.Name = "btnPatClose";
            this.btnPatClose.Primary = true;
            this.btnPatClose.Size = new System.Drawing.Size(91, 36);
            this.btnPatClose.TabIndex = 12;
            this.btnPatClose.Text = "Close Table";
            this.btnPatClose.UseVisualStyleBackColor = true;
            this.btnPatClose.Visible = false;
            // 
            // frmPAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.btnPatClose);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.btnPatAction);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPAT";
            this.Text = "Pay At Table";
            this.tcMain.ResumeLayout(false);
            this.Open.ResumeLayout(false);
            this.Open.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnPatAction;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPatOperatorId;
        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Add;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPatAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialListView lvBillDetails;
        private System.Windows.Forms.ColumnHeader TotalAmount;
        private System.Windows.Forms.ColumnHeader OutstandingAmount;
        private System.Windows.Forms.ColumnHeader TableId;
        private System.Windows.Forms.ColumnHeader OperatorId;
        private MaterialSkin.Controls.MaterialRaisedButton btnPatClose;
    }
}