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
    public partial class CashRegister : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        int a=0;
        string[] c= new string[2];
        string g ;
      

        public CashRegister()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt_date.Text = DateTime.Now.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(a + 1);
            dataGridView1.Rows[a].Cells[0].Value = txt_item.Text;
              
              dataGridView1.Rows[a].Cells[2].Value = txt_qty.Text;

            db.singleData("select Discription,Unit_Price from inventory where item_Code='" + txt_item.Text + "'");
            dataGridView1.Rows[a].Cells[1].Value = db.a;
            dataGridView1.Rows[a].Cells[3].Value = db.b;
            double x = Convert.ToDouble(txt_qty.Text);
            double y= Convert.ToDouble(db.b);
            dataGridView1.Rows[a].Cells[4].Value = (x*y).ToString();
            a = a + 1;
            
            txt_item.Clear();
             txt_qty.Clear();

        }
    }
}
