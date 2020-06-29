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
            ShowAgent();
        }
        void ShowAgent()
        {
            comboBoxAgent.Items.Clear();
            foreach (Agent agent in Program.kv.Agent)
            {
                string[] item = { agent.Id.ToString() + ". " + agent.Surname + " " + agent.Name.Remove(1) + "." + agent.MiddleName.Remove(1) + "." };
                comboBoxAgent.Items.Add(string.Join("", item));
            }
        }
        void ShowExtradit()
        {
            listViewExtra.Items.Clear();
            foreach (Extradition extra in Program.kv.Extradition)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    extra.Id.ToString(), extra.Shipment.Material.Name, 
                    extra.Agent.Surname + " " + extra.Agent.Name.Remove(1) + ". " + extra.Agent.MiddleName.Remove(1) +".", extra.DateOfUssue.ToString(),
                    extra.Quantity.ToString()
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
                comboBoxMaterial.SelectedIndex = comboBoxMaterial.FindString(extra.Id_shipment.ToString());
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(extra.Id_agent.ToString());
                dateTimePickerEx.Value = extra.DateOfUssue.GetValueOrDefault();
                textBoxQuant.Text = extra.Quantity.ToString();
            }
            else
            {
                comboBoxMaterial.SelectedItem = null;
                comboBoxAgent.SelectedItem = null;
                dateTimePickerEx.Value = DateTime.Now;
                textBoxQuant.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewExtra.SelectedItems.Count == 1)
                {
                    Extradition extra = listViewExtra.SelectedItems[0].Tag as Extradition;
                    Program.kv.Extradition.Remove(extra);
                    Program.kv.SaveChanges();
                    ShowExtradit();
                }
                comboBoxMaterial.SelectedItem = null;
                comboBoxAgent.SelectedItem = null;
                dateTimePickerEx.Value = DateTime.Now;
                textBoxQuant.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowShipment()
        {
            comboBoxMaterial.Items.Clear();
            foreach(Shipment shipment in Program.kv.Shipment)
            {
                string[] item = { shipment.Id.ToString() + ". " + 
                        shipment.Material.Name + shipment.Provider.Surname + shipment.Provider.Name.Remove(1)+ ". "+ 
                        shipment.Provider.MiddleName.Remove(1)+"." + shipment.Date };
                comboBoxMaterial.Items.Add(string.Join("", item));
            }
        }
    }
}
