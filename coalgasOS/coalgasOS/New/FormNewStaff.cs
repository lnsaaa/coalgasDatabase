﻿using System;
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

// 新建员工

namespace coalgasOS
{
    public partial class FormNewStaff : FormClass
    {
        public FormNewStaff()
        {
            InitializeComponent();
        }

        private void buttonOkNewStaff_Click(object sender, EventArgs e)
        {

            try
            {

                string id = textBoxNewStaffID.Text;
                string name = textBoxNewStaffName.Text;
                string phone = textBoxNewStaffPhone.Text;
                string add = textBoxNewStaffAdd.Text;
                string note = textBoxNewStaffNote.Text;

                if (id == null || id.Equals(""))
                {
                    MessageBox.Show("ID不能为空！");
                    return;
                }

                if (name == null || name.Equals(""))
                {
                    MessageBox.Show("名称不能为空！");
                    return;
                }

                // 数据库操作

                SqlCommand command;
                //SqlDataReader objdr;

                connection.Open();  //打开数据库连接

                //插入
                string sql = "insert into staff values('" + id + "','" + name + "','" + phone + "','" + add + "','" + note + "')";
                command = new SqlCommand(sql, connection);
                int isok = command.ExecuteNonQuery();

                if (isok == 1)
                {
                    this.Close();
                    MessageBox.Show("新增成功！");
                }
                else
                {
                    MessageBox.Show("新增失败，请检查输入的值是否正确！");
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
