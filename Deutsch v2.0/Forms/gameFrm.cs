using Deutsch_v2._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deutsch_v2._0.Forms
{
    public partial class gameFrm : Form
    {
        handler h = new handler();
        static int probIdx = 0;

        public gameFrm(int saveId)
        {
            InitializeComponent();
            h.loadSave(saveId);
            h.loadQuestions();
            dWordLbl.Text = h.dWords[probIdx];
            this.ActiveControl = ansTxtbox;
            ansTxtbox.Focus();
            gameProg.Maximum = 10 * (h.to - h.from + 1);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (ansTxtbox.Text.ToLower() == h.eWords[probIdx].ToLower())
            {
                resLbl.Visible = true;
                resLbl.Text = "You're Goddamn Right!";
                cnBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value += 10;
            }
            else
            {
                resLbl.Visible = true;
                resLbl.Text = "Wrong the right answer is " + h.eWords[probIdx];
                cnBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value += 10;
            }
        }

        private void cnBtn_Click(object sender, EventArgs e)
        {
            probIdx++;
            if (probIdx > h.dWords.Count - 1)
            {
            }
            else
            {
                cnBtn.Visible = false;
                checkBtn.Visible = true;
                dWordLbl.Text = h.dWords[probIdx];
                resLbl.Visible = false;
                ansTxtbox.Text = "";
            }
        }

        private void ansTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                checkBtn_Click(sender, e);
                cnBtn.Focus();
            }
        }

        private void ansTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ansTxtbox.Text) == true)
                checkBtn.Enabled = false;
            else
                checkBtn.Enabled = true;
        }
    }
}
