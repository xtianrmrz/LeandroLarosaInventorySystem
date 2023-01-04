﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LeandroLarosaInventorySystem
{
    public partial class frmBrandList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmBrandList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();

        }

        public void LoadRecords()
        {
            int z = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select * From tblBrand Order By brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                z += 1;
                dataGridView1.Rows.Add(z, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand(this);
            frm.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmBrand frm = new frmBrand(this);
                frm.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtbxBrand.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this brand?", "Delete Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete From tblBrand Where ID like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
