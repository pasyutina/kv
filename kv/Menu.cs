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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form agentSet = new FormAgent();
            agentSet.Show();
        }

        private void buttonPriem_Click(object sender, EventArgs e)
        {
            Form shipment = new FormShipment();
            shipment.Show();
        }

        private void buttonNal_Click(object sender, EventArgs e)
        {
            Form material = new FormMaterial();
            material.Show();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            Form provider = new FormProvider();
            provider.Show();
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            Form extradition = new FormExtradition();
            extradition.Show();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Form summary = new FormSum();
            summary.Show();
        }
    }
}
