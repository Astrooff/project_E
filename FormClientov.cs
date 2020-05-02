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
    public partial class FormClientov : Form
    {
        public FormClientov()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsSet clientsSet = new ClientsSet();
            clientsSet.Name = textBoxName.Text;
            clientsSet.SurName = textBoxSurName.Text;
            clientsSet.SecondName = textBoxLastName.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            Program.wftDb.ClientsSet.Add(clientsSet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }
         void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[] 
                {
                    clientsSet.Id.ToString(), clientsSet.Name, clientsSet.SecondName, clientsSet.SurName, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);

            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
     

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxName.Text = clientsSet.Name;
                textBoxSurName.Text = clientsSet.SurName;
                textBoxLastName.Text = clientsSet.SecondName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
               textBoxName.Text = "";
               textBoxSurName.Text = "";
               textBoxLastName.Text = "";
               textBoxPhone.Text = "";
               textBoxEmail.Text  = "";
            }
            }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                clientsSet.Name = textBoxName.Text;
                clientsSet.SurName = textBoxSurName.Text;
                clientsSet.SecondName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowClient();
            }    

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.wftDb.ClientsSet.Remove(clientsSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }
                textBoxName.Text = "";
                textBoxSurName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        private void FormClientov_Load(object sender, EventArgs e)
        {
           

        }
    }
}
