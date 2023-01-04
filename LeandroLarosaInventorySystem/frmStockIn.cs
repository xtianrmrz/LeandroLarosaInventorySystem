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
    public partial class frmStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Point of Sale System";

        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        

        public void LoadStockIn()
        {
            int z = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from vwStockIn Where RefNo Like '" + txtbxRefNo.Text + "' and status like 'Pending'", cn);
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
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colSelect")
            {
                if (txtbxRefNo.Text == String.Empty)
                {
                    MessageBox.Show("Enter Reference #", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxRefNo.Focus();
                    return;
                }
                if (txtbxStockInBy.Text == String.Empty)
                {
                    MessageBox.Show("Enter Stock In By", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxStockInBy.Focus();
                    return;
                }
                if (MessageBox.Show("Add this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert Into tblStockIn (RefNo, ProdCode, SDate, StockInBy) Values(@Refno, @ProdCode, @SDate, @StockInBy)", cn);
                    cm.Parameters.AddWithValue("@RefNo", txtbxRefNo.Text);
                    cm.Parameters.AddWithValue("@ProdCode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@SDate", Dt1.Value);
                    cm.Parameters.AddWithValue("@StockInBy", txtbxStockInBy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Added succesfully!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }


    }

    private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colDelete")
            {
                if(MessageBox.Show("Delete item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete From tblStockIn Where id = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Removed succesfully!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearchProduct_StockIn frm = new frmSearchProduct_StockIn(this);
            frm.LoadProduct();
            frm.ShowDialog();
        }

        public void Clear()
        {
            txtbxStockInBy.Clear();
            txtbxRefNo.Clear();
            Dt1.Value = DateTime.Now;
        }

        private void LoadStockInHistory()
        {
            int z = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * from vwStockIn Where cast(SDate as date) Between '" + Date1.Value.ToShortDateString() + "' And '" + Date2.Value.ToShortDateString() + "' And  status like 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                z++;
                dataGridView2.Rows.Add(z, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int z = 0; z < dataGridView1.Rows.Count; z++)
                        {
                            //Updating tblProduct qty
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct Set Qty = Qty + " + int.Parse(dataGridView1.Rows[z].Cells[5].Value.ToString()) + " Where ProdCode Like '" + dataGridView1.Rows[z].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //Updating tblStockIn qty
                            cn.Open();
                            cm = new SqlCommand("Update tblStockIn Set Qty = Qty + " + int.Parse(dataGridView1.Rows[z].Cells[5].Value.ToString()) + ", Status = 'Done' Where ID Like '" + dataGridView1.Rows[z].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }
    }
}
