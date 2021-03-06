﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_CA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            string str = textBox.Text.Trim();
            string[] temp = str.Split(' ');
            int m;
            List<int> in_sticks = new List<int>();
            try
            {
                foreach (string num in temp)
                {
                    in_sticks.Add(Convert.ToInt32(num));
                }
                m = Convert.ToInt32(tbInM.Text);
                if (m < 3)
                    throw new Exception("Error");
                Sticks st = new Sticks(in_sticks, m);
                if (st.Find())
                {
                    MessageBox.Show("Combination found:\n" + st.ResToStr(), "Message");
                }
                else
                {
                    MessageBox.Show("You cannot build a regular polygon from this data.", "Message");
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show("Incorrect sticks entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                in_sticks.Clear();
                textBox.Clear();
                tbInM.Clear();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            tbInM.Clear();
        }
    }
}
