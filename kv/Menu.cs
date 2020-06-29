using System;
using System.Windows.Forms;

namespace kv
{
    public partial class Menu : Form
    {
        private FormAuthorization formAuthorization;
        public Menu(FormAuthorization formAuthorization)
        {
            InitializeComponent();
            this.formAuthorization = formAuthorization;
            if (FormAuthorization.users.type == "agent")
            {
                buttonAgents.Enabled = false;
                buttonProvider.Enabled = false;
                buttonPriem.Enabled = false;
                buttonNal.Enabled = false;
            }
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
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

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAuthorization.Show();
        }
    }
}
