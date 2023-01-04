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
    public partial class frmQty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        private String ProdCode;
        private double Price;
        private String TransNo;

        string stitle = "Point of Sale System";
        frmPOS fpos;
        public frmQty(frmPOS frmpos)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = frmpos;
        }

        private void frmQty_Load(object sender, EventArgs e)
        {
           

        }

        public void ProductDetails(String ProdCode, double Price, String TransNo) //String
        {
            this.ProdCode = ProdCode;
            this.Price = Price;
            this.TransNo = TransNo; 
        }

        private void txtbxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == 13) && (txtbxQty.Text != String.Empty))
            {
                cn.Open();
                cm = new SqlCommand("Insert Into tblCart (TransNo, ProdCode, Price, Qty, SDate)Values(@TransNo, @ProdCode, @Price, @Qty, @SDate)", cn);
                cm.Parameters.AddWithValue("@TransNo", TransNo);
                cm.Parameters.AddWithValue("@ProdCode", ProdCode);
                cm.Parameters.AddWithValue("@Price", Price);
                cm.Parameters.AddWithValue("@Qty", int.Parse(txtbxQty.Text));
                cm.Parameters.AddWithValue("@SDate", DateTime.Now);
                cm.ExecuteNonQuery();
                cn.Close();


                fpos.txtbxSearch.Clear();
                fpos.txtbxSearch.Focus();
                fpos.LoadCart();
                this.Dispose();
            }
        }
    }
}
