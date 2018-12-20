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
    public partial class Form0 : FormClass
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            try
            {

                string id = textBox_id.Text;
                string pw = textBox_pw.Text;

                if (id == null || id.Equals(""))
                {
                    MessageBox.Show("账号不能为空！");
                    return;
                }

                if (pw == null || pw.Equals(""))
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                // 数据库操作

                SqlCommand command;
                SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //插入
                string sql = "select user_aa from login where user_id='" + id + "' and user_pw='" + pw + "';";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                
                if (reader.Read())
                { 

                    if ((reader["user_aa"].ToString()).Equals("ra"))
                    {
                        DataClass.userAaData = "ra";
                    }
                    else
                    {
                        DataClass.userAaData = "ro";
                    }

                    DataClass.userNameData = id;

                    Form1 f = new Form1();
                    f.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误, 请重新登录!");
                }

                reader.Close();

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

        private void Form0_Load(object sender, EventArgs e)
        {

            // 测试用
            textBox_id.Text = "000";
            textBox_pw.Text = "123456";

        }
    }
}
