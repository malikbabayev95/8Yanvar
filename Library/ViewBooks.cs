using System;
using Library.models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlCon))
            //{
            //    string comstring = "Select bk.bookName, bk.bookDate, ath.authName from Books bk" +
            //        " join Authors ath" +
            //        " on bk.bookAuth = ath.ID";
            //    SqlDataAdapter da = new SqlDataAdapter(comstring, con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds,"Books");
            //    dtgReader.DataSource = ds.Tables["Books"];

            //}

            Lib dbb = new Lib();
            dtgReader.DataSource = dbb.Readers.Select(rs=>new
            {
                rs.readName,
                rs.readSur,
                rs.readPhone,
                rs.Facl.fakName
            }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
