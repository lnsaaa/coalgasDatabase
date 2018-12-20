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

// 新建进货，入库

namespace coalgasOS
{
    public partial class FormNewInto : FormClass
    {
        public FormNewInto()
        {
            InitializeComponent();
        }

        private void buttonOkNewInto_Click(object sender, EventArgs e)
        {
            
            try
            {

                string supplierID = comboBoxNewIntoSupplier.Text.Trim();
                string coalgasID = comboBoxNewIntoCoalgas.Text.Trim();
                string time = dateTimePickerNewInto.Value.Year.ToString() + "/" + dateTimePickerNewInto.Value.Month.ToString() + "/" + dateTimePickerNewInto.Value.Day.ToString();
                int num;
                string note = textBoxNewIntoNote.Text;
                string isPay;

                if (radioButtonInto1.Checked)
                {
                    isPay = "是";
                }
                else
                {
                    isPay = "否";
                }

                if (supplierID == null || supplierID.Equals(""))
                {
                    MessageBox.Show("供应商不能为空！");
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

                if (numericUpDownNewIntoNum.Text == null || numericUpDownNewIntoNum.Text.Equals(""))
                {
                    MessageBox.Show("数量不能为空！");
                    return;
                }

                num = Convert.ToInt32(numericUpDownNewIntoNum.Text);

                if (num<1)
                {
                    MessageBox.Show("出库数量不能小于1");
                    return;
                }

                // 数据库操作

                SqlCommand command;
                //SqlDataReader objdr;

                connection.Open();  //打开数据库连接

                //插入
                string sql = "insert into into_s (supplier_id,coalgas_id,into_time,into_num,into_pay,into_note) values('" + supplierID + "','" + coalgasID + "','" + time + "'," + num + ",'" + isPay + "','" + note + "')";
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

        private void FormNewInto_Load(object sender, EventArgs e)
        {

            try
            {
                // 数据库操作

                SqlCommand command;
                SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select supplier_id from supplier;";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    comboBoxNewIntoSupplier.Items.Add(reader[0].ToString());        //循环读区数据
                }

                reader.Close();

                comboBoxNewIntoSupplier.SelectedIndex = 0;  // 选中第一行

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); //关闭数据库连接
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
                    comboBoxNewIntoCoalgas.Items.Add(reader[0].ToString());        //循环读区数据
                }

                reader.Close();

                comboBoxNewIntoCoalgas.SelectedIndex = 0;  // 选中第一行

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

        /* 商品库存余量查询显示
         * 
        int kcNum;

        private void comboBoxNewIntoCoalgas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 数据库操作

                SqlCommand command;
                //SqlDataReader reader;

                connection.Open();  //打开数据库连接

                //查询
                string sql = "select coalgas_num from coalgas where coalgas_id='" + comboBoxNewIntoCoalgas.Text + "';";
                command = new SqlCommand(sql, connection);
                kcNum = Convert.ToInt32(command.ExecuteScalar());

                labelNewIntoNum.Text = "进货数量(该商品余量" + kcNum + ")*";

                //reader.Close();
                connection.Close(); //关闭数据库连接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close(); //关闭数据库连接 
            }
        }
         * */

    }
}
