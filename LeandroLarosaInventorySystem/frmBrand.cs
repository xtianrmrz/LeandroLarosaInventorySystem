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
    public partial class frmBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList frmlist;
        public frmBrand(frmBrandList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void Clear()
        {
            bttnSave.Enabled = true;
            bttnUpdate.Enabled = false;
            txtbxBrand.Clear();
            txtbxBrand.Focus();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert into tblBrand(Brand) Values(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtbxBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been saved.");
                    Clear();
                    frmlist.LoadRecords();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update brand?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblBrand Set Brand = @brand Where ID Like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@brand", txtbxBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been updated.");
                    Clear();
                    frmlist.LoadRecords();
                    this.Dispose();
                }
                
            }
            catch(Exception ex)
            {
                
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
