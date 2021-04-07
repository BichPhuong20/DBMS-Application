using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using Oracle.ManagedDataAccess.Client;



namespace GiaoDien
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void buttom_in_User_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand(); 
            command.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
            OracleConnection con = SQLDB.SQLDB.GetConnection();      
            command.Connection = con;
            command.ExecuteNonQuery();
            command.CommandText = "create user "+ textUserName.Text;
            command.ExecuteNonQuery();

            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
