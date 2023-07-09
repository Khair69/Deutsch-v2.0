using Deutsch_v2._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deutsch_v2._0.Forms
{
    public partial class newSaveFrm : Form
    {
        static handler h = new handler();
        public newSaveFrm()
        {
            InitializeComponent();
            this.ActiveControl = saveTxtbox;
            saveTxtbox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(saveTxtbox.Text) == true || string.IsNullOrWhiteSpace(pathTxtBox.Text) == true)
            {
                MessageBox.Show("the name and path of the preset are required", "PLEASE FILL ALL FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(fromTxtbox.Text) == true && string.IsNullOrWhiteSpace(toTxtbox.Text) == true)
                {
                    h.newSave(saveTxtbox.Text, true, pathTxtBox.Text, 1, h.getnOfWords(pathTxtBox.Text));
                }
                else
                {
                    h.newSave(saveTxtbox.Text, true, pathTxtBox.Text, int.Parse(fromTxtbox.Text), int.Parse(toTxtbox.Text));
                }
                gameFrm gfrm = new gameFrm(h.id);
                gfrm.Show();
                this.Hide();
            }
        }

        private void saveTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                langCmb.Focus();
            }
        }

        private void pathTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                fromTxtbox.Focus();
            }
        }

        private void fromTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                toTxtbox.Focus();
            }
        }

        private void toTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                saveBtn_Click(sender, e);
            }
        }
    }
}
