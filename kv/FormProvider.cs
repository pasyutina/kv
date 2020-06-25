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
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
            ShowProvider();
        }

        void ShowProvider()
        {
            listViewProvider.Items.Clear();
            foreach (Provider provider in Program.kv.Provider)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    provider.Id.ToString(), provider.Surname, provider.Name, provider.MiddleName, provider.Cost.ToString()
                });
                item.Tag = provider;
                listViewProvider.Items.Add(item);
            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                Provider agentSet = listViewProvider.SelectedItems[0].Tag as Provider;
                textBoxSurName.Text = agentSet.Surname;
                textBoxFirstName.Text = agentSet.Name;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxCost.Text = agentSet.Cost.ToString();
            }
            else
            {
                textBoxSurName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxCost.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Provider provider = new Provider();
                provider.Surname = textBoxSurName.Text;
                provider.Name = textBoxFirstName.Text;
                provider.MiddleName = textBoxMiddleName.Text;
                if (textBoxCost.Text != "")
                {
                    provider.Cost = Convert.ToInt32(textBoxCost.Text);
                }
                if (provider.Surname == "" || provider.Name == "" || provider.MiddleName == "")
                {
                    throw new Exception("Обязательное заполнение полей ФИО!");
                }
                Program.kv.Provider.Add(provider);
                Program.kv.SaveChanges();
                ShowProvider();
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
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    Provider provider = listViewProvider.SelectedItems[0].Tag as Provider;
                    provider.Surname = textBoxSurName.Text;
                    provider.Name = textBoxFirstName.Text; 
                    provider.MiddleName = textBoxMiddleName.Text;
                    if (textBoxCost.Text != "")
                    {
                        provider.Cost = Convert.ToInt32(textBoxCost.Text);
                    }
                    if (provider.Surname == "" || provider.MiddleName == "" || provider.Name == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                    Program.kv.SaveChanges();
                    ShowProvider();
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
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    Provider provider = listViewProvider.SelectedItems[0].Tag as Provider;
                    Program.kv.Provider.Remove(provider);
                    Program.kv.SaveChanges();
                    ShowProvider();
                }
                textBoxSurName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxCost.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
