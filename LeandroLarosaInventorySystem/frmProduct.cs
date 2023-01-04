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
using System.Diagnostics;

namespace LeandroLarosaInventorySystem
{
    
    public partial class frmProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList flist;
        public frmProduct(frmProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cn.Open();
            cm = new SqlCommand("Select category From tblCategory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cn.Open();
            cm = new SqlCommand("Select brand From tblBrand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboBrand.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string BrandID = "", CatID = "";

                    cn.Open();
                    cm = new SqlCommand("Select ID from tblBrand Where Brand Like '" + cboBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { BrandID = dr[0].ToString();}
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select ID from tblCategory Where Category Like '" + cboCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { CatID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Insert into tblProduct(ProdCode, BarCode, PDesc, BrandID, CatID, Price) Values(@ProdCode, @BarCode, @PDesc, @BrandID, @CatID, @Price)",cn);
                    cm.Parameters.AddWithValue("@ProdCode", txtbxProdCode.Text);
                    cm.Parameters.AddWithValue("@BarCode", txtbxBarCode.Text);
                    cm.Parameters.AddWithValue("@PDesc", txtbxDesc.Text);
                    cm.Parameters.AddWithValue("@BrandID", BrandID);
                    cm.Parameters.AddWithValue("@CatID", CatID);
                    cm.Parameters.AddWithValue("@Price", txtbxPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been saved");
                    Clear();
                    flist.LoadRecords();
                }
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtbxProdCode.Clear();
            txtbxBarCode.Clear();
            txtbxDesc.Clear();
            cboBrand.Text = "";
            cboCategory.Text = "";
            txtbxPrice.Clear();
            txtbxProdCode.Focus();
            bttnSave.Enabled = true;
            bttnUpdate.Enabled = false;
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string BrandID = "", CatID = "";

                    cn.Open();
                    cm = new SqlCommand("Select ID from tblBrand Where Brand Like '" + cboBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { BrandID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select ID from tblCategory Where Category Like '" + cboCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { CatID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Update tblProduct Set BarCode = @BarCode, PDesc = @PDesc, BrandID = @BrandID, CatID = @CatID, Price = @Price Where ProdCode like @ProdCode", cn);
                    cm.Parameters.AddWithValue("@ProdCode", txtbxProdCode.Text);
                    cm.Parameters.AddWithValue("@BarCode", txtbxBarCode.Text);
                    cm.Parameters.AddWithValue("@PDesc", txtbxDesc.Text);
                    cm.Parameters.AddWithValue("@BrandID", BrandID);
                    cm.Parameters.AddWithValue("@CatID", CatID);
                    cm.Parameters.AddWithValue("@Price", txtbxPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been updated");
                    Clear();
                    flist.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 46)
            {
                //Code for accepting "."
            }
            else if(e.KeyChar == 8)
            {
                //Code to accept backspace
            }
            else if((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true; // ascii code (48-57) so inputs could only be from values 0-9
            }
        }
    }
}
