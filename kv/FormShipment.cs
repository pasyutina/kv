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
        }

        void ShowShipment()
        {
            listViewShipment.Items.Clear();
            foreach (Shipment ship in Program.kv.Shipment)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ship.Id.ToString(), ship.Id_material.ToString(), ship.Id_provider.ToString(), 
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
            if (listViewShipment.SelectedItems.Count == 1)
            {
                if (comboBoxMaterial.SelectedItem != null && comboBoxProvider.SelectedItem != null
               && textBoxQuantity.Text != "")
                {
                    Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                    ship.Id_material = Convert.ToInt32(comboBoxMaterial.SelectedItem.ToString().Split('.')[0]);
                    ship.Id_provider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                    ship.Date = dateTimePickerShip.Value;
                    ship.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    ship.Place = textBoxPlace.Text;
                    ship.TotalPrice = Convert.ToInt32(textBoxTotalPrice.Text);
                    Program.kv.SaveChanges();
                    ShowShipment();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedItem != null && comboBoxProvider.SelectedItem != null
                && textBoxQuantity.Text != "")
            {
                Shipment ship = new Shipment();
                ship.Material.Name = comboBoxMaterial.SelectedItem.ToString().Split('.')[0];
                ship.Provider.Name = comboBoxProvider.SelectedItem.ToString().Split('.')[0];
                ship.Date = dateTimePickerShip.Value;
                ship.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                Program.kv.Shipment.Add(ship);
                Program.kv.SaveChanges();
                ShowShipment();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewShipment.SelectedItems.Count == 1)
            {
                Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                Program.kv.Shipment.Remove(ship);
                Program.kv.SaveChanges();
            }
        }

        private void FormShipment_Load(object sender, EventArgs e)
        {

        }

        private void listViewShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShipment.SelectedItems.Count == 1)
            {
                Shipment ship = listViewShipment.SelectedItems[0].Tag as Shipment;
                comboBoxMaterial.SelectedIndex = comboBoxMaterial.FindString(ship.Material.ToString());
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(ship.Provider.ToString());
            }
            else
            {
                comboBoxMaterial.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
            }
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
