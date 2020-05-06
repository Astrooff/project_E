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
    public partial class Demands : Form
    {
        public Demands()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRES();
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
        void ShowSupplySet()
        {
            listViewRealEstateSet_Appartaments.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  demand.IdAgent.ToString(),
                  demand.IdClient.ToString(),
                  demand.Type.ToString(),
                  demand.MinPrice.ToString(),
                  demand.MaxPrice.ToString(),
                  demand.MaxRooms.ToString(),
                  demand.MinRooms.ToString(),
                  demand.MinArea.ToString(),
                  demand.MaxArea.ToString(),
                  demand.MinFloor.ToString(),
                });
                item.Tag = demand;
                listViewRealEstateSet_Appartaments.Items.Add(item);
            }
        }
        void ShowRES()
        {
            listViewRealEstateSet_Appartaments.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demand.IdAgent.ToString(),
                         demand.IdClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                         demand.MinRooms.ToString(),
                         demand.MaxRooms.ToString(),
                         demand.MinFloor.ToString(),
                         demand.MaxFloor.ToString(),
                     });
                    item.Tag = demand;
                    listViewRealEstateSet_Appartaments.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demand.IdAgent.ToString(),
                         demand.IdClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                         demand.MinRooms.ToString(),
                         demand.MaxRooms.ToString(),
                         demand.MinFloors.ToString(),
                         demand.MaxFloors.ToString(),
                     });
                    item.Tag = demand;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else if (demand.Type == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                      {
                         demand.IdAgent.ToString(),
                         demand.IdClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                       });
                    item.Tag = demand;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            listViewRealEstateSet_Appartaments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxAgents.SelectedItem != null &&
                comboBoxClients.SelectedItem != null &&
                comboBoxType.SelectedItem != null)

            {
                DemandSet demand = new DemandSet();
                demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    demand.Type = 1;
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMinFloors.Text);
                }
                else
                {
                    demand.Type = 2;
                }
                Program.wftDb.DemandSet.Add(demand);
                Program.wftDb.SaveChanges();
                ShowRES();

            }

            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void comboBoxRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewRealEstateSet_Appartaments.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                listViewRealEstateSet_Appartaments.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
            else
            {
                listViewRealEstateSet_Land.Visible = true;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                listViewRealEstateSet_Appartaments.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Appartaments.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Appartaments.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRES();

                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = " ";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";

                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRES();
                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = " ";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRES();
                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show(" не возможно удалить");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Appartaments.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Appartaments.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 0;
                        demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                        demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                        demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                        demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                        Program.wftDb.SaveChanges();
                        ShowRES();
                    }
                }
                else if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 1;
                        demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        demand.MaxFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        Program.wftDb.SaveChanges();
                        ShowRES();
                    }
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 2;
                        Program.wftDb.SaveChanges();
                        ShowRES();
                    }
                }
            }
        }
    }
}
