using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonCost
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User employee = new User(tbUsername.Text, tbPassword.Text);

            if (employee.Login())
            {
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}
