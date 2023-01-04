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
    public partial class frmPOS : Form
    {
        String id;
        String Price;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Point of Sale System";
        public frmPOS()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Now.ToLongDateString();
            this.KeyPreview = true;
        }

        public void GetTransNo()
        {
            try
            {
                string SDate = DateTime.Now.ToString("yyyyMMdd");
                String TransNo;
                int Count;

                cn.Open();
                cm = new SqlCommand("Select Top 1 TransNo From tblCart Where TransNo Like '" + SDate + "%' Order By ID Desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    TransNo = dr[0].ToString();
                    Count = int.Parse(TransNo.Substring(8, 4));
                    lblTransNo.Text = SDate + (Count + 1);
                }
                else
                {
                    TransNo = SDate + "1001";
                    lblTransNo.Text = TransNo;
                }
                dr.Close();
                cn.Close();
                
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            GetTransNo();
            txtbxSearch.Enabled = true;
            txtbxSearch.Focus();
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtbxSearch.Text == String.Empty)
                {
                    return;

                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("Select * From tblProduct Where BarCode Like '" + txtbxSearch.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        frmQty frm = new frmQty(this);
                        frm.ProductDetails(dr["ProdCode"].ToString(), double.Parse(dr["Price"].ToString()), lblTransNo.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadCart()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                int z = 0;
                double total = 0;
                double discount = 0;
                cn.Open();
                cm = new SqlCommand("Select c.id, c.ProdCode, p.Pdesc, c.Price, c.Qty, c.Disc, c.Total From tblCart as c INNER JOIN tblProduct as p on c.ProdCode = p.ProdCode Where TransNo Like '" + lblTransNo.Text + "' And Status Like 'Pending'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    z++;
                    total += Double.Parse(dr["Total"].ToString());
                    discount += Double.Parse(dr["Disc"].ToString());
                    dataGridView1.Rows.Add(z, dr["id"].ToString(), dr["ProdCode"].ToString(), dr["PDesc"].ToString(), dr["Price"].ToString(), dr["Qty"].ToString(), dr["Disc"].ToString(), Double.Parse(dr["Total"].ToString()).ToString("#,##0.00"));
                    hasrecord = true;
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if(hasrecord == true)
                {
                    bttnSettle.Enabled = true;
                    bttnDiscount.Enabled = true;
                }
                else
                {
                    bttnSettle.Enabled = false;
                    bttnDiscount.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if(lblTransNo.Text == "000000000000")
            {
                return;
            }
            frmLookUp frm = new frmLookUp(this);
            frm.LoadRecords();
            frm.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from tblCart Where id Like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been deleted.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        public void GetCartTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotal.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        private void bttnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount(this);
            frm.lblID.Text = id;
            frm.txtbxPrice.Text = Price;
            frm.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int z = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, z].Value.ToString();
            Price = dataGridView1[3, z].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate1.Text = DateTime.Now.ToLongDateString();
        }

        private void bttnSettle_Click(object sender, EventArgs e)
        {
            frmSettle frm = new frmSettle(this);
            frm.txtbxSale.Text = lblDisplayTotal.Text;
            frm.ShowDialog();
        }
    }
}
