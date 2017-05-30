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
    public partial class Form1 : Form
    {
        String[] abc= new String [6];
   private DataTable tableData;
        public Form1()
        {
            InitializeComponent();
        }

        private void tab_View_BackOffice_Click(object sender, EventArgs e)
        {
            BackOffice bo = new BackOffice();
            bo.Show();
    
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                abc[0] = txt_ID.Text;
                abc[1] = txt_ino.Text;
                abc[2] = txt_Name.Text;
                abc[3] = "fuck";
                abc[4] = txt_Qty.Text; 
                abc[5] = txt_Amt.Text;
                table_Invoice.Rows.Add(abc);

                this.ActiveControl = txt_ID;
            }
        }

        private void txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.ActiveControl = txt_ino;
            }
        }

        private void txt_ino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.ActiveControl = txt_Qty;
            }
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.ActiveControl = txt_Amt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkout co = new checkout();
            co.Show();
        }
    }
}
