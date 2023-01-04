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
    public partial class frmProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public frmProductList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this);
            frm.bttnSave.Enabled = true;
            frm.bttnUpdate.Enabled = false;
            frm.LoadBrand();
            frm.LoadCategory();
            frm.ShowDialog();
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        public void LoadRecords()
        {
            int z = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select p.ProdCode, p.BarCode, p.PDesc, b.Brand, c.Category, P.Price, P.Qty from tblProduct As p Inner Join tblBrand As b On b.ID = p.BrandID Inner Join tblCategory As c On c.ID = p.CatID Where P.Pdesc Like '" + txtbxSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                z++;
                dataGridView1.Rows.Add(z, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                frmProduct frm = new frmProduct(this);
                frm.bttnSave.Enabled = false;
                frm.bttnUpdate.Enabled = true;
                frm.txtbxProdCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtbxBarCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtbxDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.cboBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.cboCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtbxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete From tblProduct Where ProdCode Like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadRecords();
                }
            }
        }
    }
}
