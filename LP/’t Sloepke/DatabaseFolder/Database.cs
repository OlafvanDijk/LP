using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using _t_Sloepke.Business;

namespace _t_Sloepke.DatabaseFolder
{
    public class Database
    {
        static OracleConnection m_conn;
        static OracleCommand m_command;
        static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));User ID=dbi336692;PASSWORD=Beijing1;";

        // Open de verbinding met de database
        public static bool OpenConnection()
        {
            bool returnvalue = false;
            m_conn = new OracleConnection();
            try
            {
                m_conn.ConnectionString = connectionString;
                m_conn.Open();
                // Controleer of de verbinding niet al open is
                if (m_conn.State != System.Data.ConnectionState.Open)
                { return true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
            }
            return returnvalue;
        }

        //Sluit verbinding met de database
        public static void CloseConnection()
        {
            try
            { m_conn.Close(); }
            catch (Exception ex)
            { Console.WriteLine("Connection failed: " + ex.Message); }
        }

        public static bool Login(string email, string naam)
        {
            bool check = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT email FROM Huurder WHERE email = :email AND naam = :naam";
                m_command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                m_command.Parameters.Add("naam", OracleDbType.Varchar2).Value = naam;
                m_command.ExecuteNonQuery();
                check = true;
                using (OracleDataReader _Reader = m_command.ExecuteReader())
                {
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            DataHandler.email = _Reader["email"].ToString();
                        }
                    }
                    else
                    {
                        DataHandler.LoginFail("Geen account gevonden");
                    }
                }
            }
            catch (Exception ex)
            {
                check = false;
                CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return check;
        }
    }
}
