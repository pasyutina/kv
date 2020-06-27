using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kv
{
    public partial class FormSum : Form
    {
        public FormSum()
        {
            InitializeComponent();
            ShowShipment();
            ShowExtradit();
            ShowSum();
        }

        void ShowExtradit()
        {
                comboBoxExtra.Items.Clear();
                foreach (Extradition extra in Program.kv.Extradition)
                {
                    string[] item = { extra.Id.ToString() + extra.Id_agent + extra.DateOfUssue + extra.Quantity};
                }
         
        }
        void ShowSum()
        {
            listViewSum.Items.Clear();
            foreach (SummaryList sum in Program.kv.SummaryList)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sum.Id.ToString(),
                    sum.Extradition.Shipment.Material.ToString(),
                    sum.Extradition.Quantity.ToString(),
                    sum.Extradition.Shipment.Quantity.ToString(),
                    sum.Current_balance.ToString()
                }) ;
                item.Tag = sum;
                listViewSum.Items.Add(item);
            }
            listViewSum.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void listViewSum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxShip.SelectedItem != null && comboBoxExtra.SelectedItem != null
                && textBoxBalance.Text != "")
            {
                SummaryList sum = new SummaryList();
                sum.Extradition.Shipment.Id_material = Convert.ToInt32(comboBoxShip.SelectedItem.ToString().Split('.')[0]);
                sum.Id_Extradition = Convert.ToInt32(comboBoxExtra.SelectedItem.ToString().Split('.')[0]);
                sum.Current_balance = Convert.ToInt32(textBoxBalance.Text);
                Program.kv.SummaryList.Add(sum);
                Program.kv.SaveChanges();
                ShowSum();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSum.SelectedItems.Count == 1)
            {
                if (comboBoxShip.SelectedItem != null && comboBoxExtra.SelectedItem != null
              && textBoxBalance.Text != "")
                {
                    SummaryList sum = listViewSum.SelectedItems[0].Tag as SummaryList;
                    sum.Extradition.Shipment.Id_material = Convert.ToInt32(comboBoxShip.SelectedItem.ToString().Split('.')[0]);
                    sum.Id_Extradition = Convert.ToInt32(comboBoxExtra.SelectedItem.ToString().Split('.')[0]);
                    sum.Current_balance = Convert.ToInt32(textBoxBalance.Text);
                    Program.kv.SaveChanges();
                    ShowSum();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }
        void ShowShipment()
        {
            comboBoxShip.Items.Clear();
            foreach (Shipment shipment in Program.kv.Shipment)
            {
                string[] item = { shipment.Id.ToString() + shipment.Material + shipment.Provider + shipment.Date };
            }
        }
    }
}
