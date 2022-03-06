using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp1
{
    public partial class CostomerForm : Form
    {
        public CostomerForm()
        {
            InitializeComponent();
        }

        private void CostomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox2, "");
            errCustForm.SetError(textBox3, "");
            errCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (textBox1.Text == "")
            {
                errCustForm.SetError(textBox1, "Please specify a valid car number");
                flag = false;
            }
            else
                errCustForm.SetError(textBox1, "");
            if (textBox2.Text == "")
            {
                errCustForm.SetError(textBox2, "Please specify a valid name");
                flag = false;
            }
            else
                errCustForm.SetError(textBox2, "");
            if (textBox3.Text == "")
            {
                errCustForm.SetError(textBox3, "Please specify a valid address");
                flag = false;
            }
            else
                errCustForm.SetError(textBox3, "");
            if (textBox4.Text == "")
            {
                errCustForm.SetError(textBox4, "Please specify a valid Make");
                flag = false;
            }
            else
                errCustForm.SetError(textBox4, "");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
