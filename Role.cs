using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDB;
using System.Data.SqlClient;

namespace GiaoDien
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void rolemanagment_label_Click(object sender, EventArgs e)
        {

        }
        
        private void buttom_in_Role_Click(object sender, EventArgs e)
        {
            dgvrolelist.DataSource = OracleDB.
            dgvrolelist.DataSource = SQLDB.SQLDB.SqlDB.ExcuteDataTable("SELECT * FROM ALL_USERS", CommandType.Text);

        }
    }
}
