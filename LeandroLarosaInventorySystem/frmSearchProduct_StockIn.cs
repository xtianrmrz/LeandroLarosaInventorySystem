using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LeandroLarosaInventorySystem
{
    public partial class frmSearchProduct_StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Point of Sale System";
        frmStockIn slist;
        public frmSearchProduct_StockIn(frmStockIn flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            slist = flist; 
        }

        public void LoadProduct()
        {
            int z = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select ProdCode, PDesc, Qty from tblProduct Where PDesc Like '%" + txtbxSearch.Text + "%' Order By PDesc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                z++;
                dataGridView1.Rows.Add(z, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colSelect")
            {
                if (slist.txtbxRefNo.Text == String.Empty)
                {
                    MessageBox.Show("Enter Reference #", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slist.txtbxRefNo.Focus();
                    return;
                }
                if (slist.txtbxStockInBy.Text == String.Empty)
                {
                    MessageBox.Show("Enter Stock In By", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slist.txtbxStockInBy.Focus();
                    return;
                }
                if (MessageBox.Show("Add this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert Into tblStockIn (RefNo, ProdCode, SDate, StockInBy) Values(@Refno, @ProdCode, @SDate, @StockInBy)", cn);
                    cm.Parameters.AddWithValue("@RefNo", slist.txtbxRefNo.Text);
                    cm.Parameters.AddWithValue("@ProdCode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@SDate", slist.Dt1.Value);
                    cm.Parameters.AddWithValue("@StockInBy", slist.txtbxStockInBy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Added succesfully!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    slist.LoadStockIn();
                }
            }
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
