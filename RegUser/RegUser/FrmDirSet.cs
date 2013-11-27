using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win32.DB;

namespace RegUser
{
    public partial class FrmDirSet : Form
    {
        public MDB mDB;
        public FrmDirSet()
        {
            InitializeComponent();
        }

        private void FrmDirSet_Load(object sender, EventArgs e)
        {
            mDB.SQL = "SELECT ITEM,VALUE FROM CFG";
            if (mDB.ListDB())
            {
                mDB.odrReader.Read();
                textBoxDir.Text = mDB.odrReader["VALUE"].ToString();
            }
            mDB.odrReader.Close();  
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            mDB.SQL = "UPDATE CFG SET [VALUE] = '" + textBoxDir.Text + "'" + " WHERE [ITEM]='DIR'";
            if (mDB.ExecSQL())
            {
                MessageBox.Show("保存完毕");
            }
        }
    }
}
