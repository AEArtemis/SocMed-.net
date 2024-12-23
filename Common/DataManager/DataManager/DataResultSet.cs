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
    public class DataResultSet
    {
        protected MySqlDataReader m_reader;
        protected MySqlCommand m_cmd;
        private MySqlTransaction m_trTransaction;
        private string m_strErrorDescription;
        private bool m_blnHasTransaction;

        public DataResultSet()
        {
            this.CreateInstance(DataDB.Instance.Connection);
            m_blnHasTransaction = false;
        }

        public void CreateInstance(MySqlConnection conn)
        {
            m_cmd = new MySqlCommand();
            m_cmd.Connection = conn;
            m_cmd.CommandTimeout = 0;
        }

        public void Close()
        {
            if (m_blnHasTransaction)
                m_trTransaction.Dispose();
            try
            {
                m_reader.Dispose();
            }
            catch
            {
            }

            try
            {
                m_cmd.Dispose();
            }
            catch
            {
            }

            DataDB.Instance.CloseConnection();

            GC.Collect();
        }

        public bool Execute()
        {
            try
            {
                m_reader = m_cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                m_strErrorDescription = ex.Message.ToString();
                MessageBox.Show(m_strErrorDescription, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }

            return true;
        }

        public bool Read()
        {
            return m_reader.Read();
        }

        public int ExecuteNonQuery()
        {
            return m_cmd.ExecuteNonQuery();
        }

        public string ErrorDescription
        {
            get { return m_strErrorDescription; }
        }

        public string ExecuteScalar()
        {
            try
            {
                return m_cmd.ExecuteScalar().ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public string Query
        {
            get
            {
                return m_cmd.CommandText;
            }
            set
            {
                m_cmd.Parameters.Clear();
                string strQuery = value;
                m_cmd.CommandText = strQuery;
            }
        }

        public string QueryText
        {
            set { m_cmd.CommandText = value; }
        }

        public string QueryToString()
        {
            string strQuery = string.Empty;
            string strKey = string.Empty;
            string strValue = string.Empty;
            strQuery = m_cmd.CommandText;

            for (int i = m_cmd.Parameters.Count - 1; i >= 0; i--)
            {
                strKey = m_cmd.Parameters[i].ParameterName;
                strValue = string.Empty;
                if (m_cmd.Parameters[i].Value.GetType() == typeof(DateTime))
                    strValue = string.Format("TO_DATE('{0:MM/dd/yyyy}', 'MM/dd/yyyy')", (DateTime)m_cmd.Parameters[i].Value);
                else if (m_cmd.Parameters[i].Value.GetType() == typeof(float))
                    strValue = string.Format("{0:0.00}", (float)m_cmd.Parameters[i].Value);
                else if (m_cmd.Parameters[i].Value.GetType() == typeof(double))
                    strValue = string.Format("{0:0.00}", (double)m_cmd.Parameters[i].Value);
                else if (m_cmd.Parameters[i].Value.GetType() == typeof(int))
                    strValue = string.Format("{0}", (int)m_cmd.Parameters[i].Value);
                else //if (m_cmdCommand.Parameters[i].Value.GetType() == typeof(string))
                    strValue = string.Format("'{0}'", m_cmd.Parameters[i].Value.ToString());
                strQuery = strQuery.Replace(strKey, strValue);
            }

            return strQuery;
        }

        public void AddParameter(string strParameterName, object obj)
        {
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = strParameterName;
            param.Value = obj;
            m_cmd.Parameters.Add(param);
        }

        public bool Transaction
        {
            get { return m_blnHasTransaction; }
            set
            {
                m_blnHasTransaction = value;
                if (m_blnHasTransaction)
                {
                    try
                    {
                        m_trTransaction = DataDB.Instance.Connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    catch
                    {
                        m_blnHasTransaction = false;
                    }
                }
                else
                {
                    try
                    {
                        m_trTransaction.Dispose();
                    }
                    catch { }
                }
            }
        }

        public bool Commit()
        {
            if (m_blnHasTransaction)
            {
                try
                {
                    m_trTransaction.Commit();
                }
                catch (Exception e)
                {
                    m_strErrorDescription = e.Message;
                    return false;
                }
            }
            return true;
        }

        public bool Rollback()
        {
            if (m_blnHasTransaction)
            {
                try
                {
                    m_trTransaction.Rollback();
                }
                catch (Exception e)
                {
                    m_strErrorDescription = e.Message;
                    return false;
                }
            }
            return true;
        }

        public int GetOrdinal(string strColumn)
        {
            return m_reader.GetOrdinal(strColumn);
        }

        public char GetChar(string strColumn)
        {
            return this.GetChar(this.GetOrdinal(strColumn));
        }

        public char GetChar(int intColumn)
        {
            return m_reader.GetChar(intColumn);
        }

        public decimal GetDecimal(string strColumn)
        {
            return this.GetDecimal(this.GetOrdinal(strColumn));
        }

        public decimal GetDecimal(int intColumn)
        {
            return m_reader.GetDecimal(intColumn);
        }

        public int GetInt(string strColumn)
        {
            return this.GetInt(this.GetOrdinal(strColumn));
        }

        public int GetInt(int intColumn)
        {
            return m_reader.GetInt32(intColumn);
        }

        public DateTime GetDateTime(string strColumn)
        {
            return this.GetDateTime(this.GetOrdinal(strColumn));
        }

        public DateTime GetDateTime(int intColumn)
        {
            return m_reader.GetDateTime(intColumn);
        }

        public bool GetBoolean(string strColumn)
        {
            return this.GetBoolean(this.GetOrdinal(strColumn));
        }

        public bool GetBoolean(int intColumn)
        {
            return m_reader.GetBoolean(intColumn);
        }

        public double GetFloat(string strColumn)
        {
            return this.GetFloat(this.GetOrdinal(strColumn));
        }

        public double GetFloat(int intColumn)
        {
            return m_reader.GetFloat(intColumn);
        }

        public double GetDouble(string strColumn)
        {
            return this.GetDouble(this.GetOrdinal(strColumn));
        }

        public double GetDouble(int intColumn)
        {
            return m_reader.GetDouble(intColumn);
        }

        public string GetString(string strColumn)
        {
            return this.GetString(this.GetOrdinal(strColumn));
        }

        public string GetString(int intColumn)
        {
            try
            {
                return m_reader.GetString(intColumn);
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
