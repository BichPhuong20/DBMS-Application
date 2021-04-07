using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace GiaoDien
{
    class OracleDB
    {
        private static string ConnecString = (@"Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = LOCALHOST)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= ADMIN;Password=123;");
        //Kết nối và mở dữ liệu
        public static OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection(ConnecString);//Kết nối chuỗi dữ liệu
            con.Open();//Mở chuỗi kết nối
            return con;
        }

        OracleCommand command = new OracleCommand();

        public void ExcuteNonQuery(string cmdText, CommandType type = CommandType.Text, OracleParameter[] prms = null)
        {

            command.CommandText = cmdText;
            command.CommandType = type;
            command.Parameters.Clear();
            if (prms != null)
            {
                foreach (OracleParameter p in prms)
                {
                    if (p != null)
                        command.Parameters.Add(p);
                }
            }
            using (OracleConnection con = GetConnection())
            {
                command.Connection = con;
                //transaction = con.BeginTransaction();
                // try
                {
                    command.ExecuteNonQuery();
                    //transaction.Commit();
                }

                //catch { throw new Exception(); }

                con.Close();
            }
        }
        //Lấy dữ liệu thông qua DataSet và DataAdapter
        public DataTable ExcuteDataTable(string cmdText, CommandType type = CommandType.Text, OracleParameter[] prms = null)
        {
            command.CommandText = cmdText;
            command.CommandType = type;
            command.Parameters.Clear();
            if (prms != null)
            {
                foreach (OracleParameter p in prms)
                {
                    if (p != null)
                        command.Parameters.Add(p);
                }
            }

            using (OracleConnection con = GetConnection())
            {
                using (DataSet ds = new DataSet())
                {
                    using (OracleDataAdapter da = new OracleDataAdapter())
                    {
                        command.Connection = con;
                        da.SelectCommand = command;
                        da.Fill(ds);
                        da.Dispose();
                        command.Parameters.Clear();
                        con.Close();
                        return ds.Tables[0];

                    }
                }
            }
        } 


        }
    }
