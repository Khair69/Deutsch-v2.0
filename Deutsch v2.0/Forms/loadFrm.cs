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
    public partial class loadFrm : Form
    {
        static handler h = new handler();
        public loadFrm()
        {
            InitializeComponent();    
            h.getSaves();
            savesCmb.Items.AddRange(h.getSaves().ToArray());
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int selectedId = savesCmb.SelectedIndex + 1;
            gameFrm gfrm = new gameFrm(selectedId);
            gfrm.Show();
            this.Hide();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //int selectedId = savesCmb.SelectedIndex + 1;
            //h.delSave(selectedId);
        }
    }
}
