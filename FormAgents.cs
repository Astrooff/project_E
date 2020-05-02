using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_E
{
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowAgents();
        }
        
        private void FormAgents_Load(object sender, EventArgs e)
        {
        }
        void ShowAgents()
        {
            listViewAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.wftDb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentsSet.Id.ToString(), agentsSet.Name, agentsSet.SecondName, agentsSet.SurName,  agentsSet.DealShare.ToString()
            });

                item.Tag = agentsSet;
                listViewAgents.Items.Add(item);

            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonAdd_Click(object sender, EventArgs e)//кнопка добавить
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.Text = "-";
            }
            if (String.IsNullOrEmpty(textBoxSurName.Text))
            {
                textBoxSurName.Text = "-";
            }
            if (String.IsNullOrEmpty(textBoxSecondName.Text))
            {
                textBoxSecondName.Text = "-";
            }
            if (String.IsNullOrEmpty(textBoxDealShare.Text))
            {
                textBoxDealShare.Text = "0";
            }
            AgentsSet agentsSet = new AgentsSet();
            agentsSet.Name = textBoxName.Text;
            agentsSet.SurName = textBoxSurName.Text;
            agentsSet.SecondName = textBoxSecondName.Text;
            agentsSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            
            Program.wftDb.AgentsSet.Add(agentsSet);
            Program.wftDb.SaveChanges();
            ShowAgents();
        }

        private void textBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }//добавление условия ввода только цифр

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider1.SetError(textBoxName, "Это обязательное поле для заполнения");
            }
            else
            {
                errorProvider1.Clear();
            }
        }//вывод сообщения о том что поля обязательны к заполнению

        private void textBoxSurName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider1.SetError(textBoxName, "Это обязательное поле для заполнения");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (String.IsNullOrEmpty(textBoxSurName.Text))
            {
                errorProvider2.SetError(textBoxSurName, "Это обязательное поле для заполнения");
            }
            else
            {
                errorProvider2.Clear();
            }
        }//вывод сообщения о том что поля обязательны к заполнению

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSurName.Text))
            {
                errorProvider2.SetError(textBoxSurName, "Это обязательное поле для заполнения");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (String.IsNullOrEmpty(textBoxSecondName.Text))
            {
                errorProvider3.SetError(textBoxSecondName, "Это обязательное поле для заполнения");
            }
            else
            {
                errorProvider3.Clear();
            }
        }//вывод сообщения о том что поля обязательны к заполнению

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                agentsSet.Name = textBoxName.Text;
                agentsSet.SurName = textBoxSurName.Text;
                agentsSet.SecondName = textBoxSecondName.Text;
                agentsSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wftDb.SaveChanges();
                ShowAgents();
            }
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                textBoxName.Text = agentsSet.Name;
                textBoxSurName.Text = agentsSet.SurName;
                textBoxSecondName.Text = agentsSet.SecondName;
                textBoxDealShare.Text = Convert.ToString(agentsSet.DealShare);
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurName.Text = "";
                textBoxSecondName.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    Program.wftDb.AgentsSet.Remove(agentsSet);
                    Program.wftDb.SaveChanges();
                    ShowAgents();
                }
                textBoxName.Text = "";
                textBoxSurName.Text = "";
                textBoxSecondName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
