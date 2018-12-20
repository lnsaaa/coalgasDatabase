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

// 管理，供应商

namespace coalgasOS
{
    public partial class FormDelSupplier : FormClass
    {

        public FormDelSupplier()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询操作,从数据库获取数据,填充到DataGridView,并美化
        /// </summary>
        private void initMyDataGridView()
        {

            connection.Open();  //打开数据库连接

            String sql1 = "select * from Supplier";

            SqlCommand command = new SqlCommand(sql1, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataSet myDataSet = new DataSet();

            dataAdapter.Fill(myDataSet, "Supplier");

            //使用DataSet绑定时，必须同时指明DateMember 
            this.dataGridView.DataSource = myDataSet;
            this.dataGridView.DataMember = "Supplier";

            //改变DataGridView的表头
            this.dataGridView.Columns[0].HeaderText = "编号";
            this.dataGridView.Columns[1].HeaderText = "名称";
            this.dataGridView.Columns[2].HeaderText = "电话";
            this.dataGridView.Columns[3].HeaderText = "地址";
            this.dataGridView.Columns[4].HeaderText = "备注";

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

            //不显示出dataGridView的最后一行空白
            dataGridView.AllowUserToAddRows = false;

            //DataGridView1的第一列只读，不能编辑  
            dataGridView.Columns[0].ReadOnly = true;

            //设置控件选中选中的模式  
            //单击单元格或行标题可以选中整行  
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            connection.Close(); //关闭数据库连接

        }

        private void FormDelSupplier_Load(object sender, EventArgs e)
        {
            initMyDataGridView();
        }

        private void buttonDelSuuplier_Click(object sender, EventArgs e)
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
                    string sql = "delete from supplier where supplier_id = '" + row.Cells[0].Value.ToString() + "';";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int isok = command.ExecuteNonQuery();

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

        bool isClick = true;

        private void dataGridView_Click(object sender, EventArgs e)
        {
            isClick = false;
        }

        private void dataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

            if (isClick)
            {
                return;
            }

            try
            {

                int rowIndex = Convert.ToInt32(e.RowIndex); //行的索引

                // 获取dataGridView的Rows行Cells列的值
                // dataGridView.Rows[rowIndex].Cells[1].Value;

                if (dataGridView.Rows[rowIndex].Cells[1].Value == System.DBNull.Value)
                {
                    MessageBox.Show("值不能为空！结果未保存");
                    return;
                }

                if (dataGridView.Rows[rowIndex].Cells[2].Value == System.DBNull.Value)
                {
                    MessageBox.Show("值不能为空！结果未保存");
                    return;
                }

                if (dataGridView.Rows[rowIndex].Cells[3].Value == System.DBNull.Value)
                {
                    MessageBox.Show("值不能为空！结果未保存");
                    return;
                }

                //获取dataGridView的Rows行Cells列的值
                string id = (string)dataGridView.Rows[rowIndex].Cells[0].Value;
                string name = (string)dataGridView.Rows[rowIndex].Cells[1].Value;
                string phone = (string)dataGridView.Rows[rowIndex].Cells[2].Value;
                string add = (string)dataGridView.Rows[rowIndex].Cells[3].Value;
                string note;

                if (dataGridView.Rows[rowIndex].Cells[4].Value == System.DBNull.Value)
                {
                    note = " ";
                }
                else
                {
                    note = (string)dataGridView.Rows[rowIndex].Cells[4].Value;
                }

                // 数据库操作

                connection.Open();  //打开数据库连接

                // 获取选中的dataGridView的值
                String val = this.dataGridView.SelectedCells[0].Value.ToString();

                //修改
                string sql = "update supplier set supplier_name='" + name + "',supplier_phone='" + phone + "',supplier_add='" + add + "',supplier_note='" + note + "' where supplier_id='" + id + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                int isok = command.ExecuteNonQuery();


                /*
                if (isok == 1)
                {
                    // TODO 悬浮提示
                }
                else
                {
                    MessageBox.Show("新增失败，请检查输入的值是否正确！");
                }
                */

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
