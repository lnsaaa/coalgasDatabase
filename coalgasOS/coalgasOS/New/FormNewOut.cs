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

// 新建售货，出库

namespace coalgasOS
{
    public partial class FormNewOut : FormClass
    {
        public FormNewOut()
        {
            InitializeComponent();
        }

        private void buttonOkNewOut_Click(object sender, EventArgs e)
        {

            try
            {

                string clientID = comboBoxNewOutClient.Text;
                string staffID = comboBoxNewOutStaff.Text;
                string coalgasID = comboBoxNewOutCoalgas.Text;
                string time = dateTimePickerNewOut.Value.Year.ToString() + "/" + dateTimePickerNewOut.Value.Month.ToString() + "/" + dateTimePickerNewOut.Value.Day.ToString();
                int num;
                string note = textBoxNewOutNote.Text;

                string isPay;

                if (radioButtonOut1.Checked)
                {
                    isPay = "是";
                }
                else
                {
                    isPay = "否";
                }

                if (clientID == null || clientID.Equals(""))
                {
                    MessageBox.Show("顾客不能为空！");
                    return;
                }

                if (staffID == null || staffID.Equals(""))
                {
                    MessageBox.Show("员工不能为空！");
                    return;
                }

                if (coalgasID == null || coalgasID.Equals(""))
                {
                    MessageBox.Show("商品(煤气)不能为空！");
                    return;
                }

                if (time == null || time.Equals(""))
                {
                    MessageBox.Show("时间不能为空！");
                    return;
                }

                if (numericUpDownNewOutNum.Text == null || numericUpDownNewOutNum.Text.Equals(""))
                {
                    MessageBox.Show("数量不能为空！");
                    return;
                }

                num = Convert.ToInt32(numericUpDownNewOutNum.Text);

                if (num < 1 || num > kcNum)
                {
                    MessageBox.Show("出库数量不能小于1或大于商品余量");
                    return;
                }

                // 数据库操作

                SqlCommand command;
                //SqlDataReader objdr;

                connection.Open();  //打开数据库连接

                //插入
                string sql = "insert into out_s (client_id,staff_id,coalgas_id,out_time,out_num,out_pay,out_note) values('" + clientID + "','" + staffID + "','" + coalgasID + "','" + time + "'," + num + ",'" + isPay + "','" + note + "')";
                command = new SqlCommand(sql, connection);
                int isok = command.ExecuteNonQuery();

                if (isok != -1)
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

        private void FormNewOut_Load(object sender, EventArgs e)
        {

            try
            {
                // 数据库操作

                SqlCommand command;
                SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select client_id from client;";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxNewOutClient.Items.Add(reader[0].ToString());        //循环读区数据
                }

                reader.Close();
                connection.Close(); //关闭数据库连接

                comboBoxNewOutClient.SelectedIndex = 0;  // 选中第一行

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close(); //关闭数据库连接
            }

            try
            {
                // 数据库操作

                SqlCommand command;
                SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select staff_id from staff;";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxNewOutStaff.Items.Add(reader[0].ToString());        //循环读区数据
                }

                reader.Close();
                connection.Close(); //关闭数据库连接

                comboBoxNewOutStaff.SelectedIndex = 0;  // 选中第一行

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close(); //关闭数据库连接
            }

            try
            {
                // 数据库操作

                SqlCommand command;
                SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select coalgas_id from coalgas;";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxNewOutCoalgas.Items.Add(reader[0].ToString());        //循环读区数据
                }

                reader.Close();
                connection.Close(); //关闭数据库连接

                comboBoxNewOutCoalgas.SelectedIndex = 0;  // 选中第一行

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close(); //关闭数据库连接
            }

        }

        int kcNum;

        private void comboBoxNewOutCoalgas_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                // 数据库操作

                SqlCommand command;
                //SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select coalgas_num from coalgas where coalgas_id='" + comboBoxNewOutCoalgas.Text + "';";
                command = new SqlCommand(sql, connection);
                kcNum = Convert.ToInt32(command.ExecuteScalar());

                NewOutNumNewOutNum.Text = "进货数量(该商品余量" + kcNum + ")*";

                //reader.Close();
                connection.Close(); //关闭数据库连接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close(); //关闭数据库连接
            }

        }

    }
}
