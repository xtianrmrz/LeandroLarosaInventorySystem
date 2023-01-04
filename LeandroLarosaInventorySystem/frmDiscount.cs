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
    public partial class frmDiscount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string stitle = "Point of Sale";
        frmPOS f;
        public frmDiscount(frmPOS frm)
        {
            InitializeComponent();
            f = frm;
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtbxPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Discount = Double.Parse(txtbxPrice.Text) * Double.Parse(txtbxPercent.Text);
                txtbxAmount.Text = Discount.ToString("#,##0.00");
            }
            catch(Exception ex)
            {
                txtbxAmount.Text = "0.00";
            }
        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Add discount?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblCart Set Disc = @Disc Where id = @id", cn);
                    cm.Parameters.AddWithValue("@Disc", Double.Parse(txtbxAmount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    f.LoadCart();
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
