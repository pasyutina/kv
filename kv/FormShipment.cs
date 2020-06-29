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
    public partial class FormShipment : Form
    {
        public FormShipment()
        {
            InitializeComponent();
            ShowShipment();
            ShowMaterial();
            ShowProvider();
        }

        void ShowMaterial()
        {
            comboBoxMaterial.Items.Clear();
            foreach (Material material in Program.kv.Material)
            {
                string[] item = { material.Id.ToString() + ". "+ material.Name + material.InventoryNumber.ToString() + material.Unit.ToString() + material.Price.ToString() };
                comboBoxMaterial.Items.Add(string.Join("", item));
            }
        }
        void ShowProvider()
        {
            comboBoxProvider.Items.Clear();
            foreach (Provider provider in Program.kv.Provider)
            {
                string[] item = { provider.Id.ToString() + ". " + provider.Surname + " " + provider.Name.Remove(1) + "."+ provider.MiddleName.Remove(1) + "."};
                comboBoxProvider.Items.Add(string.Join("", item));
            }
        }
        void ShowShipment()
        {
            listViewShipment.Items.Clear();
            foreach (Shipment ship in Program.kv.Shipment)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ship.Id.ToString(), ship.Material.Name, ship.Provider.Surname + " " + ship.Provider.Name.Remove(1) + ". " + ship.Provider.MiddleName.Remove(1), 
                    ship.Date.ToString(), ship.Quantity.ToString(), ship.Place, 
                    ship.TotalPrice.ToString()
                });
                item.Tag = ship;
                listViewShipment.Items.Add(item);
            }
            listViewShipment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewShipment.SelectedItems.Count == 1)
                {
                if (comboBoxMaterial.SelectedItem != null && comboBoxProvider.SelectedItem != null
               && textBoxQuantity.Text != "")
                {
                    Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                    ship.Id_material = Convert.ToInt32(comboBoxMaterial.SelectedItem.ToString().Split('.')[0]);
                    ship.Id_provider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                    ship.Date = dateTimePickerShip.Value;
                        if (textBoxQuantity.Text != "")
                        {
                            ship.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                        }
                        ship.Place = textBoxPlace.Text;
                        if (textBoxTotalPrice.Text != "")
                        {
                            ship.TotalPrice = Convert.ToInt32(textBoxTotalPrice.Text);
                        }
                        Program.kv.SaveChanges();
                    ShowShipment();
                }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMaterial.SelectedItem != null && comboBoxProvider.SelectedItem != null
                && textBoxQuantity.Text != "")
                {
                Shipment ship = new Shipment();
                ship.Id_material = Convert.ToInt32(comboBoxMaterial.SelectedItem.ToString().Split('.')[0]);
                ship.Id_provider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                ship.Date = dateTimePickerShip.Value;
                    if (textBoxQuantity.Text != "")
                    {
                        ship.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    }
                ship.Place = textBoxPlace.Text;
                if (textBoxTotalPrice.Text != "")
                {
                   ship.TotalPrice = Convert.ToInt32(textBoxTotalPrice.Text);
                }
                Program.kv.Shipment.Add(ship);
                Program.kv.SaveChanges();
                ShowShipment();
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
                if (listViewShipment.SelectedItems.Count == 1)
                {
                    Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                    Program.kv.Shipment.Remove(ship);
                    Program.kv.SaveChanges();
                    ShowShipment();
                }
                comboBoxMaterial.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
                dateTimePickerShip.Value = DateTime.Now;
                textBoxQuantity.Text = "";
                textBoxPlace.Text = "";
                textBoxTotalPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShipment.SelectedItems.Count == 1)
            {
                Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                comboBoxMaterial.SelectedIndex = comboBoxMaterial.FindString(ship.Id_material.ToString());
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(ship.Id_provider.ToString());
                dateTimePickerShip.Value = ship.Date.GetValueOrDefault();
                textBoxQuantity.Text = ship.Quantity.ToString();
                textBoxPlace.Text = ship.Place.ToString();
                textBoxTotalPrice.Text = ship.TotalPrice.ToString();
            }
            else
            {
                comboBoxMaterial.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
                dateTimePickerShip.Value = DateTime.Now;
                textBoxQuantity.Text = "";
                textBoxPlace.Text = "";
                textBoxTotalPrice.Text = "";
            }
        }
    }
}
