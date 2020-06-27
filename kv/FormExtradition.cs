using System;
using System.Windows.Forms;

namespace kv
{
    public partial class FormExtradition : Form
    {
        public FormExtradition()
        {
            InitializeComponent();
            ShowShipment();
            ShowExtradit();
        }

        void ShowExtradit()
        {
            listViewExtra.Items.Clear();
            foreach (Extradition extra in Program.kv.Extradition)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    extra.Id.ToString(), extra.Id_shipment.ToString(), extra.Id_agent.ToString(), extra.DateOfUssue.ToString(), extra.Quantity.ToString()
                });
                item.Tag = extra;
                listViewExtra.Items.Add(item);
            }
            listViewExtra.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewExtra.SelectedItems.Count == 1)
            {
                Extradition extra = listViewExtra.SelectedItems[0].Tag as Extradition;
                comboBoxMaterial.SelectedIndex = comboBoxMaterial.FindString(extra.Shipment.Material.Name);
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(extra.Agent.Name.ToString());
            }
            else
            {
                comboBoxMaterial.SelectedItem = null;
                comboBoxAgent.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedItem != null && comboBoxAgent.SelectedItem != null
                && textBoxQuant.Text != "")
            {
                Extradition extra = new Extradition();
                extra.Id_shipment = Convert.ToInt32(comboBoxMaterial.SelectedItem.ToString().Split('.')[0]);
                extra.Id_agent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                extra.DateOfUssue = dateTimePickerEx.Value;
                extra.Quantity = Convert.ToInt32(textBoxQuant.Text);
                Program.kv.Extradition.Add(extra);
                Program.kv.SaveChanges();
                ShowExtradit();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewExtra.SelectedItems.Count == 1)
            {
                Extradition extra = listViewExtra.SelectedItems[0].Tag as Extradition;
                Program.kv.Extradition.Remove(extra);
                Program.kv.SaveChanges();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewExtra.SelectedItems.Count == 1)
            {
                if (comboBoxMaterial.SelectedItem != null && comboBoxAgent.SelectedItem != null
               && textBoxQuant.Text != "")
                {
                    Extradition extra = listViewExtra.SelectedItems[0].Tag as Extradition;
                    extra.Id_shipment = Convert.ToInt32(comboBoxMaterial.SelectedItem.ToString().Split('.')[0]);
                    extra.Id_agent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    extra.DateOfUssue = dateTimePickerEx.Value;
                    extra.Quantity = Convert.ToInt32(textBoxQuant.Text);
                    Program.kv.SaveChanges();
                    ShowExtradit();
                }
            }
        }
        void ShowShipment()
        {
            comboBoxMaterial.Items.Clear();
            foreach(Shipment shipment in Program.kv.Shipment)
            {
                string[] item = { shipment.Id.ToString() + shipment.Material + shipment.Provider + shipment.Date };
                comboBoxMaterial.Items.Add(string.Join("", item));
            }
        }
    }
}
