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
    public partial class FormSetUpdatePw : FormClass
    {
        public FormSetUpdatePw()
        {
            InitializeComponent();
        }

        private void buttonOkSetUpdatePw_Click(object sender, EventArgs e)
        {
            try
            {

                string pw1 = textBoxSetUpdatePw1.Text;
                string pw2 = textBoxSetUpdatePw2.Text;
                string pw3 = textBoxSetUpdatePw3.Text;

                if (pw1 == null || pw1.Equals(""))
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                if (pw2 == null || pw2.Equals(""))
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                if (!pw2.Equals(pw3))
                {
                    MessageBox.Show("两次输入的密码不一样！");
                    return;
                }


                // 数据库操作

                SqlCommand command;
                //SqlDataReader objdr;

                connection.Open();  //打开数据库连接

                //插入
                string sql = "update login set user_pw='" + pw2 + "' where user_id='" + DataClass.userNameData + "' and user_pw='" + pw1 + "';";
                command = new SqlCommand(sql, connection);
                int isok = command.ExecuteNonQuery();

                if (isok == 1)
                {
                    this.Close();
                    MessageBox.Show("密码修改成功！");
                }
                else
                {
                    MessageBox.Show("密码修改失败，旧密码错误！");
                }

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
