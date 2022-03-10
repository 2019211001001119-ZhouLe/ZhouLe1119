using DataGridview_Connect_DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMSWinFormsApp1
{
    public partial class WorkerForm : Form
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;port=3306;Initial Catalog=cmsdb;User Id=root;password=123456");
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        BindingSource bSource = new BindingSource();
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mySqlConnectionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData()
        {
            string sqlSelectAll = "SELECT * from tblworker";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDA.Update(table);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
