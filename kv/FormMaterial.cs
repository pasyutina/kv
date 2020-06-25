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
    public partial class FormMaterial : Form
    {
        public FormMaterial()
        {
            InitializeComponent();
            ShowMaterial();
        }

        void ShowMaterial()
        {
            listViewMaterial.Items.Clear();
            foreach (Material material in Program.kv.Material)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    material.Id.ToString(), material.Name, material.InventoryNumber.ToString(), material.Unit, material.Price.ToString()
                });
                item.Tag = material;
                listViewMaterial.Items.Add(item);
            }
            listViewMaterial.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMaterial.SelectedItems.Count == 1)
            {
                Material material = listViewMaterial.SelectedItems[0].Tag as Material;
                textBoxTitle.Text = material.Name;
                textBoxInventNumb.Text = material.InventoryNumber.ToString();
                textBoxUnit.Text = material.Unit;
                textBoxPrice.Text = material.Price.ToString();
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxInventNumb.Text = "";
                textBoxUnit.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Material material = new Material();
                material.Name = textBoxTitle.Text;
                material.Unit = textBoxUnit.Text;
                if (textBoxInventNumb.Text != "")
                {
                    material.InventoryNumber = Convert.ToInt32(textBoxInventNumb.Text);
                }
                if (textBoxPrice.Text != "")
                {
                    material.Price = Convert.ToInt32(textBoxPrice.Text);
                }
                if (material.Name == "" )
                {
                    throw new Exception("Обязательное заполнение наименования!");
                }
                Program.kv.Material.Add(material);
                Program.kv.SaveChanges();
                ShowMaterial();
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
                if (listViewMaterial.SelectedItems.Count == 1)
                {
                    Material material = listViewMaterial.SelectedItems[0].Tag as Material;
                    material.Name = textBoxTitle.Text;
                    material.Unit = textBoxUnit.Text;
                    if (textBoxInventNumb.Text != "")
                    {
                        material.InventoryNumber = Convert.ToInt32(textBoxInventNumb.Text);
                    }
                    if (textBoxPrice.Text != "")
                    {
                        material.Price = Convert.ToInt32(textBoxPrice.Text);
                    }
                    if (material.Name == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                    Program.kv.SaveChanges();
                    ShowMaterial();
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
                if (listViewMaterial.SelectedItems.Count == 1)
                {
                    Material material = listViewMaterial.SelectedItems[0].Tag as Material;
                    Program.kv.Material.Remove(material);
                    Program.kv.SaveChanges();
                    ShowMaterial();
                }
                textBoxTitle.Text = "";
                textBoxInventNumb.Text = "";
                textBoxUnit.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
