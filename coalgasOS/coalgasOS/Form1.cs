using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace coalgasOS
{
    public partial class Form1 : FormClass
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewIntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewInto f = new FormNewInto();
            f.Show();
        }

        private void NewOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewOut f = new FormNewOut();
            f.Show();
        }

        private void NewCoalgasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCoalgas f = new FormNewCoalgas();
            f.Show();
        }

        private void NewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewClient f = new FormNewClient();
            f.Show();
        }

        private void NewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewStaff f = new FormNewStaff();
            f.Show();
        }

        private void NewSupplierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormNewSupplier f = new FormNewSupplier();
            f.Show();
        }

        /// <summary>
        /// 跳转到查询窗口,多个查询窗口已合成一个
        /// </summary>
        private void SelFormGo()
        {
            FormSelClient f = new FormSelClient();
            f.Show();
        }

        private void SelCoalgasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataClass.selData = "coalgas";
            SelFormGo();
        }

        private void SelClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataClass.selData = "client";
            SelFormGo();
        }

        private void SelStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataClass.selData = "staff"; 
            SelFormGo();
            
        }

        private void SelSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataClass.selData = "supplier"; 
            SelFormGo();
        }

        private void SelIntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataClass.selData = "into_s";
            SelFormGo();
        }

        private void SelOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataClass.selData = "out_s";
            SelFormGo();
        }

        private void DelCoalgasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelCoalgas f = new FormDelCoalgas();
            f.Show();
        }

        private void DelClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelClient f = new FormDelClient();
            f.Show();
        }

        private void DelStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelStaff f = new FormDelStaff();
            f.Show();
        }

        private void DelSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelSupplier f = new FormDelSupplier();
            f.Show();
        }

        private void ExecTopStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExecTopStaff f = new FormExecTopStaff();
            f.Show();
        }

        private void ExecTopClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExecTopClient f = new FormExecTopClient();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 只读权限
            if (DataClass.userAaData.Equals("ro"))
            {
                NewToolStripMenuItem.Enabled = false;
                DelToolStripMenuItem.Enabled = false;
                toolStripStatusLabelUserAA.Text = "当前权限: 只读";
            }

            toolStripStatusLabelUserName.Text = DataClass.userNameData + ",欢迎您";

            getTopDay();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDataTime.Text = System.DateTime.Now.ToString();  
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.Show();
        }

        private void DelClientPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelClientPay f = new FormDelClientPay();
            f.Show();
        }

        private void DelSupplierPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelSupplierPay f = new FormDelSupplierPay();
            f.Show();
        }

        private void SetUpdatePwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetUpdatePw f = new FormSetUpdatePw();
            f.Show();
        }

        private void SetSwitchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form0 f = new Form0();
            f.Show();
            this.Close(); 
        }

        private void SetOutOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getTopDay();
        }

        /// <summary>
        /// 获取今日销量
        /// </summary>
        private void getTopDay()
        {

            try
            {
                // 数据库操作

                SqlCommand command;
                // SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "exec top_day_out";
                command = new SqlCommand(sql, connection);

                if (command.ExecuteScalar() == System.DBNull.Value)
                {
                    labelTopDayNum.Text = "0";
                }
                else
                {
                    labelTopDayNum.Text = (int)command.ExecuteScalar() + "";
                }

                connection.Close(); //关闭数据库连接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); //关闭数据库连接
            }

        }


    }
}
