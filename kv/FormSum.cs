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
            ShowExtradit();
            ShowSum();
        }

        void ShowExtradit()
        {
                comboBoxExtra.Items.Clear();
                foreach (Extradition extra in Program.kv.Extradition)
                {
                    string[] item = { extra.Id.ToString() + ". " +
                        extra.Shipment.Material.Name + " " +
                         ", " + extra.Quantity};
                    comboBoxExtra.Items.Add(string.Join("", item));
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
                    sum.Extradition.Shipment.Material.Name+ ", " +
                    sum.Extradition.Quantity.ToString(),
                    sum.Current_balance.ToString()
                }) ;
                item.Tag = sum;
                listViewSum.Items.Add(item);
            }
            listViewSum.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void listViewSum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSum.SelectedItems.Count == 1)
            {
                SummaryList sum = listViewSum.SelectedItems[0].Tag as SummaryList;
                comboBoxExtra.SelectedIndex = comboBoxExtra.FindString(sum.Id_Extradition.ToString().Split('.')[0]);
                textBoxBalance.Text = sum.Current_balance.ToString();
            }
            else
            {
                comboBoxExtra.SelectedItem = null;
                textBoxBalance.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxExtra.SelectedItem != null && textBoxBalance.Text != "")
                {
                    SummaryList sum = new SummaryList();
                    sum.Id_Extradition = Convert.ToInt32(comboBoxExtra.SelectedItem.ToString().Split('.')[0]);
                    
                        sum.Current_balance = Convert.ToInt32(textBoxBalance.Text);
                    
                    Program.kv.SummaryList.Add(sum);
                    Program.kv.SaveChanges();
                    ShowSum();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSum.SelectedItems.Count == 1)
                {
                    if (comboBoxExtra.SelectedItem != null && textBoxBalance.Text != "")
                    {
                        SummaryList sum = listViewSum.SelectedItems[0].Tag as SummaryList;
                        sum.Id_Extradition = Convert.ToInt32(comboBoxExtra.SelectedItem.ToString().Split('.')[0]);
                        sum.Current_balance = Convert.ToInt32(textBoxBalance.Text);
                        Program.kv.SaveChanges();
                        ShowSum();
                    }
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
                if (listViewSum.SelectedItems.Count == 1)
                {
                    SummaryList sum = listViewSum.SelectedItems[0].Tag as SummaryList;
                    Program.kv.SummaryList.Remove(sum);
                    Program.kv.SaveChanges();
                    ShowSum();
                }
                comboBoxExtra.SelectedItem = null;
                textBoxBalance.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
