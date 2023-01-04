using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeandroLarosaInventorySystem
{
    public partial class frmSettle : Form
    {
        frmPOS fpos;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmSettle(frmPOS fp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = fp;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtbxCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = Double.Parse(txtbxSale.Text);
                double cash = Double.Parse(txtbxCash.Text);
                double change = cash - sale;
                txtbxChange.Text = change.ToString("#,##0.00");
            }
            catch(Exception ex)
            {
                txtbxChange.Text = "0.00";
            }
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn7.Text;
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn8.Text;
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn9.Text;
        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            txtbxCash.Clear();
            txtbxCash.Focus();
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn4.Text;
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn5.Text;
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn6.Text;
        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn0.Text;
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn1.Text;
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn2.Text;
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn3.Text;
        }

        private void bttn00_Click(object sender, EventArgs e)
        {
            txtbxCash.Text += bttn00.Text;
        }

        private void bttnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if((double.Parse(txtbxChange.Text) < 0) || (txtbxCash.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for(int z = 0; z < fpos.dataGridView1.Rows.Count; z++)
                    {
                        cn.Open();
                        cm = new SqlCommand("Update tblProduct Set Qty = Qty - " + int.Parse(fpos.dataGridView1.Rows[z].Cells[5].Value.ToString()) + "Where ProdCode = '" + fpos.dataGridView1.Rows[z].Cells[2].Value.ToString() + "'" , cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("Update tblCart Set Status = 'Sold' Where id ='" + fpos.dataGridView1.Rows[z].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }

                    MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fpos.GetTransNo();
                    fpos.LoadCart();
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Insufficient Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
