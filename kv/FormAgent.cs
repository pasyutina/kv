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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (Agent agentSet in Program.kv.Agent)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentSet.Id.ToString(), agentSet.Surname, agentSet.Name,agentSet.MiddleName, agentSet.Phone, agentSet.Email, agentSet.Term.ToString(), agentSet.Position, agentSet.Department
                });
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                Agent agentSet = listViewAgent.SelectedItems[0].Tag as Agent;
                textBoxSurname.Text = agentSet.Surname;
                textBoxName.Text = agentSet.Name;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxPhone.Text = agentSet.Phone;
                textBoxEmail.Text = agentSet.Email;
                textBoxTerm.Text = agentSet.Term.ToString();
                textBoxPosition.Text = agentSet.Position;
                comboBoxDepart.SelectedItem = agentSet.Department;
            }
            else
            {
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxTerm.Text = "";
                textBoxPosition.Text = "";
                comboBoxDepart.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Agent agentSet = new Agent();
                agentSet.Surname = textBoxSurname.Text;
                agentSet.Name = textBoxName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.Phone = textBoxPhone.Text;
                agentSet.Email = textBoxEmail.Text;
                agentSet.Position = textBoxPosition.Text;
               
                if (textBoxTerm.Text != "")
                {
                    agentSet.Term = Convert.ToInt32(textBoxTerm.Text);
                }
                if (agentSet.Surname == "" || agentSet.Name == "" || agentSet.MiddleName == "")
                {
                    throw new Exception("Обязательное заполнение полей ФИО!");
                }
                
                Program.kv.Agent.Add(agentSet);
                Program.kv.SaveChanges();
                ShowAgent();
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
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    Agent agentSet = listViewAgent.SelectedItems[0].Tag as Agent;
                    agentSet.Surname = textBoxSurname.Text;
                    agentSet.Name = textBoxName.Text;
                    agentSet.MiddleName = textBoxMiddleName.Text;
                    agentSet.Phone = textBoxPhone.Text;
                    agentSet.Email = textBoxEmail.Text;
                    agentSet.Position = textBoxPosition.Text;
                    if (textBoxTerm.Text != "")
                    {
                        agentSet.Term = Convert.ToInt32(textBoxTerm.Text);
                    }
                    if (agentSet.Surname == "" || agentSet.Name == "" || agentSet.MiddleName == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                   
                    Program.kv.SaveChanges();
                    ShowAgent();
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
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    Agent agentSet = listViewAgent.SelectedItems[0].Tag as Agent;
                    Program.kv.Agent.Remove(agentSet);
                    Program.kv.SaveChanges();
                    ShowAgent();
                }
                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxTerm.Text = "";
                textBoxPosition.Text = "";
                comboBoxDepart.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
