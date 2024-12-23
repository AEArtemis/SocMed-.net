using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Amellar.Common.EncryptUtilities;
namespace DataManager
{
    class DataConfig
    {
        protected string m_strHost = string.Empty;
        protected string m_strUsername = string.Empty;
        protected string m_strPassword = string.Empty;
        protected string m_strDatabase = string.Empty;
        protected string m_strPort = string.Empty;

        Encryption decrypt = new Encryption();

        public DataConfig()
        {

            //m_strHost = "localhost";
            //m_strUsername = "root";
            //m_strPassword = "daraga2024";
            //m_strDatabase = "fms_property_inventory";
            //m_strPort = "3306";


            m_strHost = ConfigurationManager.AppSettings["Host"];
            m_strUsername = ConfigurationManager.AppSettings["UserId"];
            m_strPassword = decrypt.DecryptString(ConfigurationManager.AppSettings["Password"]);
            m_strDatabase = ConfigurationManager.AppSettings["Database"];
            m_strPort = ConfigurationManager.AppSettings["Port"];
        }


    }
}
