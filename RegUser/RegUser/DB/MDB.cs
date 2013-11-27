using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace HS.DB
{
    public class MDB : DB
    {
        public OleDbConnection odcConnection;
        public OleDbCommand odCommand;
        public OleDbCommand odCommand2;
        public OleDbCommand odCommand3;
        public OleDbDataReader odrReader;

        public bool OpenDB()
        {
            odcConnection = new OleDbConnection(connStr);
            odcConnection.Open();
            odCommand = odcConnection.CreateCommand();
            odCommand2 = odcConnection.CreateCommand();
            odCommand3 = odcConnection.CreateCommand();
            return true;
        }

        public bool CloseDB()
        {
            odcConnection.Close();
            return true;
        }

        public bool ExecSQL()
        {
            //try
            //{
                odCommand.CommandText = SQL;
                odCommand.ExecuteNonQuery();
                return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }

        public bool ListDB()
        {
            try
            {
                odCommand.CommandText = SQL;
                odrReader = odCommand.ExecuteReader();

                return odrReader.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
        }

        public string GetString(string FieldName)
        {
            int fieldIndex = odrReader.GetOrdinal(FieldName);
            if (odrReader.IsDBNull(fieldIndex))
            {
                return "";
            }
            else
            {
                return odrReader[fieldIndex].ToString();
            }
        }

        public string GetDoubleToStr(string v,string F)
        {
            double d = double.Parse(v);
            return d.ToString(F);
        }

        //获取删除语句1
        public string getDelSql(string tab, string whr)
        {
            string sql = "DELETE FROM " + tab + " WHERE " + whr;
            return sql;
        }
        //获取删除语句2
        public string getSql(string tab, string ifield, string whr)
        {
            string sql = null;
            sql = "SELECT " + ifield + " FROM " + tab + " WHERE " + whr;
            return sql;
        }
        //获取最大的ID值
        public string getMaxID(string tab, string ifield, string whr, int subI, string defaultV)
        {
            string MaxId = null;
            odCommand.CommandText = getSql(tab, "MAX(" + ifield + ") as mId", whr);
            odrReader = odCommand.ExecuteReader();
            while (odrReader.Read())
            {
                MaxId = odrReader["mId"].ToString();
            }
            odrReader.Close();
            if (MaxId.Trim() == "")
            {
                MaxId = defaultV;
            }
            MaxId = getMaxValue(MaxId, subI);
            return MaxId;
        }

        public DataSet getDataSet(string tab, string whr)
        {
            DataSet ds = new DataSet();
            string str = "select * from " + tab + " where " + whr;
            OleDbDataAdapter da = new OleDbDataAdapter(str, odcConnection);
            da.Fill(ds);
            return ds;
        }

        private string getMaxValue(string s, int subI)
        {
            string maxValue = null;
            int iLength = s.Length;
            string maxV1 = s.Substring(0, subI);
            string maxV2 = s.Substring(subI + 1);
            int j = int.Parse(maxV2);
            j = j + 1;
            maxV2 = j.ToString();
            maxV1 = maxV1 + addSubValue(iLength - maxV2.Length - maxV1.Length);
            maxValue = maxV1 + maxV2;
            return maxValue;
        }

        private string addSubValue(int mibI)
        {
            string s = "";
            if (mibI > 0)
            {
                for (int i = 0; i < mibI; i++)
                {
                    s = s + "0";
                }
            }
            return s;
        }
        //更新数据库
        public void updateData(string stab, string sfield, string svalue, string whr)
        {
            odCommand.CommandText = "UPDATE " + stab + " SET " + sfield + "='" + svalue + "' where " + whr;
            odCommand.ExecuteNonQuery();
        }
        //插入数据库
        public void InsData(string stab, string sfields, string svalues)
        {
            odCommand.CommandText = "Insert into " + stab + "(" + sfields + ") values (" + svalues + ")";
            odCommand.ExecuteNonQuery();
        }

        //判断记录是否存在
        public bool bIfInRecord(string sTab, string whr)
        {
            bool btrue = false;
            int i = 0;
            odCommand.CommandText = "select count(*) from " + sTab + " where " + whr;
            odrReader = odCommand.ExecuteReader();
            while (odrReader.Read())
            {
                i = odrReader.GetInt32(0);
            }
            odrReader.Close();
            if (i > 0)
            {
                btrue = true;
            }
            else
            {
                btrue = false;
            }
            return btrue;
        }

        /*public string GetString(string FieldName)
        {
            int fieldIndex = odrReader.GetOrdinal(FieldName);
            if (odrReader.IsDBNull(fieldIndex))
            {
                return "";
            }
            else
            {
                return odrReader[fieldIndex].ToString();
            }
        }

        public string GetDoubleToStr(string v, string F)
        {
            double d = double.Parse(v);
            return d.ToString(F);
        }*/
    }
}
