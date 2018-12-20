using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

// 管理，费用，客户

namespace coalgasOS
{
    public partial class FormDelClientPay : FormClass
    {


        public FormDelClientPay()
        {

            InitializeComponent();
        }

        /// <summary>
        /// 查询操作,从数据库获取数据,填充到DataGridView,并美化
        /// </summary>
        private void initMyDataGridView()
        {

            connection.Open();  //打开数据库连接

            String sql1 = "select * from out_s where out_pay='否';";

            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataSet myDataSet = new DataSet();

            dataAdapter.Fill(myDataSet, "out_s");

            //使用DataSet绑定时，必须同时指明DateMember 
            this.dataGridView.DataSource = myDataSet;
            this.dataGridView.DataMember = "out_s";

            //改变DataGridView的表头
            this.dataGridView.Columns[0].HeaderText = "售货编号";
            this.dataGridView.Columns[1].HeaderText = "客户编号";
            this.dataGridView.Columns[2].HeaderText = "员工编号";
            this.dataGridView.Columns[3].HeaderText = "商品编号";
            this.dataGridView.Columns[4].HeaderText = "时间";
            this.dataGridView.Columns[5].HeaderText = "数量";
            this.dataGridView.Columns[6].HeaderText = "是否结账";
            this.dataGridView.Columns[7].HeaderText = "备注";

            /*
            //设置DataGridView的列宽度
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 100;
            */

            //自适应DataGridView的列宽度
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //不显示出dataGridView的最后一行空白
            dataGridView.AllowUserToAddRows = false;

            //DataGridView1的第一列只读，不能编辑  
            dataGridView.ReadOnly = true;

            //设置控件选中选中的模式  
            //单击单元格或行标题可以选中整行  
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            connection.Close(); //关闭数据库连接
        }

        private void FormDelClientPay_Load(object sender, EventArgs e)
        {
            initMyDataGridView();
        }

        private void buttonOkPay_Click(object sender, EventArgs e)
        {

            try
            {

                // 数据库操作

                // 循环遍历获取dataGridView选中的行
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    connection.Open();  //打开数据库连接

                    // 获取选中的dataGridView的值
                    // String val = this.dataGridView.SelectedCells[0].Value.ToString();

                    // row.Cells[0].Value.ToString() 获取dataGridView选中的行的值

                    //删除 
                    string sql = "update out_s set out_pay='是' where out_id='" + row.Cells[0].Value.ToString() + "';";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
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

            initMyDataGridView();

        }
    }
}
