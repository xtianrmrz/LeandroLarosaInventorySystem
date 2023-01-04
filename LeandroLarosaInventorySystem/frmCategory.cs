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
    public partial class frmCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmCategoryList flist;
        public frmCategory(frmCategoryList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblCategory Set category = @category Where ID Like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@category", txtbxCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been updated.");
                    flist.LoadCategory();
                    this.Dispose();
                }
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            bttnSave.Enabled = true;
            bttnUpdate.Enabled = false;
            txtbxCategory.Clear();
            txtbxCategory.Focus();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save this category?", "Save Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert Into tblCategory(category) Values (@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtbxCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been saved.");
                    Clear();
                    flist.LoadCategory();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
