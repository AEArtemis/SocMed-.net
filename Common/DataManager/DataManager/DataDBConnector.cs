using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DataManager
{
    class DataDBConnector:DataConfig
    {
        private string strHost = string.Empty;
        private string strUsername = string.Empty;
        private string strPassword = string.Empty;
        private string strDatabase = string.Empty;
        private string strPort = string.Empty;
        private MySqlConnection m_conn;        

        public DataDBConnector()
        {
            m_conn = new MySqlConnection();
            try
            {
                strHost = m_strHost;
                strUsername = m_strUsername;
                strPassword = m_strPassword;
                strDatabase = m_strDatabase;
                strPort = m_strPort;

                // Check to make sure that our class was passed information
                // from the caller before we attempt to connect
                if (String.IsNullOrEmpty(strHost))
                    throw new InvalidDataException("No Server Specified");
                if (String.IsNullOrEmpty(strUsername))
                    throw new InvalidDataException("No Username Specified");
                if (String.IsNullOrEmpty(strPassword))
                    throw new InvalidDataException("No Password Specified");
                if (String.IsNullOrEmpty(strDatabase))
                    throw new InvalidDataException("No Database Specified");
                if (String.IsNullOrEmpty(strPort))
                    throw new InvalidDataException("No Port Specified");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool OpenConnection()
        {
            try
            {
                //string ConnString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false",
                string ConnString = String.Format("server={0};port={4};user id={1}; password={2}; database={3};",
                strHost, strUsername, strPassword, strDatabase, strPort);
                if (m_conn != null)
                    m_conn.Close();

                // Initialise the connection
                m_conn = new MySqlConnection(ConnString);

                // Open the connection                 
                m_conn.Open();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

            return false;
        }

        public bool CloseConnection()
        {
            if (m_conn == null)
            {
                m_conn.Close();                
                return true;
            }
            return false;
        }

        public MySqlConnection Connection
        {
            get 
            {
                this.OpenConnection();
                return m_conn; 
            }
        }
    }
}
