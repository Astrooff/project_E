﻿using System;
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
        void ShowAgents()
        {
            listViewAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.newDb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentsSet.Id.ToString(), agentsSet.Name, agentsSet.SecondName, agentsSet.SurName, 
                });
                item.Tag = agentsSet;
                listViewAgents.Items.Add(item);

            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void FormAgents_Load(object sender, EventArgs e)
        {
            AgentsSet agentsSet = new AgentsSet();
            agentsSet.Name = textBoxName.Text;
            agentsSet.SurName = textBoxSurName.Text;
            agentsSet.SecondName = textBoxSecondName.Text;
            Program.newDb.AgentsSet.Add(agentsSet);
            Program.newDb.SaveChanges();
            ShowAgents();
        }
    }
}