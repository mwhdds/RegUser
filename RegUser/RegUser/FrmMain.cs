using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Win32.DB;
using Win32.Objects;

namespace RegUser
{
    public partial class FrmMain : Form
    {
        public MDB mDB;   //Access连接数据库
        public string strPath;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);//分别是宽和高
            listView1.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大

            //连接ACCESS
            mDB = new MDB();
            mDB.connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + CToolKit.GetAppCurPath() + "\\Licenses.mdb";
            mDB.OpenDB();
            ListData();


            mDB.SQL = "SELECT ITEM,VALUE FROM CFG";
            if (mDB.ListDB())
            {
                mDB.odrReader.Read();
                strPath = mDB.odrReader["VALUE"].ToString();
            }
            mDB.odrReader.Close(); 

        }

        private void ListData()
        {
            listView1.Items.Clear();
            System.Windows.Forms.ListViewItem pItem;

            mDB.SQL = "SELECT XKZBH,XH,YHMC,RQ,QX,BB,SBH,BZ FROM Licenses ORDER BY RQ DESC";
            if (mDB.ListDB())
            {
                while (mDB.odrReader.Read())
                {
                    //加入新行
                    pItem = listView1.Items.Add(mDB.odrReader["XKZBH"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["XH"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["YHMC"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["RQ"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["QX"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["BB"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["SBH"].ToString());
                    pItem.SubItems.Add(mDB.odrReader["BZ"].ToString());

                }
            }
            mDB.odrReader.Close();   
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo frmUserInfo = new FrmUserInfo();
            frmUserInfo.mDB = mDB;
            frmUserInfo.strPath = strPath;
            frmUserInfo.ShowDialog();

            ListData();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 目录设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDirSet frmDirSet = new FrmDirSet();
            frmDirSet.mDB = mDB;
            frmDirSet.ShowDialog();

        }

        private void 客户登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}