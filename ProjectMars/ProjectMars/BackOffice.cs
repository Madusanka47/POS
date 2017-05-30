using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMars
{
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        private void BackOffice_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void toolSrtip_itemShearch_Click(object sender, EventArgs e)
        {
            ItemWiseShearch iws = new ItemWiseShearch();
            iws.Show();


        }
    }
}
