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
    public class DataDB
    {        
        static readonly DataDB instance = new DataDB();
        
        private static DataDBConnector m_objDataConnector;

        DataDB()
        {
           
        }            

        private void CreateInstance()
        {
            m_objDataConnector = new DataDBConnector();
        }
        
        public bool OpenConnection()
        {
            this.CreateInstance();
            
            return m_objDataConnector.OpenConnection();
        }        

        public bool CloseConnection()
        {            
            return m_objDataConnector.CloseConnection();
        }

        public static DataDB Instance
        {
            get
            {
                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {                
                CreateInstance();
                m_objDataConnector.OpenConnection();
               
                return m_objDataConnector.Connection;
            }
        }
    }
}
