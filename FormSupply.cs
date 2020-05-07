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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.wftDb.AgentsSet)
            {
                string[] item =
                {
                    agentsSet.Id.ToString()+".",
                    agentsSet.Name,
                    agentsSet.SurName
                };
                comboBoxAgents.Items.Add(string.Join(" ", item));

            }

        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item =
                {
                    clientsSet.Id.ToString()+".",
                    clientsSet.Name,
                     clientsSet.SurName
                };
                comboBoxClients.Items.Add(string.Join(" ", item));

            }

        }
        void ShowRealEstate()
        {
            //очистка
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstatesSet in Program.wftDb.RealEstateSet)
            {
                string[] item =
                {
                   realEstatesSet.Id.ToString()+".",
                    realEstatesSet.Address_City+",",
                     realEstatesSet.Address_Street+",",
                     "д. "+realEstatesSet.Address_House+",",
                    "кв. "+realEstatesSet.Address_Number
                };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));

            }

        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(),
                    supply.AgentsSet.SurName+" "+supply.AgentsSet.Name+" ",
                    supply.IdClient.ToString(),
                    supply.ClientsSet.SurName+" "+supply.ClientsSet.Name,
                    supply.IdRealEstate.ToString(),
                    supply.RealEstateSet.Address_City+""+
                    supply.RealEstateSet.Address_Street+""
                    +supply.RealEstateSet.Address_House+""
                    +supply.RealEstateSet.Address_Number,
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null &&
                comboBoxClients.SelectedItem != null &&
                comboBoxRealEstate.SelectedItem != null &&
                textBoxPrice.Text != " ")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate.SelectedItem != null && textBoxPrice.Text != " ")
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                    supply.Price = Convert.ToInt64(textBoxPrice.Text);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();

            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = " ";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("данные не удаляются", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
