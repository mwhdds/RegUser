using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Win32.Objects;
using Win32.Forms;
using Win32.DB;


using System.Management;


namespace RegUser
{
    public partial class FrmUserInfo : Form
    {
        public MDB mDB;
        public string strPath;
        private CXML objXML;

        SymmetricMethod sm = new SymmetricMethod();
        
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            textBoxID.Text = System.DateTime.Now.ToString("yyyyMMdd")+"01";
            textBoxDT.Text = System.DateTime.Now.ToString("yyyy-MM-dd");

            mDB.SQL = "SELECT NAME FROM CUSTOMER";
            if (mDB.ListDB())
            {
                while (mDB.odrReader.Read())
                {
                    textBoxUser.Items.Add(mDB.odrReader["NAME"]);

                }
            }
            mDB.odrReader.Close();
            objXML = new Win32.Objects.CXML();
                    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (textBoxRegInfo.Text != "")
            {
                //建立目录
                string strFile;
                strFile = strPath + "\\" + comboBoxXTLX.Text + "_" + textBoxUser.Text + "_" + numericUpDown1.Value.ToString() + "_" + comboBoxBB.Text + "_" + textBoxBZ.Text + "_WS.TXT";

                if (!Directory.Exists(strPath))//判断文件夹是否已经存在
                {
                    //Directory.CreateDirectory(@"C:\Program Files\TDTK\CoalTraffic\Image\WeightImage");//创建文件夹
                    MessageBox.Show("文件夹不存在");
                    return;
                }

                //拷贝文件
                string strTemplete = CToolKit.GetAppCurPath() + "\\XML\\GT.License";
                if (!File.Exists(strFile))
                {
                    File.Copy(strTemplete, strFile);

                    //打开文件，填写许可号
                    objXML.XMLFile = strFile;
                    objXML.LoadXML();
                    objXML.BaseXPath = "/";
                    objXML.SetItemValue("REG", textBoxRegInfo.Text);
                    objXML.SaveXML();

                    MessageBox.Show("生成完毕！");
                }
                else
                {
                    MessageBox.Show("文件已经存在！");
                }
            }
            else
            {
                MessageBox.Show("请生成序列号");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //MWHDDS 0+开始时间 1+期限2 +单机版还是网络版3 +设备序列号4 +用户名称5 +许可证编号6 +序号7+系统类型8+备注
            string m = "MWHDDS" + "," +
                //+ s + "," + 
                //textBoxDevice.Text + "," + 
                       textBoxUser.Text + "," +
                //textBoxID.Text + "," + 
                       numericUpDown1.Value.ToString() + "," +
                //comboBoxXTLX.Text  + "," + 
                       comboBoxBB.Text + "," +
                       textBoxDT.Text + "," +
                       textBoxDays.Text;

            string n = sm.Encrypto(m);
            textBoxRegInfo.Text = n;


            mDB.SQL = "INSERT INTO Licenses(XKZBH,XH,YHMC,RQ,QX,BB,SBH,XTLX,BZ) VALUES('" +
                                    textBoxID.Text  + "','" +
                                    numericUpDown1.Value.ToString() + "','" +
                                    textBoxUser.Text + "','" +
                                    textBoxDT.Text + "','" +
                                    textBoxDays.Text + "','" +
                                    comboBoxBB.Text + "','" +
                                    textBoxDevice.Text + "','" +
                                    comboBoxXTLX.Text + "','" +
                                    textBoxBZ.Text + 
                                    "')";
            mDB.ExecSQL();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //打开许可文件
        private void button2_Click_1(object sender, EventArgs e)
        {
            string Key = "MWHDDS";
            string str;

            CXML objXML = new Win32.Objects.CXML();
            CFileDialog objFD = new CFileDialog();
            if (objFD.OpenFileDialog("打开许可文件", "许可文件(*.License)|*.License",""))
            {
                objXML.XMLFile = objFD.FileNameFull;
                objXML.LoadXML();

                objXML.BaseXPath = "/";
                str = objXML.GetItemValue("REG");
                str = sm.Decrypto(str);

                if (str.Substring(0, 6) != Key)
                {
                     MessageBox.Show("不是许可文件");
                     return;
                }

                string[] a = str.Split(',');
                textBoxUser.Text = a[5];
                textBoxDevice.Text = a[4];
                textBoxDays.Text = a[2];
                textBoxDT.Text = a[1];
                textBoxID.Text = a[6];
                numericUpDown1.Value = int.Parse(a[7]);
                comboBoxXTLX.Text = a[8];
                textBoxBZ.Text = a[9];

            }
        }
    }
}