using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FormList : Form
    {
        NouvelleTache nl;
        Tache t;
        public FormList()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            t.AjoutTache();
        }

        private void btnMajTache_Click(object sender, EventArgs e)
        {
            t.MajTache();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            t.SuppTache();
        }
    }
}
