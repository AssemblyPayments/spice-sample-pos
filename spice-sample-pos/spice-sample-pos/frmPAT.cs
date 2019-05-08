using MaterialSkin;
using MaterialSkin.Controls;
using spice_sample_pos.Models;
using System;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spice_sample_pos
{
    public partial class frmPAT : MaterialForm
    {
        private readonly CultureInfo _cultureInfo = new CultureInfo("en-Au"); // make it global
        private readonly string patCurrentTableId;

        public frmPAT(string tableId)
        {
            InitializeComponent();

            // material skin intiailisation
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            this.StartPosition = FormStartPosition.CenterParent;

            patCurrentTableId = tableId;

            // check if table is already opened
            if (frmMain.patTableToBillMapping.ContainsKey(patCurrentTableId))
            {
                SelectTab("Add");
            }
            else
            {
                SelectTab("Open");
            }
        }

        private void BtnPatAction_Click(object sender, EventArgs e)
        {
            // open table
            switch (btnPatAction.Text)
            {
                case "Open Table":
                    OpenTable();
                    break;
                case "Add to Table":
                    var amountParsed = int.TryParse(txtPatAmount.Text, NumberStyles.Currency, this._cultureInfo, out var amount);

                    if (amountParsed)
                    {
                        AddToTable(patCurrentTableId, amount);
                    }

                    break;
                default:
                    break;
            }
        }

        private void BtnPat_Click(object sender, EventArgs e)
        {
            // this should trigger pay at table
        }

        private void OpenTable()
        {
            if (string.IsNullOrEmpty(txtPatOperatorId.Text))
            {
                return;
            }

            var operatorId = $"Operator - {txtPatOperatorId.Text}";

            var newBill = new PayAtTableBills()
            {
                BillId = new Guid().ToString(),
                TableId = patCurrentTableId,
                OperatorId = operatorId,
                Label = "Habanero Pay @ Table"
            };

            frmMain.patBillStore.Add(newBill.BillId, newBill);
            frmMain.patTableToBillMapping.Add(newBill.TableId, newBill.BillId);

            SelectTab("Add");
        }

        private void AddToTable(string tableId, int amountCents)
        {
            var bill = frmMain.patBillStore[frmMain.patTableToBillMapping[tableId]];

            if (bill.Locked)
            {
                return;
            }

            bill.TotalAmount += amountCents;
            bill.OutstandingAmount += amountCents;

            DisplayBill(bill);
            ResetControls();
        }

        private void DisplayBill(PayAtTableBills billToDisplay)
        {
            lvBillDetails.Items.Clear();

            var totalAmount = Math.Round(billToDisplay.OutstandingAmount / 100.0, 2);
            var outstandingAmount = Math.Round(billToDisplay.OutstandingAmount / 100.0, 2);

            var item = new ListViewItem(billToDisplay.TableId);
            item.SubItems.Add(billToDisplay.OperatorId);
            item.SubItems.Add(totalAmount.ToString("c"));
            item.SubItems.Add(outstandingAmount.ToString("c"));
            lvBillDetails.Items.Add(item);
        }

        private void SelectTab(string pageName)
        {
            switch (pageName)
            {
                case "Open":
                    tcMain.SelectTab(0);
                    btnPatAction.Text = "Open Table";
                    break;
                case "Add":
                    var bill = frmMain.patBillStore[frmMain.patTableToBillMapping[patCurrentTableId]];

                    tcMain.SelectTab(1);
                    DisplayBill(bill);
                    btnPatAction.Text = "Add to Table";
                    btnPat.Visible = true;
                    break;
                default:
                    tcMain.SelectTab(0);
                    break;
            }
        }

        private void ResetControls()
        {
            const string moneyDefault = @"0";

            txtPatAmount.Text = moneyDefault;
            txtPatOperatorId.Text = "0";
        }

    }
}
